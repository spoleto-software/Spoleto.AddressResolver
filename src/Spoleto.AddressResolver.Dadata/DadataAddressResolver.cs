using Dadata;
using Dadata.Model;
using Spoleto.Common.Helpers;

namespace Spoleto.AddressResolver.Dadata
{
    public class DadataAddressResolver : IBusinessDataResolver
    {
        private readonly DadataOptions _options;
        private readonly CleanClientAsync _cleanDadataClient;
        private readonly SuggestClientAsync _suggestDadataClient;

        public DadataAddressResolver(DadataOptions options)
        {
            if (options is null)
                throw new ArgumentNullException(nameof(options));

            // Validates if the options are valid
            options.Validate();

            _options = options;

            _cleanDadataClient = new CleanClientAsync(options.Token, options.Secret);
            _suggestDadataClient = new SuggestClientAsync(_options.Token);
        }

        /// <inheritdoc/>
        public AddressLocationData ResolveLocation(string originalLocationAddress, string countryIsoCode = "RU")
            => AsyncHelper.RunSync(() => ResolveLocationAsync(originalLocationAddress, countryIsoCode));

        /// <inheritdoc/>
        public async Task<AddressLocationData> ResolveLocationAsync(string originalLocationAddress, string countryIsoCode = "RU")
        {
            if (String.IsNullOrEmpty(originalLocationAddress))
                throw new ArgumentNullException(nameof(originalLocationAddress));

            var fullAddress = await _cleanDadataClient.Clean<Address>(originalLocationAddress).ConfigureAwait(false);

            if (fullAddress is not Address dadataAddress)
                throw new ArgumentException($"Could not find the full address for <{originalLocationAddress}>.", nameof(fullAddress));

            var location = dadataAddress.ToAddressLocationData(originalLocationAddress);

            return location;
        }

        /// <inheritdoc/>
        public List<AddressLocation> SuggestLocations(string searchAddressLocation, int resultCount = 5, string? cityFilter = null, string countryIsoCode = "RU")
            => AsyncHelper.RunSync(() => SuggestLocationsAsync(searchAddressLocation, resultCount, countryIsoCode));

        /// <inheritdoc/>
        public async Task<List<AddressLocation>> SuggestLocationsAsync(string searchAddressLocation, int resultCount = 5, string? cityFilter = null, string countryIsoCode = "RU")
        {
            var addressList = await GetAddressAsync(searchAddressLocation, resultCount, cityFilter, countryIsoCode).ConfigureAwait(false);

            return addressList.Where(x => x.data != null).Select(x => x.ToAddressLocation(searchAddressLocation)).ToList();
        }

        private async Task<IList<Suggestion<Address>>> GetAddressAsync(string searchText, int resultCount = 5, string? cityFilter = null, string countryCode = "RU")
        {
            SuggestAddressRequest request;
            if (!string.IsNullOrEmpty(cityFilter)
                && !string.IsNullOrEmpty(countryCode))
            {
                request = new SuggestAddressRequest(searchText, resultCount)
                {
                    locations =
                    [
                        new Address()
                        {
                            city = cityFilter,
                            country_iso_code = countryCode
                        }
                    ],
                    restrict_value = true
                };
            }
            else if (!string.IsNullOrEmpty(cityFilter))
            {
                request = new SuggestAddressRequest(searchText, resultCount)
                {
                    locations =
                    [
                        new Address()
                        {
                            city = cityFilter
                        }
                    ],
                    restrict_value = true
                };

            }
            else if (!string.IsNullOrEmpty(countryCode))
            {
                request = new SuggestAddressRequest(searchText, resultCount)
                {
                    locations =
                    [
                        new Address()
                        {
                            country_iso_code = countryCode
                        }
                    ]
                };

            }
            else
            {
                request = new SuggestAddressRequest(searchText, resultCount);
            }

            var response = await _suggestDadataClient.SuggestAddress(request).ConfigureAwait(false);

            return response?.suggestions;
        }

        /// <inheritdoc/>
        public List<AddressLocation> GetCities(string searchText, string countryIsoCode, int resultCount)
            => AsyncHelper.RunSync(() => GetCitiesAsync(searchText, countryIsoCode, resultCount));

        /// <inheritdoc/>
        public async Task<List<AddressLocation>> GetCitiesAsync(string searchText, string countryIsoCode, int resultCount)
        {
            var request = new SuggestAddressRequest(searchText, resultCount)
            {
                locations_boost =
                  [
                        new Address()
                        {
                            kladr_id = "250000010000"
                        }
                  ],
                locations =
                  [
                        new Address()
                        {
                            city_type_full = "город",
                            country_iso_code = !string.IsNullOrEmpty(countryIsoCode) ? countryIsoCode : null
                        }
                  ],
                from_bound = new AddressBound("city"),
                to_bound = new AddressBound("city")
            };

            var response = await _suggestDadataClient.SuggestAddress(request).ConfigureAwait(false);

            var addressList = response?.suggestions;
            if (addressList == null)
            {
                return [];
            }

            return addressList.Where(x => x.data != null).Select(x => x.ToAddressLocation(searchText)).ToList();
        }

        /// <inheritdoc/>
        public List<AddressLocation> GetAddressByGeoCode(double latitude, double longitude)
            => AsyncHelper.RunSync(() => GetAddressByGeoCodeAsync(latitude, longitude));

        /// <inheritdoc/>
        public async Task<List<AddressLocation>> GetAddressByGeoCodeAsync(double latitude, double longitude)
        {
            var response = await _suggestDadataClient.Geolocate(lat: latitude, lon: longitude).ConfigureAwait(false);

            var addressList = response?.suggestions;
            if (addressList == null)
            {
                return [];
            }

            return addressList.Where(x => x.data != null).Select(x => x.ToAddressLocation($"lat: {latitude}, lon: {longitude}")).ToList();
        }

        /// <inheritdoc/>
        public AddressLocation GetCityByIp(string ip)
            => AsyncHelper.RunSync(() => GetCityByIpAsync(ip));

        /// <inheritdoc/>
        public async Task<AddressLocation> GetCityByIpAsync(string ip)
        {
            var response = await _suggestDadataClient.Iplocate(ip).ConfigureAwait(false);
            var address = response.location;

            return address.ToAddressLocation(ip);
        }

        /// <inheritdoc/>
        public List<Party> GetFirm(string searchINN, bool onlyMainFirm = false)
            => AsyncHelper.RunSync(() => GetFirmAsync(searchINN, onlyMainFirm));

        /// <inheritdoc/>
        public async Task<List<Party>> GetFirmAsync(string searchINN, bool onlyMainFirm = false)
        {
            var request = new FindPartyRequest(searchINN);
            if (onlyMainFirm)
            {
                request.branch_type = global::Dadata.Model.PartyBranchType.MAIN;
            }

            var response = await _suggestDadataClient.FindParty(request).ConfigureAwait(false);

            var firmList = response?.suggestions;
            if (firmList == null)
            {
                return [];
            }

            return firmList.Select(x => x.ToParty()).ToList();
        }
    }
}

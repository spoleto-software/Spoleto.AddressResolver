using Dadata;
using Dadata.Model;
using Spoleto.Common.Helpers;

namespace Spoleto.AddressResolver.Dadata
{
    public class DadataAddressResolver : IAddressResolver
    {
        private readonly DadataOptions _options;
        private readonly SuggestClientAsync _dadataClient;

        public DadataAddressResolver(DadataOptions options)
        {
            if (options is null)
                throw new ArgumentNullException(nameof(options));

            // Validates if the options are valid
            options.Validate();

            _options = options;

            _dadataClient = new SuggestClientAsync(_options.Token);
        }

        /// <inheritdoc/>
        public AddressLocation ResolveLocation(string originalLocationAddress, string countryIsoCode = "RU")
            => AsyncHelper.RunSync(() => ResolveLocationAsync(originalLocationAddress, countryIsoCode));

        /// <inheritdoc/>
        public async Task<AddressLocation> ResolveLocationAsync(string originalLocationAddress, string countryIsoCode = "RU")
        {
            if (String.IsNullOrEmpty(originalLocationAddress))
                throw new ArgumentNullException(nameof(originalLocationAddress));

            var fullAddress = await GetFullAddressAsync(originalLocationAddress, countryIsoCode).ConfigureAwait(false);
            if (fullAddress?.data is not Address dadataAddress)
                throw new ArgumentException($"Could not find the full address for <{originalLocationAddress}>.", nameof(fullAddress));

            var location = ConvertToAddressLocation(originalLocationAddress, dadataAddress);

            return location;
        }

        /// <inheritdoc/>
        public List<AddressLocation> SuggestLocations(string searchAddressLocation, int resultCount = 5, string countryIsoCode = "RU")
            => AsyncHelper.RunSync(() => SuggestLocationsAsync(searchAddressLocation, resultCount, countryIsoCode));

        /// <inheritdoc/>
        public async Task<List<AddressLocation>> SuggestLocationsAsync(string searchAddressLocation, int resultCount = 5, string countryIsoCode = "RU")
        {
            var addressList = await GetAddressAsync(searchAddressLocation, countryCode: countryIsoCode).ConfigureAwait(false);

            return addressList.Where(x => x.data != null).Select(x => ConvertToAddressLocation(searchAddressLocation, x.data)).ToList();
        }

        private async Task<IList<Suggestion<Address>>> GetAddressAsync(string searchText, string? boundCity = null, int resultCount = 5, string countryCode = "RU")
        {
            SuggestAddressRequest request;
            if (!string.IsNullOrEmpty(boundCity))
            {
                request = new SuggestAddressRequest(searchText, resultCount)
                {
                    locations = new Address[]
                    {
                        new Address()
                        {
                            city = boundCity
                        }
                    },
                    restrict_value = true
                };
            }
            else
            {
                request = new SuggestAddressRequest(searchText, resultCount)
                {
                    locations = new Address[]
                    {
                        new Address()
                        {
                            country_iso_code = countryCode
                        }
                    },

                };

            }

            var response = await _dadataClient.SuggestAddress(request).ConfigureAwait(false);

            return response?.suggestions;
        }

        private async Task<Suggestion<Address>> GetFullAddressAsync(string addressValue, string countryCode)
        {
            var fullAddressList = await GetAddressAsync(addressValue, null, 1, countryCode).ConfigureAwait(false);

            return fullAddressList.FirstOrDefault();
        }

        private static AddressLocation ConvertToAddressLocation(string originalLocationAddress, Address dadataAddress)
        {
            return new AddressLocation
            {
                OriginalAddress = originalLocationAddress,
                City = dadataAddress.city,
                CityFiasId = Guid.Parse(dadataAddress.city_fias_id ?? dadataAddress.region_fias_id),
                RegionFiasId = dadataAddress.region_fias_id != null ? Guid.Parse(dadataAddress.region_fias_id) : null,
                CountryCode = dadataAddress.country_iso_code,
                KladrCode = dadataAddress.kladr_id,
                PostalCode = dadataAddress.postal_code,
                Street = dadataAddress.street_with_type,
                House = dadataAddress.house_type + dadataAddress.house,
            };
        }
    }
}

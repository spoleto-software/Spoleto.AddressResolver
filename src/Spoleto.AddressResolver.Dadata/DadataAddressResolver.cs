using Dadata;
using Dadata.Model;
using Spoleto.Common.Helpers;

namespace Spoleto.AddressResolver.Dadata
{
    public class DadataAddressResolver : IAddressResolver
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
        public AddressLocation ResolveLocation(string originalLocationAddress, string countryIsoCode = "RU")
            => AsyncHelper.RunSync(() => ResolveLocationAsync(originalLocationAddress, countryIsoCode));

        /// <inheritdoc/>
        public async Task<AddressLocation> ResolveLocationAsync(string originalLocationAddress, string countryIsoCode = "RU")
        {
            if (String.IsNullOrEmpty(originalLocationAddress))
                throw new ArgumentNullException(nameof(originalLocationAddress));

            var fullAddress = await _cleanDadataClient.Clean<Address>(originalLocationAddress).ConfigureAwait(false);

            if (fullAddress is not Address dadataAddress)
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

            var response = await _suggestDadataClient.SuggestAddress(request).ConfigureAwait(false);

            return response?.suggestions;
        }

        private async Task<Suggestion<Address>> GetFullAddressAsync(string addressValue, string countryCode)
        {
            var fullAddressList = await GetAddressAsync(addressValue, null, 1, countryCode).ConfigureAwait(false);

            return fullAddressList.FirstOrDefault();
        }

        private static AddressLocation ConvertToAddressLocation(string originalLocationAddress, Address dadataAddress)
        {
            if (dadataAddress == null)
                return null;

            return new AddressLocation
            {
                OriginalAddress = dadataAddress.source ?? originalLocationAddress,
                PostalCode = dadataAddress.postal_code,
                Country = dadataAddress.country,
                CountryIsoCode = dadataAddress.country_iso_code,
                FederalDistrict = dadataAddress.federal_district,
                RegionFiasId = Guid.TryParse(dadataAddress.region_fias_id, out var rId) ? rId : null,
                RegionKladrId = dadataAddress.region_kladr_id,
                RegionIsoCode = dadataAddress.region_iso_code,
                RegionWithType = dadataAddress.region_with_type,
                RegionType = dadataAddress.region_type,
                RegionTypeFull = dadataAddress.region_type_full,
                Region = dadataAddress.region,
                AreaFiasId = Guid.TryParse(dadataAddress.area_fias_id, out var aId) ? aId : null,
                AreaKladrId = dadataAddress.area_kladr_id,
                AreaWithType = dadataAddress.area_with_type,
                AreaType = dadataAddress.area_type,
                AreaTypeFull = dadataAddress.area_type_full,
                Area = dadataAddress.area,
                CityFiasId = Guid.Parse(dadataAddress.city_fias_id ?? dadataAddress.region_fias_id),
                CityKladrId = dadataAddress.city_kladr_id,
                CityWithType = dadataAddress.city_with_type,
                CityType = dadataAddress.city_type,
                CityTypeFull = dadataAddress.city_type_full,
                City = dadataAddress.city,
                StreetFiasId = Guid.TryParse(dadataAddress.street_fias_id, out var sId) ? sId : null,
                StreetKladrId = dadataAddress.street_kladr_id,
                StreetWithType = dadataAddress.street_with_type,
                StreetType = dadataAddress.street_type,
                StreetTypeFull = dadataAddress.street_type_full,
                Street = dadataAddress.street,
                House = dadataAddress.house,
                Flat = dadataAddress.flat,
                FiasId = Guid.TryParse(dadataAddress.fias_id, out var fId) ? fId : null,
                FiasLevel = dadataAddress.fias_level,
                KladrId = dadataAddress.kladr_id,
                GeoLat = dadataAddress.geo_lat,
                GeoLon = dadataAddress.geo_lon,
                HistoryValues = dadataAddress.history_values,
                BeltwayDistance = dadataAddress.beltway_distance,
                BeltwayHit = dadataAddress.beltway_hit,
                Block = dadataAddress.block,
                BlockType = dadataAddress.block_type,
                BlockTypeFull = dadataAddress.block_type_full,
                CapitalMarker = dadataAddress.capital_marker,
                CityArea = dadataAddress.city_area,
                CityDistrict = dadataAddress.city_district,
                CityDistrictFiasId = Guid.TryParse(dadataAddress.city_district_fias_id, out var cdId) ? cdId : null,
                CityDistrictKladrId = dadataAddress.city_district_kladr_id,
                CityDistrictType = dadataAddress.city_district_type,
                CityDistrictTypeFull = dadataAddress.city_district_type_full,
                CityDistrictWithType = dadataAddress.city_district_with_type,
                Entrance = dadataAddress.entrance,
                FiasActualityState = dadataAddress.fias_actuality_state,
                FlatArea = dadataAddress.flat_area,
                FlatCadnum = dadataAddress.flat_cadnum,
                FlatFiasId = Guid.TryParse(dadataAddress.flat_fias_id, out var flId) ? flId : null,
                FlatPrice = dadataAddress.flat_price,
                FlatType = dadataAddress.flat_type,
                FlatTypeFull = dadataAddress.flat_type_full,
                Floor = dadataAddress.floor,
                GeonameId = dadataAddress.geoname_id,
                HouseCadnum = dadataAddress.house_cadnum,
                HouseFiasId = Guid.TryParse(dadataAddress.house_fias_id, out var hId) ? hId : null,
                HouseFlatCount = dadataAddress.house_flat_count,
                HouseKladrId = dadataAddress.house_kladr_id,
                HouseType = dadataAddress.house_type,
                HouseTypeFull = dadataAddress.house_type_full,
                Okato = dadataAddress.okato,
                Oktmo = dadataAddress.oktmo,
                PostalBox = dadataAddress.postal_box,
                QcGeo = dadataAddress.qc_geo,
                Room = dadataAddress.room,
                RoomCadnum = dadataAddress.room_cadnum,
                RoomFiasId = Guid.TryParse(dadataAddress.room_fias_id, out var roomId) ? roomId : null,
                RoomType = dadataAddress.room_type,
                RoomTypeFull = dadataAddress.room_type_full,
                Settlement = dadataAddress.settlement,
                SettlementFiasId = Guid.TryParse(dadataAddress.settlement_fias_id, out var setId) ? setId : null,
                SettlementKladrId = dadataAddress.settlement_kladr_id,
                SettlementType = dadataAddress.settlement_type,
                SettlementTypeFull = dadataAddress.settlement_type_full,
                SettlementWithType = dadataAddress.settlement_with_type,
                SquareMeterPrice = dadataAddress.square_meter_price,
                Stead = dadataAddress.stead,
                //SteadCadnum=dadataAddress.stead_cadnum,
                SteadFiasId = Guid.TryParse(dadataAddress.stead_fias_id, out var stId) ? stId : null,
                SteadKladrId = dadataAddress.stead_kladr_id,
                SteadType = dadataAddress.stead_type,
                SteadTypeFull = dadataAddress.stead_type_full,
                SubArea = dadataAddress.sub_area,
                SubAreaFiasId = Guid.TryParse(dadataAddress.sub_area_fias_id, out var subId) ? subId : null,
                SubAreaKladrId = dadataAddress.sub_area_kladr_id,
                SubAreaType = dadataAddress.sub_area_type,
                SubAreaTypeFull = dadataAddress.sub_area_type_full,
                SubAreaWithType = dadataAddress.sub_area_with_type,
                TaxOffice = dadataAddress.tax_office,
                TaxOfficeLegal = dadataAddress.tax_office_legal,
                Timezone = dadataAddress.timezone,
                Metro = dadataAddress.metro?.Select(x => new AddressMetro { Distance = x.distance, Line = x.line, Name = x.name }).ToList(),
                Divisions = dadataAddress.divisions != null
                ? new AddressDivisions
                {
                    Administrative = dadataAddress.divisions.administrative != null
                            ? new AddressAdministrative
                            {
                                Area = ConvertAddressPartFrom(dadataAddress.divisions.administrative.area),
                                City = ConvertAddressPartFrom(dadataAddress.divisions.administrative.city),
                                PlanningStructure = ConvertAddressPartFrom(dadataAddress.divisions.administrative.planning_structure),
                                Settlement = ConvertAddressPartFrom(dadataAddress.divisions.administrative.settlement),
                                CityDistrict = ConvertAddressPartFrom(dadataAddress.divisions.administrative.city_district)
                            }
                            : null,
                    Municipal = dadataAddress.divisions.municipal != null
                            ? new AddressMunicipal
                            {
                                Area = ConvertAddressPartFrom(dadataAddress.divisions.municipal.area),
                                City = ConvertAddressPartFrom(dadataAddress.divisions.municipal.city),
                                PlanningStructure = ConvertAddressPartFrom(dadataAddress.divisions.municipal.planning_structure),
                                Settlement = ConvertAddressPartFrom(dadataAddress.divisions.municipal.settlement),
                                SubArea = ConvertAddressPartFrom(dadataAddress.divisions.municipal.sub_area)
                            }
                            : null
                }
                : null
            };
        }

        private static AddressPart? ConvertAddressPartFrom(global::Dadata.Model.AddressPart from)
        {
            if (from == null)
            {
                return null;
            }

            return new()
            {
                FiasId = Guid.TryParse(from.fias_id, out var id) ? id : null,
                KladrId = from.kladr_id,
                Name = from.name,
                NameWithType = from.name_with_type,
                Type = from.type,
                TypeFull = from.type_full
            };
        }
    }
}

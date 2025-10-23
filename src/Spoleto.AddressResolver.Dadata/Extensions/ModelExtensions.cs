using Dadata.Model;

namespace Spoleto.AddressResolver.Dadata
{
    internal static class ModelExtensions
    {
        public static AddressLocation ToAddressLocation(this Suggestion<Address> from, string? originalLocationAddress = null)
        {
            if (from == null)
                return null;

            var dadataAddress = from.data;

            return new AddressLocation
            {
                Value = from.value,
                UnrestrictedValue = from.unrestricted_value,
                Data = new AddressLocationData
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
                                Area = dadataAddress.divisions.administrative.area.ToAddressLocationPart(),
                                City = dadataAddress.divisions.administrative.city.ToAddressLocationPart(),
                                PlanningStructure = dadataAddress.divisions.administrative.planning_structure.ToAddressLocationPart(),
                                Settlement = dadataAddress.divisions.administrative.settlement.ToAddressLocationPart(),
                                CityDistrict = dadataAddress.divisions.administrative.city_district.ToAddressLocationPart()
                            }
                            : null,
                    Municipal = dadataAddress.divisions.municipal != null
                            ? new AddressMunicipal
                            {
                                Area = dadataAddress.divisions.municipal.area.ToAddressLocationPart(),
                                City = dadataAddress.divisions.municipal.city.ToAddressLocationPart(),
                                PlanningStructure = dadataAddress.divisions.municipal.planning_structure.ToAddressLocationPart(),
                                Settlement = dadataAddress.divisions.municipal.settlement.ToAddressLocationPart(),
                                SubArea = dadataAddress.divisions.municipal.sub_area.ToAddressLocationPart()
                            }
                            : null
                }
                : null
                }
            };
        }

        public static AddressLocationData ToAddressLocationData(this Address from, string? originalLocationAddress = null)
        {
            if (from == null)
                return null;

            return new AddressLocationData
            {
                OriginalAddress = originalLocationAddress,
                Source= from.source,
                Qc = from.qc,
                PostalCode = from.postal_code,
                Country = from.country,
                CountryIsoCode = from.country_iso_code,
                FederalDistrict = from.federal_district,
                RegionFiasId = Guid.TryParse(from.region_fias_id, out var rId) ? rId : null,
                RegionKladrId = from.region_kladr_id,
                RegionIsoCode = from.region_iso_code,
                RegionWithType = from.region_with_type,
                RegionType = from.region_type,
                RegionTypeFull = from.region_type_full,
                Region = from.region,
                AreaFiasId = Guid.TryParse(from.area_fias_id, out var aId) ? aId : null,
                AreaKladrId = from.area_kladr_id,
                AreaWithType = from.area_with_type,
                AreaType = from.area_type,
                AreaTypeFull = from.area_type_full,
                Area = from.area,
                CityFiasId = Guid.Parse(from.city_fias_id ?? from.region_fias_id),
                CityKladrId = from.city_kladr_id,
                CityWithType = from.city_with_type,
                CityType = from.city_type,
                CityTypeFull = from.city_type_full,
                City = from.city,
                StreetFiasId = Guid.TryParse(from.street_fias_id, out var sId) ? sId : null,
                StreetKladrId = from.street_kladr_id,
                StreetWithType = from.street_with_type,
                StreetType = from.street_type,
                StreetTypeFull = from.street_type_full,
                Street = from.street,
                House = from.house,
                Flat = from.flat,
                FiasId = Guid.TryParse(from.fias_id, out var fId) ? fId : null,
                FiasLevel = from.fias_level,
                KladrId = from.kladr_id,
                GeoLat = from.geo_lat,
                GeoLon = from.geo_lon,
                HistoryValues = from.history_values,
                BeltwayDistance = from.beltway_distance,
                BeltwayHit = from.beltway_hit,
                Block = from.block,
                BlockType = from.block_type,
                BlockTypeFull = from.block_type_full,
                CapitalMarker = from.capital_marker,
                CityArea = from.city_area,
                CityDistrict = from.city_district,
                CityDistrictFiasId = Guid.TryParse(from.city_district_fias_id, out var cdId) ? cdId : null,
                CityDistrictKladrId = from.city_district_kladr_id,
                CityDistrictType = from.city_district_type,
                CityDistrictTypeFull = from.city_district_type_full,
                CityDistrictWithType = from.city_district_with_type,
                Entrance = from.entrance,
                FiasActualityState = from.fias_actuality_state,
                FlatArea = from.flat_area,
                FlatCadnum = from.flat_cadnum,
                FlatFiasId = Guid.TryParse(from.flat_fias_id, out var flId) ? flId : null,
                FlatPrice = from.flat_price,
                FlatType = from.flat_type,
                FlatTypeFull = from.flat_type_full,
                Floor = from.floor,
                GeonameId = from.geoname_id,
                HouseCadnum = from.house_cadnum,
                HouseFiasId = Guid.TryParse(from.house_fias_id, out var hId) ? hId : null,
                HouseFlatCount = from.house_flat_count,
                HouseKladrId = from.house_kladr_id,
                HouseType = from.house_type,
                HouseTypeFull = from.house_type_full,
                Okato = from.okato,
                Oktmo = from.oktmo,
                PostalBox = from.postal_box,
                QcGeo = from.qc_geo,
                Room = from.room,
                RoomCadnum = from.room_cadnum,
                RoomFiasId = Guid.TryParse(from.room_fias_id, out var roomId) ? roomId : null,
                RoomType = from.room_type,
                RoomTypeFull = from.room_type_full,
                Settlement = from.settlement,
                SettlementFiasId = Guid.TryParse(from.settlement_fias_id, out var setId) ? setId : null,
                SettlementKladrId = from.settlement_kladr_id,
                SettlementType = from.settlement_type,
                SettlementTypeFull = from.settlement_type_full,
                SettlementWithType = from.settlement_with_type,
                SquareMeterPrice = from.square_meter_price,
                Stead = from.stead,
                //SteadCadnum=dadataAddress.stead_cadnum,
                SteadFiasId = Guid.TryParse(from.stead_fias_id, out var stId) ? stId : null,
                SteadKladrId = from.stead_kladr_id,
                SteadType = from.stead_type,
                SteadTypeFull = from.stead_type_full,
                SubArea = from.sub_area,
                SubAreaFiasId = Guid.TryParse(from.sub_area_fias_id, out var subId) ? subId : null,
                SubAreaKladrId = from.sub_area_kladr_id,
                SubAreaType = from.sub_area_type,
                SubAreaTypeFull = from.sub_area_type_full,
                SubAreaWithType = from.sub_area_with_type,
                TaxOffice = from.tax_office,
                TaxOfficeLegal = from.tax_office_legal,
                Timezone = from.timezone,
                Metro = from.metro?.Select(x => new AddressMetro { Distance = x.distance, Line = x.line, Name = x.name }).ToList(),
                Divisions = from.divisions != null
                ? new AddressDivisions
                {
                    Administrative = from.divisions.administrative != null
                            ? new AddressAdministrative
                            {
                                Area = from.divisions.administrative.area.ToAddressLocationPart(),
                                City = from.divisions.administrative.city.ToAddressLocationPart(),
                                PlanningStructure = from.divisions.administrative.planning_structure.ToAddressLocationPart(),
                                Settlement = from.divisions.administrative.settlement.ToAddressLocationPart(),
                                CityDistrict = from.divisions.administrative.city_district.ToAddressLocationPart()
                            }
                            : null,
                    Municipal = from.divisions.municipal != null
                            ? new AddressMunicipal
                            {
                                Area = from.divisions.municipal.area.ToAddressLocationPart(),
                                City = from.divisions.municipal.city.ToAddressLocationPart(),
                                PlanningStructure = from.divisions.municipal.planning_structure.ToAddressLocationPart(),
                                Settlement = from.divisions.municipal.settlement.ToAddressLocationPart(),
                                SubArea = from.divisions.municipal.sub_area.ToAddressLocationPart()
                            }
                            : null
                }
                : null
            };
        }

        private static AddressLocationPart? ToAddressLocationPart(this AddressPart from)
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

        public static Party ToParty(this Suggestion< global::Dadata.Model.Party> fromSuggestion)
        {
            if (fromSuggestion?.data == null)
            {
                return null;
            }

            var from = fromSuggestion.data;

            return new()
            {
                Value = fromSuggestion.value,
                UnrestrictedValue = fromSuggestion.unrestricted_value,
                Data = new PartyData
                {
                    Address = new PartyAddress
                    {
                        //Invalidity= from.address.
                        Value = from.address?.value,
                        UnrestrictedValue = from.address?.unrestricted_value,
                        Data = from.address?.data.ToAddressLocationData()
                    },
                    Authorities = from.authorities == null ? null
                    : new PartyAuthorities
                    {
                        FtsRegistration = from.authorities.fts_registration.ToPartyAuthority(),
                        FtsReport = from.authorities.fts_report.ToPartyAuthority(),
                        Pf = from.authorities.pf.ToPartyAuthority(),
                        Sif = from.authorities.sif.ToPartyAuthority()
                    },
                    BranchCount = from.branch_count,
                    BranchType = (Spoleto.AddressResolver.PartyBranchType)Enum.Parse(typeof(Spoleto.AddressResolver.PartyBranchType), from.branch_type.ToString()),
                    Capital = from.capital == null ? null
                    : new PartyCapital
                    {
                        Type = from.capital.type,
                        Value = from.capital.value
                    },
                    Citizenship = from.citizenship == null ? null
                : new PartyCitizenship
                {
                    Code = from.citizenship.code == null ? null
                         : new PartyCitizenshipCode
                         {
                             Alpha3 = from.citizenship.code.alpha_3,
                             Numeric = from.citizenship.code.numeric
                         },
                    Name = from.citizenship.name == null ? null
                        : new PartyCitizenshipName
                        {
                            Full = from.citizenship.name.full,
                            Short = from.citizenship.name.@short,
                        }
                },
                    Documents = from.documents == null ? null
                    : new PartyDocuments
                    {
                        FtsRegistration = from.documents.fts_registration.ToPartyDocument(),
                        FtsReport = from.documents.fts_report.ToPartyDocument(),
                        PfRegistration = from.documents.pf_registration.ToPartyDocument(),
                        SifRegistration = from.documents.sif_registration.ToPartyDocument(),
                        Smb = from.documents.smb.ToPartyDocumentSmb()
                    },
                    Emails = from.emails == null ? null
                    : from.emails.Where(x => x.data != null).Select(x => new PartyEmail { Data = new PartyEmailData { Domain = x.data.domain, Local = x.data.local, Source = x.data.source }, Value = x.value, UnrestrictedValue = x.unrestricted_value }).ToList(),
                    EmployeeCount = from.employee_count,
                    Finance = from.finance == null ? null
                    : new PartyFinance
                    {
                        Debt = from.finance.debt,
                        Expense = from.finance.expense,
                        Income = from.finance.income,
                        Penalty = from.finance.penalty,
                        Revenue = from.finance.revenue,
                        TaxSystem = from.finance.tax_system.ToString(),
                        Year = from.finance.year
                    },
                    Fio = from.fio?.ToPartyFio(),
                    Founders = from.founders == null ? null
                : from.founders.Select(x => new PartyFounder
                {
                    Fio = x.fio.ToPartyFio(),
                    Hid = x.hid,
                    Inn = x.inn,
                    Name = x.name,
                    Ogrn = x.ogrn,
                    StartDate = x.start_date,
                    Type = x.type.ToString(),
                    Invalidity = x.invalidity.ToPartyInvalidity(),
                    Share = x.share == null ? null
                    : new PartyFounderShare
                    {
                        Denominator = x.share.denominator,
                        Numerator = x.share.numerator,
                        Value = x.share.value,
                        Type = x.type.ToString(),
                    }
                }).ToList(),

                    Hid = from.hid,
                    Inn = from.inn,
                    Kpp = from.kpp,
                    KppLargest = from.kpp_largest,
                    Invalid = from.invalid,
                    Licenses = from.licenses == null ? null
                    : from.licenses.Select(x => x.ToPartyLicense()).ToList(),

                    Management = from.management == null ? null
                    : new PartyManagement
                    {
                        Name = from.management.name,
                        Post = from.management.post,
                        StartDate = from.management.start_date,
                        Disqualified = from.management.disqualified
                    },

                    Managers = from.managers == null ? null
                    : from.managers.Select(x => x.ToPartyManager()).ToList(),

                    Name = from.name == null ? null
                    : new PartyName
                    {
                        Full = from.name.full,
                        FullWithOpf = from.name.full_with_opf,
                        Latin = from.name.latin,
                        Short = from.name.@short,
                        ShortWithOpf = from.name.short_with_opf
                    },

                    Ogrn = from.ogrn,
                    OgrnDate = from.ogrn_date,
                    Okato = from.okato,
                    Okfs = from.okfs,
                    Okogu = from.okogu,
                    Okpo = from.okpo,
                    Oktmo = from.oktmo,
                    Okved = from.okved,
                    OkvedType = from.okved_type,
                    Okveds = from.okveds == null ? null
                    : from.okveds.Select(x => new PartyOkved { Code = x.code, Main = x.main, Name = x.name, Type = x.type }).ToList(),

                    Opf = from.opf == null ? null
                    : new PartyOpf
                    {
                        Code = from.opf.code,
                        Full = from.opf.full,
                        Short = from.opf.@short,
                        //Type=from.opf.type
                    },

                    Phones = from.phones == null ? null
                    : from.phones.Where(x => x.data != null).Select(x => new PartyPhone { Data = x.data.ToPartyPhoneData(), Value = x.value, UnrestrictedValue = x.unrestricted_value }).ToList(),

                    Predecessors = from.predecessors == null ? null
                    : from.predecessors.Select(x => new PartyPredecessor { Inn = x.inn, Name = x.ogrn, Ogrn = x.ogrn }).ToList(),

                    State = from.state == null ? null
                    : new PartyState
                    {
                        ActualityDate = from.state.actuality_date,
                        Code = from.state.code,
                        LiquidationDate = from.state.liquidation_date,
                        RegistrationDate = from.state.registration_date,
                        Status = from.state.status.ToString()
                    },

                    Successors = from.successors == null ? null
                    : from.successors.Select(x => new PartySuccessor { Inn = x.inn, Name = x.name, Ogrn = x.name }).ToList(),

                    Type = from.type.ToString()
                }
            };
        }

        private static PartyAuthority? ToPartyAuthority(this global::Dadata.Model.PartyAuthority from)
        {
            if (from == null)
            {
                return null;
            }

            return new PartyAuthority
            {
                Address = from.address,
                Code = from.code,
                Name = from.name,
                Type = from.type
            };
        }

        private static PartyDocument? ToPartyDocument(this global::Dadata.Model.PartyDocument from)
        {
            if (from == null)
            {
                return null;
            }

            return new PartyDocument
            {
                IssueAuthority = from.issue_authority,
                IssueDate = from.issue_date,
                Number = from.number,
                Series = from.series,
                Type = from.type
            };
        }

        private static PartyDocumentSmb? ToPartyDocumentSmb(this global::Dadata.Model.PartySmb from)
        {
            if(from == null)
            {
                return null;
            }

            return new PartyDocumentSmb
            {
                Category = from.category.ToString(),
                IssueDate = from.issue_date,
                Type = from.type
            };
        }

        private static PartyFio? ToPartyFio(this global::Dadata.Model.Fullname from)
        {
            if (from == null)
            {
                return null;
            }

            return new PartyFio
            {
                Gender = from.gender,
                Name = from.name,
                Patronymic = from.patronymic,
                Surname = from.surname
            };
        }

        private static PartyInvalidity? ToPartyInvalidity(this global::Dadata.Model.PartyInvalidity from)
        {
            if (from == null)
            {
                return null;
            }

            return new PartyInvalidity
            {
                Code = from.code.ToString(),
                Decision = from.decision == null ? null
                    : new PartyInvalidityDecision
                    {
                        CourtName = from.decision.court_name,
                        Date = from.decision.date,
                        Number = from.decision.number,

                    }
            };
        }

        private static PartyLicense ToPartyLicense(this global::Dadata.Model.PartyLicense from)
        {
            if (from == null)
            {
                return null;
            }

            return new PartyLicense
            {
                Activities = from.activities,
                Addresses = from.addresses,
                IssueAuthority = from.issue_authority,
                IssueDate = from.issue_date,
                Number = from.number,
                Series = from.series,
                SuspendAuthority = from.suspend_authority,
                SuspendDate = from.suspend_date,
                ValidFrom = from.valid_from,
                ValidTo = from.valid_to
            };
        }

        private static PartyManager ToPartyManager(this global::Dadata.Model.PartyManager from)
        {
            if (from == null)
            {
                return null;
            }

            return new PartyManager
            {
                Fio = from.fio.ToPartyFio(),
                Hid = from.hid,
                Inn = from.inn,
                Name = from.name,
                Ogrn = from.ogrn,
                Post = from.post,
                StartDate = from.start_date,
                Type = from.type.ToString(),
                Invalidity = from.invalidity.ToPartyInvalidity()
            };
        }

        private static PartyPhoneData ToPartyPhoneData(this global::Dadata.Model.Phone from)
        {
            if (from == null)
            {
                return null;
            }

            return new PartyPhoneData
            {
                City = from.city,
                CityCode = from.city_code,
                //Contact = from.contact,
                CountryCode = from.country_code,
                Number = from.number,
                Provider = from.provider,
                Region = from.region,
                Source = from.source,
                Timezone = from.timezone,
                Type = from.type
            };
        }
    }
}

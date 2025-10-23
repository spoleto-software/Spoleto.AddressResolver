namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Детальная информация по адресу.
    /// </summary>
    public record AddressLocationData
    {
        /// <summary>Исходный адрес для запроса.</summary>
        public string OriginalAddress { get; set; }

        /// <summary>
        /// Адрес одной строкой как в ЕГРЮЛ
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Код проверки адреса
        /// </summary>
        public string Qc { get; set; }

        /// <summary>Индекс.</summary>
        public string PostalCode { get; set; }

        /// <summary>Страна.</summary>
        public string Country { get; set; }

        /// <summary>ISO-код страны (двухсимвольный).</summary>
        public string CountryIsoCode { get; set; }

        /// <summary>Федеральный округ.</summary>
        public string FederalDistrict { get; set; }

        /// <summary>ФИАС-код региона.</summary>
        public Guid? RegionFiasId { get; set; }

        /// <summary>КЛАДР-код региона.</summary>
        public string RegionKladrId { get; set; }

        /// <summary>ISO-код региона.</summary>
        public string RegionIsoCode { get; set; }

        /// <summary>Регион с типом.</summary>
        public string RegionWithType { get; set; }

        /// <summary>Тип региона (сокращённый).</summary>
        public string RegionType { get; set; }

        /// <summary>Тип региона (полный).</summary>
        public string RegionTypeFull { get; set; }

        /// <summary>Регион.</summary>
        public string Region { get; set; }

        /// <summary>ФИАС-код района в регионе.</summary>
        public Guid? AreaFiasId { get; set; }

        /// <summary>КЛАДР-код района в регионе.</summary>
        public string AreaKladrId { get; set; }

        /// <summary>Район в регионе с типом.</summary>
        public string AreaWithType { get; set; }

        /// <summary>Тип района в регионе (сокращённый).</summary>
        public string AreaType { get; set; }

        /// <summary>Тип района в регионе (полный).</summary>
        public string AreaTypeFull { get; set; }

        /// <summary>Район в регионе.</summary>
        public string Area { get; set; }

        /// <summary>ФИАС-код муниципального поселения.</summary>
        public Guid? SubAreaFiasId { get; set; }

        /// <summary>КЛАДР-код муниципального поселения.</summary>
        public string SubAreaKladrId { get; set; }

        /// <summary>Муниципальное поселение с типом.</summary>
        public string SubAreaWithType { get; set; }

        /// <summary>Тип муниципального поселения (сокращённый).</summary>
        public string SubAreaType { get; set; }

        /// <summary>Тип муниципального поселения (полный).</summary>
        public string SubAreaTypeFull { get; set; }

        /// <summary>Муниципальное поселение.</summary>
        public string SubArea { get; set; }

        /// <summary>ФИАС-код города.</summary>
        public Guid CityFiasId { get; set; }

        /// <summary>КЛАДР-код города.</summary>
        public string CityKladrId { get; set; }

        /// <summary>Город с типом.</summary>
        public string CityWithType { get; set; }

        /// <summary>Тип города (сокращённый).</summary>
        public string CityType { get; set; }

        /// <summary>Тип города (полный).</summary>
        public string CityTypeFull { get; set; }

        /// <summary>Город.</summary>
        public string City { get; set; }

        /// <summary>ФИАС-код административного района города.</summary>
        public Guid? CityDistrictFiasId { get; set; }

        /// <summary>КЛАДР-код административного района города (обычно не заполняется).</summary>
        public string CityDistrictKladrId { get; set; }

        /// <summary>Административный район города с типом.</summary>
        public string CityDistrictWithType { get; set; }

        /// <summary>Тип административного района города (сокращённый).</summary>
        public string CityDistrictType { get; set; }

        /// <summary>Тип административного района города (полный).</summary>
        public string CityDistrictTypeFull { get; set; }

        /// <summary>Административный район города.</summary>
        public string CityDistrict { get; set; }

        /// <summary>ФИАС-код населённого пункта.</summary>
        public Guid? SettlementFiasId { get; set; }

        /// <summary>КЛАДР-код населённого пункта.</summary>
        public string SettlementKladrId { get; set; }

        /// <summary>Населённый пункт с типом.</summary>
        public string SettlementWithType { get; set; }

        /// <summary>Тип населённого пункта (сокращённый).</summary>
        public string SettlementType { get; set; }

        /// <summary>Тип населённого пункта (полный).</summary>
        public string SettlementTypeFull { get; set; }

        /// <summary>Населённый пункт.</summary>
        public string Settlement { get; set; }

        /// <summary>ФИАС-код улицы.</summary>
        public Guid? StreetFiasId { get; set; }

        /// <summary>КЛАДР-код улицы.</summary>
        public string StreetKladrId { get; set; }

        /// <summary>Улица с типом.</summary>
        public string StreetWithType { get; set; }

        /// <summary>Тип улицы (сокращённый).</summary>
        public string StreetType { get; set; }

        /// <summary>Тип улицы (полный).</summary>
        public string StreetTypeFull { get; set; }

        /// <summary>Улица.</summary>
        public string Street { get; set; }

        /// <summary>ФИАС-код земельного участка.</summary>
        public Guid? SteadFiasId { get; set; }

        /// <summary>КЛАДР-код земельного участка.</summary>
        public string SteadKladrId { get; set; }

        /// <summary>Тип участка (сокращённый, «уч»).</summary>
        public string SteadType { get; set; }

        /// <summary>Тип участка (полный, «участок»).</summary>
        public string SteadTypeFull { get; set; }

        /// <summary>Номер земельного участка.</summary>
        public string Stead { get; set; }

        /// <summary>Кадастровый номер участка.</summary>
        public string SteadCadnum { get; set; }

        /// <summary>ФИАС-код дома.</summary>
        public Guid? HouseFiasId { get; set; }

        /// <summary>КЛАДР-код дома.</summary>
        public string HouseKladrId { get; set; }

        /// <summary>Кадастровый номер дома.</summary>
        public string HouseCadnum { get; set; }

        /// <summary>Тип дома (сокращённый).</summary>
        public string HouseType { get; set; }

        /// <summary>Тип дома (полный).</summary>
        public string HouseTypeFull { get; set; }

        /// <summary>Дом.</summary>
        public string House { get; set; }

        /// <summary>Количество квартир в доме.</summary>
        public string HouseFlatCount { get; set; }

        /// <summary>Тип корпуса/строения (сокращённый).</summary>
        public string BlockType { get; set; }

        /// <summary>Тип корпуса/строения (полный).</summary>
        public string BlockTypeFull { get; set; }

        /// <summary>Корпус/строение.</summary>
        public string Block { get; set; }

        /// <summary>Подъезд (не заполняется).</summary>
        public string Entrance { get; set; }

        /// <summary>Этаж (не заполняется).</summary>
        public string Floor { get; set; }

        /// <summary>ФИАС-код квартиры.</summary>
        public Guid? FlatFiasId { get; set; }

        /// <summary>Тип квартиры (сокращённый).</summary>
        public string FlatType { get; set; }

        /// <summary>Тип квартиры (полный).</summary>
        public string FlatTypeFull { get; set; }

        /// <summary>Квартира.</summary>
        public string Flat { get; set; }

        /// <summary>Кадастровый номер квартиры.</summary>
        public string FlatCadnum { get; set; }

        /// <summary>Площадь квартиры.</summary>
        public string FlatArea { get; set; }

        /// <summary>Рыночная стоимость м².</summary>
        public string SquareMeterPrice { get; set; }

        /// <summary>Рыночная стоимость квартиры.</summary>
        public string FlatPrice { get; set; }

        /// <summary>ФИАС-код комнаты.</summary>
        public Guid? RoomFiasId { get; set; }

        /// <summary>Тип комнаты (сокращённый).</summary>
        public string RoomType { get; set; }

        /// <summary>Тип комнаты (полный).</summary>
        public string RoomTypeFull { get; set; }

        /// <summary>Комната.</summary>
        public string Room { get; set; }

        /// <summary>Кадастровый номер комнаты.</summary>
        public string RoomCadnum { get; set; }

        /// <summary>Абонентский ящик.</summary>
        public string PostalBox { get; set; }

        /// <summary>ФИАС-код адреса (или аналогичный идентификатор).</summary>
        public Guid? FiasId { get; set; }

        /// <summary>Уровень детализации адреса.</summary>
        public string FiasLevel { get; set; }

        /// <summary>Признак актуальности адреса в ФИАС.</summary>
        public string FiasActualityState { get; set; }

        /// <summary>КЛАДР-код.</summary>
        public string KladrId { get; set; }

        /// <summary>Идентификатор GeoNames.</summary>
        public string GeonameId { get; set; }

        /// <summary>Признак центра района или региона.</summary>
        public string CapitalMarker { get; set; }

        /// <summary>Код ОКАТО.</summary>
        public string Okato { get; set; }

        /// <summary>Код ОКТМО.</summary>
        public string Oktmo { get; set; }

        /// <summary>Код ИФНС для физических лиц.</summary>
        public string TaxOffice { get; set; }

        /// <summary>Код ИФНС для организаций.</summary>
        public string TaxOfficeLegal { get; set; }

        /// <summary>Список исторических названий объекта нижнего уровня.</summary>
        public List<string> HistoryValues { get; set; }

        /// <summary>Широта координат.</summary>
        public string GeoLat { get; set; }

        /// <summary>Долгота координат.</summary>
        public string GeoLon { get; set; }

        /// <summary>Код точности координат.</summary>
        public string QcGeo { get; set; }

        /// <summary>Административный округ (только для Москвы).</summary>
        public string CityArea { get; set; }

        /// <summary>Внутри кольцевой?</summary>
        public string BeltwayHit { get; set; }

        /// <summary>Расстояние от кольцевой в километрах.</summary>
        public string BeltwayDistance { get; set; }

        /// <summary>Часовой пояс.</summary>
        public string Timezone { get; set; }

        /// <summary>Список ближайших станций метро (до трёх штук).</summary>
        public List<AddressMetro>? Metro { get; set; }

        /// <summary>Административное и муниципальное деление</summary>
        public AddressDivisions? Divisions { get; set; }
    }
}

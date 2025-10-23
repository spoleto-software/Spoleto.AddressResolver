namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Детальные данные по телефону.
    /// </summary>
    public record PartyPhoneData
    {
        /// <summary>Телефон одной строкой как в ЕГРЮЛ</summary>
        public string Source { get; set; }

        /// <summary>Тип телефона (мобильный, стационарный и т.д.)</summary>
        public string Type { get; set; }

        /// <summary>Код страны</summary>
        public string CountryCode { get; set; }

        /// <summary>Код города / DEF-код</summary>
        public string CityCode { get; set; }

        /// <summary>Локальный номер телефона</summary>
        public string Number { get; set; }

        /// <summary>Оператор связи</summary>
        public string Provider { get; set; }

        /// <summary>Регион (если известен)</summary>
        public string Region { get; set; }

        /// <summary>Город (только для стационарных телефонов)</summary>
        public string City { get; set; }

        /// <summary>Часовой пояс</summary>
        public string Timezone { get; set; }

        /// <summary>Контактное лицо</summary>
        public string Contact { get; set; }
    }
}

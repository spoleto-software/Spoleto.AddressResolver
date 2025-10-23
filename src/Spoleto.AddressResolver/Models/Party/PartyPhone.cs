namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Телефонная запись организации
    /// </summary>
    public record PartyPhone
    {
        public string Value { get; set; }

        public string UnrestrictedValue { get; set; }

        /// <summary>Данные телефона</summary>
        public PartyPhoneData Data { get; set; }
    }
}

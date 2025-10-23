namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Компания/ИП.
    /// </summary>
    public record Party
    {
        public string Value { get; set; }

        public string UnrestrictedValue { get; set; }

        /// <summary>Детальная информация</summary>
        public PartyData Data { get; set; }
    }
}

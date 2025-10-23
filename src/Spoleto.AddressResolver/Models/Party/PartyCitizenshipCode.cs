namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Код страны.
    /// </summary>
    public record PartyCitizenshipCode
    {
        /// <summary>Числовой код страны по ОКСМ</summary>
        public string Numeric { get; set; }

        /// <summary>Трехбуквенный код страны по ОКСМ</summary>
        public string Alpha3 { get; set; }
    }
}

namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Адрес.
    /// </summary>
    public record AddressLocation
    {
        /// <summary>
        /// Адрес одной строкой
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Адрес одной строкой (полный, с индексом)
        /// </summary>
        public string UnrestrictedValue { get; set; }

        /// <summary>Детальная информация</summary>
        public AddressLocationData Data { get; set; }
    }
}
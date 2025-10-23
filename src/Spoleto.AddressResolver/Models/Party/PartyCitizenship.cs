namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Гражданство ИП.
    /// </summary>
    public record PartyCitizenship
    {
        /// <summary>
        /// Код страны.
        /// </summary>
        public PartyCitizenshipCode? Code { get; set; }

        /// <summary>
        /// Наименование страны.
        /// </summary>
        public PartyCitizenshipName? Name { get; set; }
    }
}

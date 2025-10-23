namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Наименование страны.
    /// </summary>
    public record PartyCitizenshipName
    {
        /// <summary>Полное наименование страны</summary>
        public string Full { get; set; }

        /// <summary>Краткое наименование страны</summary>
        public string Short { get; set; }
    }
}

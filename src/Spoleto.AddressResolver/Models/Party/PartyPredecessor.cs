namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Правопредшественник (только для юрлиц).
    /// </summary>
    public record PartyPredecessor
    {
        /// <summary>
        /// ОГРН предшественника.
        /// </summary>
        public string Ogrn { get; set; }

        /// <summary>
        /// ИНН предшественника
        /// </summary>
        public string Inn { get; set; }

        /// <summary>
        /// Наименование предшественника
        /// </summary>
        public string Name { get; set; }
    }
}

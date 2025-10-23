namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Запись в реестре малого и среднего предпринимательства
    /// </summary>
    public record PartyDocumentSmb
    {
        /// <summary>
        /// Тип документа
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// категория предприятия (MICRO, SMALL или MEDIUM)
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Дата регистрации в реестре
        /// </summary>
        public DateTime? IssueDate { get; set; }
    }
}

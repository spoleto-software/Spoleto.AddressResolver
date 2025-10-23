namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Информация о документе.
    /// </summary>
    public record PartyDocument
    {
        /// <summary>
        /// Тип документа
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Серия документа
        /// </summary>
        public string Series { get; set; }

        /// <summary>
        /// Номер документа
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Дата выдачи
        /// </summary>
        public DateTime? IssueDate { get; set; }

        /// <summary>
        /// Код подразделения
        /// </summary>
        public string IssueAuthority { get; set; }
    }
}

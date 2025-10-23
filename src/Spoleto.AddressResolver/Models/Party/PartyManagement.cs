namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Руководитель компании.
    /// </summary>
    public record PartyManagement
    {
        /// <summary>Наименование руководителя или ФИО</summary>
        public string Name { get; set; }

        /// <summary>Должность руководителя (для физлиц)</summary>
        public string Post { get; set; }

        /// <summary>Дата вступления в должность руководителя</summary>
        public DateTime? StartDate { get; set; }

        public string Disqualified { get; set; }
    }
}

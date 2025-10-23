namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Учредитель компании.
    /// </summary>
    public record PartyFounder
    {
        /// <summary>
        /// ОГРН учредителя (для юрлиц)
        /// </summary>
        public string Ogrn { get; set; }

        /// <summary>
        /// ИНН учредителя
        /// </summary>
        public string Inn { get; set; }

        /// <summary>
        /// Наименование учредителя (для юрлиц)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ФИО учредителя (для физлиц)
        /// </summary>
        public PartyFio Fio { get; set; }

        /// <summary>
        /// Внутренний идентификатор
        /// </summary>
        public string Hid { get; set; }

        /// <summary>Тип учредителя: LEGAL / PHYSICAL</summary>
        public string Type { get; set; }

        /// <summary>Дата вступления в права учредителя</summary>
        public DateTime? StartDate { get; set; }

        /// <summary>Доля учредителя</summary>
        public PartyFounderShare? Share { get; set; }

        /// <summary>Недостоверность сведений об учредителе</summary>
        public PartyInvalidity? Invalidity { get; set; }
    }
}

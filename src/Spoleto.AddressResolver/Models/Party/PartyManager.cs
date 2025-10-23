namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Руководитель компании.
    /// </summary>
    public record PartyManager
    {
        /// <summary>
        /// ОГРН руководителя (для юрлиц)
        /// </summary>
        public string Ogrn { get; set; }

        /// <summary>
        /// ИНН руководителя
        /// </summary>
        public string Inn { get; set; }

        /// <summary>
        /// Наименование руководителя (для юрлиц)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ФИО руководителя (для физлиц)
        /// </summary>
        public PartyFio Fio { get; set; }

        /// <summary>
        /// Должность руководителя (для физлиц)
        /// </summary>
        public string Post { get; set; }

        /// <summary>
        /// Внутренний идентификатор.
        /// </summary>
        public string Hid { get; set; }

        /// <summary>Тип руководителя: EMPLOYEE / FOREIGNER / LEGAL</summary>
        public string Type { get; set; }

        /// <summary>Дата вступления в должность</summary>
        public DateTime? StartDate { get; set; }

        /// <summary>Недостоверность сведений о руководителе</summary>
        public PartyInvalidity Invalidity { get; set; }
    }
}

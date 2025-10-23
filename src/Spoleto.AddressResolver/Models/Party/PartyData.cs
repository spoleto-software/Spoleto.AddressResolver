namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Детальная информация о компании/ИП.
    /// </summary>
    public record PartyData
    {
        /// <summary>ИНН</summary>
        public string Inn { get; set; }

        /// <summary>КПП</summary>
        public string Kpp { get; set; }

        /// <summary>КПП крупнейшего налогоплательщика</summary>
        public string KppLargest { get; set; }

        /// <summary>ОГРН</summary>
        public string Ogrn { get; set; }

        /// <summary>Дата выдачи ОГРН</summary>
        public DateTime? OgrnDate { get; set; }

        /// <summary>Внутренний идентификатор в DaData</summary>
        public string Hid { get; set; }

        /// <summary>Тип организации: LEGAL — юридическое лицо, INDIVIDUAL — индивидуальный предприниматель</summary>
        public string Type { get; set; }

        /// <summary>Наименование организации</summary>
        public PartyName? Name { get; set; }

        /// <summary>ФИО индивидуального предпринимателя</summary>
        public PartyFio? Fio { get; set; }

        /// <summary>Код ОКАТО</summary>
        public string Okato { get; set; }

        /// <summary>Код ОКТМО</summary>
        public string Oktmo { get; set; }

        /// <summary>Код ОКПО</summary>
        public string Okpo { get; set; }

        /// <summary>Код ОКОГУ</summary>
        public string Okogu { get; set; }

        /// <summary>Код ОКФС</summary>
        public string Okfs { get; set; }

        /// <summary>Код ОКВЭД</summary>
        public string Okved { get; set; }

        /// <summary>Версия справочника ОКВЭД (2001 или 2014)</summary>
        public string OkvedType { get; set; }

        /// <summary>Организационно-правовая форма</summary>
        public PartyOpf? Opf { get; set; }

        /// <summary>Руководитель компании</summary>
        public PartyManagement? Management { get; set; }

        /// <summary>Количество филиалов</summary>
        public string BranchCount { get; set; }

        /// <summary>Тип подразделения: MAIN — головная организация, BRANCH — филиал</summary>
        public PartyBranchType BranchType { get; set; }

        /// <summary>Адрес организации или ИП</summary>
        public PartyAddress? Address { get; set; }

        /// <summary>Состояние организации</summary>
        public PartyState? State { get; set; }

        /// <summary>Среднесписочная численность работников</summary>
        public int? EmployeeCount { get; set; }

        /// <summary>Финансовые показатели за год</summary>
        public PartyFinance? Finance { get; set; }

        /// <summary>Коды ОКВЭД дополнительных видов деятельности</summary>
        public List<PartyOkved>? Okveds { get; set; }

        /// <summary>Сведения о налоговой, ПФР и ФСС</summary>
        public PartyAuthorities? Authorities { get; set; }

        /// <summary>Гражданство ИП</summary>
        public PartyCitizenship? Citizenship { get; set; }

        /// <summary>Учредители компании</summary>
        public List<PartyFounder>? Founders { get; set; }

        /// <summary>Руководители компании</summary>
        public List<PartyManager>? Managers { get; set; }

        /// <summary>Правопредшественники (только для юрлиц)</summary>
        public List<PartyPredecessor>? Predecessors { get; set; }

        /// <summary>Правопреемники (только для юрлиц)</summary>
        public List<PartySuccessor>? Successors { get; set; }

        /// <summary>Уставной капитал компании</summary>
        public PartyCapital? Capital { get; set; }

        /// <summary>Документы организации</summary>
        public PartyDocuments? Documents { get; set; }

        /// <summary>Лицензии</summary>
        public List<PartyLicense>? Licenses { get; set; }

        /// <summary>Телефоны организации</summary>
        public List<PartyPhone>? Phones { get; set; }

        /// <summary>Электронные почты организации</summary>
        public List<PartyEmail>? Emails { get; set; }

        /// <summary>Признак недостоверных сведений об организации (true/null)</summary>
        public bool? Invalid { get; set; }
    }
}

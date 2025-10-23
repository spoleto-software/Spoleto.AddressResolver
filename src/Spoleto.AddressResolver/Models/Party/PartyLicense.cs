namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Лицензия организации.
    /// </summary>
    public record PartyLicense
    {
        /// <summary>Серия документа</summary>
        public string Series { get; set; }

        /// <summary>Номер документа</summary>
        public string Number { get; set; }

        /// <summary>Дата выдачи лицензии</summary>
        public DateTime? IssueDate { get; set; }

        /// <summary>Орган, выдавший лицензию</summary>
        public string IssueAuthority { get; set; }

        /// <summary>Дата приостановки лицензии</summary>
        public DateTime? SuspendDate { get; set; }

        /// <summary>Орган, приостановивший лицензию</summary>
        public string SuspendAuthority { get; set; }

        /// <summary>Дата начала действия лицензии</summary>
        public DateTime? ValidFrom { get; set; }

        /// <summary>Дата окончания действия лицензии</summary>
        public DateTime? ValidTo { get; set; }

        /// <summary>Перечень лицензируемых видов деятельности</summary>
        public List<string> Activities { get; set; }

        /// <summary>Перечень адресов, по которым действует лицензия</summary>
        public List<string> Addresses { get; set; }
    }
}

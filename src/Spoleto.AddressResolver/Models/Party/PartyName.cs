namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Наименование организации.
    /// </summary>
    public record PartyName
    {
        /// <summary>Полное наименование с ОПФ</summary>
        public string FullWithOpf { get; set; }

        /// <summary>Краткое наименование с ОПФ</summary>
        public string ShortWithOpf { get; set; }

        /// <summary>Латиница (не заполняется)</summary>
        public string Latin { get; set; }

        /// <summary>Полное наименование без ОПФ</summary>
        public string Full { get; set; }

        /// <summary>Краткое наименование без ОПФ</summary>
        public string Short { get; set; }
    }
}

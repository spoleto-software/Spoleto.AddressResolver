namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Организационно-правовая форма.
    /// </summary>
    public record PartyOpf
    {
        /// <summary>Код ОКОПФ</summary>
        public string Code { get; set; }

        /// <summary>Полное название ОПФ</summary>
        public string Full { get; set; }

        /// <summary>Краткое название ОПФ</summary>
        public string Short { get; set; }

        /// <summary>Версия справочника ОКОПФ (99, 2012, 2014)</summary>
        public string Type { get; set; }
    }
}

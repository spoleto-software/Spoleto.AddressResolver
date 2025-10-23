namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Код ОКВЭД дополнительных видов деятельности.
    /// </summary>
    public record PartyOkved
    {
        /// <summary>Основной или дополнительный вид деятельности (true/false)</summary>
        public bool Main { get; set; }

        /// <summary>Версия справочника ОКВЭД (2001 или 2014)</summary>
        public string Type { get; set; }

        /// <summary>Код по справочнику</summary>
        public string Code { get; set; }

        /// <summary>Наименование по справочнику</summary>
        public string Name { get; set; }
    }
}

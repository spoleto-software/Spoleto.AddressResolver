namespace Spoleto.AddressResolver
{
    public record PartyAuthority
    {
        /// <summary>Код гос. органа</summary>
        public string Type { get; set; }

        /// <summary>Код отделения</summary>
        public string Code { get; set; }

        /// <summary>Наименование отделения</summary>
        public string Name { get; set; }

        /// <summary>Адрес отделения одной строкой</summary>
        public string Address { get; set; }
    }
}

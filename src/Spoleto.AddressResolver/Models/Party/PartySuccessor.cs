namespace Spoleto.AddressResolver
{
    /// <summary>Правопреемник (только для юрлиц)</summary>
    public record PartySuccessor
    {
        /// <summary>
        /// ОГРН преемника
        /// </summary>
        public string Ogrn { get; set; }

        /// <summary>
        /// ИНН преемника
        /// </summary>
        public string Inn { get; set; }

        /// <summary>
        /// Наименование преемника
        /// </summary>
        public string Name { get; set; }
    }
}

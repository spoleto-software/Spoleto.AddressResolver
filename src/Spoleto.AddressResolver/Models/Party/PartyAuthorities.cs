namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Сведения о налоговой, ПФР и ФСС.
    /// </summary>
    public record PartyAuthorities
    {
        /// <summary>ИФНС регистрации</summary>
        public PartyAuthority? FtsRegistration { get; set; }

        /// <summary>ИФНС отчетности</summary>
        public PartyAuthority? FtsReport { get; set; }

        /// <summary>Отделение Пенсионного фонда</summary>
        public PartyAuthority? Pf { get; set; }

        /// <summary>Отделение Фонда соц. страхования</summary>
        public PartyAuthority? Sif { get; set; }
    }
}

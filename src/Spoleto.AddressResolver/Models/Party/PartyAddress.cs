namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Адрес организации или ИП.
    /// </summary>
    public record PartyAddress : AddressLocation
    {
        /// <summary>Недостоверность сведений об адресе</summary>
        public PartyInvalidity Invalidity { get; set; }
    }
}

namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Электронная почта организации.
    /// </summary>
    public record PartyEmail
    {
        public string Value { get; set; }

        public string UnrestrictedValue { get; set; }

        /// <summary>Данные email</summary>
        public PartyEmailData Data { get; set; }
    }
}

namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Недостоверность сведений
    /// </summary>
    public record PartyInvalidity
    {
        /// <summary>Код причины недостоверности: PARTY, FTS, COURT, OTHER</summary>
        public string Code { get; set; }

        /// <summary>Решение суда (только если Code = COURT)</summary>
        public PartyInvalidityDecision? Decision { get; set; }
    }
}

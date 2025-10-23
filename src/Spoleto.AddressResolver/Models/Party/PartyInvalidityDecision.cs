namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Решение суда (только если Code = COURT).
    /// </summary>
    public record PartyInvalidityDecision
    {
        public string CourtName { get; set; }
        public string Number { get; set; }
        public DateTime? Date { get; set; }
    }
}

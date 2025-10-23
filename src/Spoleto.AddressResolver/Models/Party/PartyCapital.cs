namespace Spoleto.AddressResolver
{
    /// <summary>Уставной капитал компании</summary>
    public record PartyCapital
    {
        /// <summary>Тип капитала</summary>
        public string Type { get; set; }

        /// <summary>Размер капитала</summary>
        public decimal? Value { get; set; }
    }
}

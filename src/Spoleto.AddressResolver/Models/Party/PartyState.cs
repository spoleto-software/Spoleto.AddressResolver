namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Состояние организации.
    /// </summary>
    public record PartyState
    {
        /// <summary>Дата последних изменений</summary>
        public DateTime? ActualityDate { get; set; }

        /// <summary>Дата регистрации</summary>
        public DateTime? RegistrationDate { get; set; }

        /// <summary>Дата ликвидации</summary>
        public DateTime? LiquidationDate { get; set; }

        /// <summary>Статус организации: ACTIVE, LIQUIDATING, LIQUIDATED, BANKRUPT, REORGANIZING</summary>
        public string Status { get; set; }

        /// <summary>Детальный статус</summary>
        public string Code { get; set; }
    }
}

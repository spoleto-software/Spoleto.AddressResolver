namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Доля учредителя.
    /// </summary>
    public record PartyFounderShare
    {
        /// <summary>Тип значения: PERCENT / DECIMAL / FRACTION</summary>
        public string Type { get; set; }

        /// <summary>Значение для PERCENT и DECIMAL</summary>
        public decimal Value { get; set; }

        /// <summary>Числитель дроби (для FRACTION)</summary>
        public long Numerator { get; set; }

        /// <summary>Знаменатель дроби (для FRACTION)</summary>
        public long Denominator { get; set; }
    }
}

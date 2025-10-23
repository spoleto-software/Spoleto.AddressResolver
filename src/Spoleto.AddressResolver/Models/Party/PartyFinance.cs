namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Финансовые показатели за год.
    /// </summary>
    public record PartyFinance
    {
        /// <summary>Год бухгалтерской отчетности</summary>
        public int? Year { get; set; }

        /// <summary>Доходы по бухгалтерской отчетности</summary>
        public decimal? Income { get; set; }

        /// <summary>Выручка по бухгалтерской отчетности</summary>
        public decimal? Revenue { get; set; }

        /// <summary>Расходы по бухгалтерской отчетности</summary>
        public decimal? Expense { get; set; }

        /// <summary>Недоимки по налогам</summary>
        public decimal? Debt { get; set; }

        /// <summary>Налоговые штрафы</summary>
        public decimal? Penalty { get; set; }

        /// <summary>Система налогообложения: AUSN, ESHN, SRP, USN</summary>
        public string TaxSystem { get; set; }
    }
}

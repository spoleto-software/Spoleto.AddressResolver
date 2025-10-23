namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Детальные данные по email.
    /// </summary>
    public record PartyEmailData
    {
        /// <summary>Email одной строкой как в ЕГРЮЛ</summary>
        public string Source { get; set; }

        /// <summary>Локальная часть адреса (до «@»)</summary>
        public string Local { get; set; }

        /// <summary>Домен (часть после «@»)</summary>
        public string Domain { get; set; }
    }
}

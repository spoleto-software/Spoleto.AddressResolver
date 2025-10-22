namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Информация о ближайшем метро
    /// </summary>
    public record AddressMetro
    {
        /// <summary>Название станции</summary>
        public string Name { get; set; }

        /// <summary>Название линии</summary>
        public string Line { get; set; }

        /// <summary>Расстояние до станции в километрах</summary>
        public decimal Distance { get; set; }
    }
}
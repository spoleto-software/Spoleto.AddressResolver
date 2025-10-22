namespace Spoleto.AddressResolver
{
    public record AddressPart
    {
        public Guid? FiasId { get; set; }

        public string KladrId { get; set; }

        public string Type { get; set; }

        public string TypeFull { get; set; }

        public string Name { get; set; }

        public string NameWithType { get; set; }
    }
}
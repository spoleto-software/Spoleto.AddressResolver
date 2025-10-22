namespace Spoleto.AddressResolver
{
    public record AddressMunicipal
    {
        public AddressPart? Area { get; set; }

        public AddressPart? SubArea { get; set; }

        public AddressPart? City { get; set; }

        public AddressPart? Settlement { get; set; }

        public AddressPart? PlanningStructure { get; set; }
    }
}
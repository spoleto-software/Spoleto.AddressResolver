namespace Spoleto.AddressResolver
{
    public record AddressMunicipal
    {
        public AddressLocationPart? Area { get; set; }

        public AddressLocationPart? SubArea { get; set; }

        public AddressLocationPart? City { get; set; }

        public AddressLocationPart? Settlement { get; set; }

        public AddressLocationPart? PlanningStructure { get; set; }
    }
}
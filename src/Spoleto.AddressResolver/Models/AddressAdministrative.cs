namespace Spoleto.AddressResolver
{
    public record AddressAdministrative
    {
        public AddressPart? Area { get; set; }

        public AddressPart? City { get; set; }

        public AddressPart? CityDistrict { get; set; }

        public AddressPart? Settlement { get; set; }

        public AddressPart? PlanningStructure { get; set; }
    }
}
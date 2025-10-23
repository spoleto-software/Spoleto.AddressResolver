namespace Spoleto.AddressResolver
{
    public record AddressAdministrative
    {
        public AddressLocationPart? Area { get; set; }

        public AddressLocationPart? City { get; set; }

        public AddressLocationPart? CityDistrict { get; set; }

        public AddressLocationPart? Settlement { get; set; }

        public AddressLocationPart? PlanningStructure { get; set; }
    }
}
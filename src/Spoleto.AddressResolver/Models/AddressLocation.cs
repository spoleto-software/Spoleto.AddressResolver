namespace Spoleto.AddressResolver
{
    public class AddressLocation
    {
        public string OriginalAddress { get; set; }

        public string City { get; set; }

        public Guid CityFiasId { get; set; }

        public string CountryCode { get; set; }

        public string KladrCode { get; set; }

        public string PostalCode { get; set; }

        public string House { get; set; }

        public string Street { get; set; }

        public Guid? RegionFiasId { get; set; }
    }
}

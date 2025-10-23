namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Административное и муниципальное деление
    /// </summary>
    public record AddressDivisions
    {
        public AddressAdministrative? Administrative { get; set; }

        public AddressMunicipal? Municipal { get; set; }
    }
}
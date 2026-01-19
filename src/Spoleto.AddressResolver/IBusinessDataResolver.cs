namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Aggregates both address, firm and person resolution capabilities.
    /// </summary>
    public interface IBusinessDataResolver : IAddressResolver, IFirmResolver, IPersonResolver
    {
    }
}

namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Aggregates both address and firm resolution capabilities.
    /// </summary>
    public interface IBusinessDataResolver : IAddressResolver, IFirmResolver
    {
    }
}

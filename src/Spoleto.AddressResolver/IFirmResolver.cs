namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Provides methods for resolving information about legal entities and organizations.
    /// </summary>
    public interface IFirmResolver
    {
        /// <summary>
        /// Finds firms (organizations) by INN.
        /// </summary>
        /// <param name="searchINN">The INN (Tax ID) to search for.</param>
        /// <param name="onlyMainFirm">Whether to return only the main organization (true) or all related (false).</param>
        /// <returns>A list of matching <see cref="Party"/> objects.</returns>
        List<Party> GetFirm(string searchINN, bool onlyMainFirm = false);

        /// <summary>
        /// Asynchronously finds firms (organizations) by INN.
        /// </summary>
        /// <param name="searchINN">The INN (Tax ID) to search for.</param>
        /// <param name="onlyMainFirm">Whether to return only the main organization (true) or all related (false).</param>
        /// <returns>A task returning a list of matching <see cref="Party"/> objects.</returns>
        Task<List<Party>> GetFirmAsync(string searchINN, bool onlyMainFirm = false);
    }
}

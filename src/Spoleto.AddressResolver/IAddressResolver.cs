namespace Spoleto.AddressResolver
{
    /// <summary>
    /// The address resolver.
    /// </summary>
    public interface IAddressResolver
    {
        /// <summary>
        /// Resolves the <see cref="AddressLocation"/>.
        /// </summary>
        /// <param name="originalAddressLocation">The string address.</param>
        /// <param name="countryIsoCode">ISO country code.</param>
        /// <returns>The resolved instance of <see cref="AddressLocation"/>.</returns>
        AddressLocation ResolveLocation(string searchAddressLocation, string countryIsoCode = "RU");

        /// <summary>
        /// Async resolves the <see cref="AddressLocation"/>.
        /// </summary>
        /// <param name="originalAddressLocation">The string address.</param>
        /// <param name="countryIsoCode">ISO country code.</param>
        /// <returns>The resolved instance of <see cref="AddressLocation"/>.</returns>
        Task<AddressLocation> ResolveLocationAsync(string searchAddressLocation, string countryIsoCode = "RU");

        /// <summary>
        /// Suggests addresses.
        /// </summary>
        /// <param name="searchAddressLocation">The string address to search.</param>
        /// <param name="resultCount">The limit of results. Default: 5.</param>
        /// <param name="countryIsoCode">ISO country code.</param>
        /// <returns>The list of <see cref="AddressLocation"/>.</returns>
        List<AddressLocation> SuggestLocations(string searchAddressLocation, int resultCount = 5, string countryIsoCode = "RU");

        /// <summary>
        /// Async suggests addresses.
        /// </summary>
        /// <param name="searchAddressLocation">The string address to search.</param>
        /// <param name="resultCount">The limit of results. Default: 5.</param>
        /// <param name="countryIsoCode">ISO country code.</param>
        /// <returns>The list of <see cref="AddressLocation"/>.</returns>
        Task<List<AddressLocation>> SuggestLocationsAsync(string searchAddressLocation, int resultCount = 5, string countryIsoCode = "RU");
    }
}

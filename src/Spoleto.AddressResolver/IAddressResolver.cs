namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Resolves and suggests addresses using search strings, coordinates, or IP.
    /// </summary>
    public interface IAddressResolver
    {
        /// <summary>
        /// Resolves the specified address string into a structured <see cref="AddressLocation"/>.
        /// </summary>
        /// <param name="searchAddressLocation">The input address string to resolve.</param>
        /// <param name="countryIsoCode">The ISO country code (default: "RU").</param>
        /// <returns>The resolved <see cref="AddressLocation"/> instance.</returns>
        AddressLocationData ResolveLocation(string searchAddressLocation, string countryIsoCode = "RU");

        /// <summary>
        /// Asynchronously resolves the specified address string into a structured <see cref="AddressLocation"/>.
        /// </summary>
        /// <param name="searchAddressLocation">The input address string to resolve.</param>
        /// <param name="countryIsoCode">The ISO country code (default: "RU").</param>
        /// <returns>A task returning the resolved <see cref="AddressLocation"/>.</returns>
        Task<AddressLocationData> ResolveLocationAsync(string searchAddressLocation, string countryIsoCode = "RU");

        /// <summary>
        /// Returns suggested address matches for a partial input string.
        /// </summary>
        /// <param name="searchAddressLocation">The partial address text to search for.</param>
        /// <param name="resultCount">Maximum number of results to return (default: 5).</param>
        /// <param name="cityFilter">Optional city name to limit address suggestions within a specific city.</param>
        /// <param name="countryIsoCode">The ISO country code (default: "RU").</param>
        /// <returns>A list of suggested <see cref="AddressLocation"/> instances.</returns>
        List<AddressLocation> SuggestLocations(string searchAddressLocation, int resultCount = 5, string? cityFilter = null, string countryIsoCode = "RU");


        /// <summary>
        /// Asynchronously returns suggested address matches for a partial input string.
        /// </summary>
        /// <param name="searchAddressLocation">The partial address text to search for.</param>
        /// <param name="resultCount">Maximum number of results to return (default: 5).</param>
        /// <param name="cityFilter">Optional city name to limit address suggestions within a specific city.</param>
        /// <param name="countryIsoCode">The ISO country code (default: "RU").</param>
        /// <returns>A task returning a list of suggested <see cref="AddressLocation"/> instances.</returns>
        Task<List<AddressLocation>> SuggestLocationsAsync(string searchAddressLocation, int resultCount = 5, string? cityFilter = null, string countryIsoCode = "RU");

        /// <summary>
        /// Finds cities by name or partial match.
        /// </summary>
        /// <param name="searchText">The city name or search fragment.</param>
        /// <param name="countryIsoCode">The ISO country code.</param>
        /// <param name="resultCount">Maximum number of results to return.</param>
        /// <returns>A list of matching <see cref="AddressLocation"/> city objects.</returns>
        List<AddressLocation> GetCities(string searchText, string countryIsoCode, int resultCount);

        /// <summary>
        /// Asynchronously finds cities by name or partial match.
        /// </summary>
        /// <param name="searchText">The city name or search fragment.</param>
        /// <param name="countryIsoCode">The ISO country code.</param>
        /// <param name="resultCount">Maximum number of results to return.</param>
        /// <returns>A task returning a list of matching <see cref="AddressLocation"/> city objects.</returns>
        Task<List<AddressLocation>> GetCitiesAsync(string searchText, string countryIsoCode, int resultCount);

        /// <summary>
        /// Resolves a geographic coordinate pair into a list of possible addresses.
        /// </summary>
        /// <param name="latitude">Latitude value.</param>
        /// <param name="longitude">Longitude value.</param>
        /// <returns>A list of <see cref="AddressLocation"/> matching the coordinates.</returns>
        List<AddressLocation> GetAddressByGeoCode(double latitude, double longitude);

        /// <summary>
        /// Asynchronously resolves a geographic coordinate pair into a list of possible addresses.
        /// </summary>
        /// <param name="latitude">Latitude value.</param>
        /// <param name="longitude">Longitude value.</param>
        /// <returns>A task returning a list of <see cref="AddressLocation"/> matching the coordinates.</returns>
        Task<List<AddressLocation>> GetAddressByGeoCodeAsync(double latitude, double longitude);

        /// <summary>
        /// Determines the city by the specified IP address.
        /// </summary>
        /// <param name="ip">The IP address to lookup.</param>
        /// <returns>The detected <see cref="AddressLocation"/> city.</returns>
        AddressLocation GetCityByIp(string ip);

        /// <summary>
        /// Asynchronously determines the city by the specified IP address.
        /// </summary>
        /// <param name="ip">The IP address to lookup.</param>
        /// <returns>A task returning the detected <see cref="AddressLocation"/> city.</returns>
        Task<AddressLocation> GetCityByIpAsync(string ip);
    }
}

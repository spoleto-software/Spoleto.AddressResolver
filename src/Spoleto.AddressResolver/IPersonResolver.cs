namespace Spoleto.AddressResolver
{
    /// <summary>
    /// Provides methods for resolving information about persons.
    /// </summary>
    public interface IPersonResolver
    {
        /// <summary>
        /// Resolves the specified person's fullName into a structured <see cref="PersonFullName"/>.
        /// </summary>
        /// <param name="originalFullName">The input fullName to resolve.</param>
        /// <returns>The resolved <see cref="PersonFullName"/> instance.</returns>
        PersonFullName ResolveFullName(string originalFullName);

        /// <summary>
        /// Resolves the specified person's fullName into a structured <see cref="PersonFullName"/>.
        /// </summary>
        /// <param name="originalFullName">The input fullName to resolve.</param>
        /// <returns>The resolved <see cref="PersonFullName"/> instance.</returns>
        Task<PersonFullName> ResolveFullNameAsync(string originalFullName);
    }
}

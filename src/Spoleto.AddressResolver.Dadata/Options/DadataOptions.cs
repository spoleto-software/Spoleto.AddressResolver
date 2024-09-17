namespace Spoleto.AddressResolver.Dadata
{
    /// <summary>
    /// The options for the <see cref="DadataAddressResolver"/>.
    /// </summary>
    public record DadataOptions
    {
        /// <summary>
        /// Gets or sets the Dadata token.
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Checks that all the settings within the options are configured properly.
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when <see cref="Token"/> is null.</exception>
        public void Validate()
        {
            if (String.IsNullOrEmpty(Token))
                throw new ArgumentNullException(nameof(Token));
        }
    }
}

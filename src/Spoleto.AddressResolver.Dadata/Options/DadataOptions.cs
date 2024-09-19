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
        /// Gets or sets the Dadata secret key.
        /// </summary>
        public string Secret { get; set; }

        /// <summary>
        /// Checks that all the settings within the options are configured properly.
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when <see cref="Token"/> or <see cref="Secret"/> are null.</exception>
        public void Validate()
        {
            if (String.IsNullOrEmpty(Token))
                throw new ArgumentNullException(nameof(Token));

            if (String.IsNullOrEmpty(Secret))
                throw new ArgumentNullException(nameof(Secret));
        }
    }
}

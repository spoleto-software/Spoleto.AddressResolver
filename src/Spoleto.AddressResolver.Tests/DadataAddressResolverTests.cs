namespace Spoleto.AddressResolver.Tests
{
    public class DadataAddressResolverTests
    {
        private IAddressResolver _addressResolver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var options = ConfigurationHelper.GetDadataOptions();
            _addressResolver = new Dadata.DadataAddressResolver(options);
        }

        [Test]
        public async Task ResolveLocationTest()
        {
            // Arrange
            var address = "Иваново, Ленина, 5";

            // Act
            var location = await _addressResolver.ResolveLocationAsync(address);

            // Assert
            Assert.That(location, Is.Not.Null);
        }

        [Test]
        public async Task SuggestLocationsTest()
        {
            // Arrange
            var address = "Иваново, Ленина, 5";

            // Act
            var locations = await _addressResolver.SuggestLocationsAsync(address);

            // Assert
            Assert.That(locations, Is.Not.Null);
        }
    }
}
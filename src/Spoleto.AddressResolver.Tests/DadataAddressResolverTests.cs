namespace Spoleto.AddressResolver.Tests
{
    public class DadataAddressResolverTests
    {
        private IBusinessDataResolver _businessDataResolver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var options = ConfigurationHelper.GetDadataOptions();
            _businessDataResolver = new Dadata.DadataAddressResolver(options);
        }

        [Test]
        public async Task ResolveLocationTest()
        {
            // Arrange
            var address = "Иваново, Ленина, 5";

            // Act
            var location = await _businessDataResolver.ResolveLocationAsync(address);

            // Assert
            Assert.That(location, Is.Not.Null);
        }

        [Test]
        public async Task SuggestLocationsTest()
        {
            // Arrange
            var address = "Иваново, Ленина, 5";

            // Act
            var locations = await _businessDataResolver.SuggestLocationsAsync(address, cityFilter: "Иваново");

            // Assert
            Assert.That(locations, Is.Not.Null);
        }

        [Test]
        public async Task GetCitiesTest()
        {
            // Arrange
            var address = "Иваново";

            // Act
            var locations = await _businessDataResolver.GetCitiesAsync(address, "RU", 5);

            // Assert
            Assert.That(locations, Is.Not.Null);
        }

        [Test]
        public async Task GetAddressByGeoCodeTest()
        {
            // Arrange
            var lat = 62.0397;
            var lon = 129.7422;

            // Act
            var locations = await _businessDataResolver.GetAddressByGeoCodeAsync(lat, lon);

            // Assert
            Assert.That(locations, Is.Not.Null);
        }

        [Test]
        public async Task GetCityByIpTest()
        {
            // Arrange
            var ip = "83.220.236.105";

            // Act
            var city = await _businessDataResolver.GetCityByIpAsync(ip);

            // Assert
            Assert.That(city, Is.Not.Null);
        }

        [Test]
        public async Task GetFirmTest()
        {
            // Arrange
            var inn = "7709359307";

            // Act
            var firm = await _businessDataResolver.GetFirmAsync(inn);

            // Assert
            Assert.That(firm, Is.Not.Null);
        }

        [Test]
        public async Task ResolvePersonFullNameTest()
        {
            // Arrange
            var fullName = "Срегей владимерович иванов";

            // Act
            var person = await _businessDataResolver.ResolveFullNameAsync(fullName);

            // Assert
            Assert.That(person, Is.Not.Null);
        }
    }
}
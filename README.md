# Spoleto.AddressResolver

**Spoleto.AddressResolver** is a library for parsing textual representations of addresses. It is designed to break down an address into its components, such as city, street, house number, fias, kladr and postal code. This simplifies the processing and validation of address information in various applications, such as delivery systems, CRM, and geocoding.

## Features

- **Accurate Recognition**: Analyzes addresses in different formats, ensuring high accuracy in extracting components.
- **Support for Various Address Formats**: Capable of handling addresses in different standards and layouts.
- **Extensibility**: Easily add new rules and patterns to handle specific address formats via new resolvers.
- **Lightweight**: A low-resource library that can be integrated into projects with various requirements.

## Installation

To install the library, use the following package manager, for example, NuGet:

```bash
Install-Package Spoleto.AddressResolver
```

## Parsers

The parsers come as pre-configured NuGet packages:

- **[Spoleto.AddressResolver.Dadata](https://www.nuget.org/packages/Spoleto.AddressResolver.Dadata/)**: Parser via Dadata https://dadata.ru/; 

## Usage
### Creating an address resolver


```csharp
var options = new DadataOptions { Token = "your-dadata-token" };
var addressResolver = new DadataAddressResolver(options);
```

### Resolve the string representation of the address:

```csharp
var address = await addressResolver.ResolveLocationAsync("Москва, Череповецкая 14");

// or sync version:
var address = addressResolver.ResolveLocation("Москва, Череповецкая 14");
```

### Suggest the string representation of the address:

```csharp
var suggestedAddresses = await addressResolver.SuggestLocationsAsync("Москва, Тверская-Ямская");

// or sync version:
var suggestedAddresses = addressResolver.SuggestLocations("Москва, Тверская-Ямская");
```
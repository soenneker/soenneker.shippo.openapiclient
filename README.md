[![](https://img.shields.io/nuget/v/soenneker.shippo.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.shippo.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.shippo.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.shippo.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.shippo.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.shippo.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.shippo.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.shippo.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Shippo.OpenApiClient

Generated Shippo API client covering shipments, rates, labels, tracking, addresses, parcels, customs, manifests, pickups, refunds, orders, and webhooks.

## Installation

```bash
dotnet add package Soenneker.Shippo.OpenApiClient
```

For application registration and configuration-based authentication, use `Soenneker.Shippo.OpenApiClientUtil`. Instantiate this package directly when you need to supply your own Kiota request adapter.

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Shippo.OpenApiClient;

var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://api.goshippo.com/")
};
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("ShippoToken", shippoToken);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient)
{
    BaseUrl = httpClient.BaseAddress.ToString().TrimEnd('/')
};

var shippo = new ShippoOpenApiClient(adapter);
var shipments = await shippo.Shipments.GetAsync(
    cancellationToken: cancellationToken);
```

The generated client exposes request builders for each Shippo resource. Collection responses are paginated; use the returned pagination fields when requesting subsequent pages.

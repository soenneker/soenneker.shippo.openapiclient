using Soenneker.Tests.HostedUnit;

namespace Soenneker.Shippo.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ShippoOpenApiClientTests : HostedUnitTest
{
    public ShippoOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}

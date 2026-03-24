using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Shippo.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class ShippoOpenApiClientTests : FixturedUnitTest
{
    public ShippoOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}

using Soenneker.Tests.HostedUnit;

namespace Soenneker.Jira.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class JiraOpenApiClientTests : HostedUnitTest
{
    public JiraOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}

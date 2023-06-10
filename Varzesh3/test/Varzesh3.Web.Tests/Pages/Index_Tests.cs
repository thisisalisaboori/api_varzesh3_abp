using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Varzesh3.Pages;

public class Index_Tests : Varzesh3WebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}

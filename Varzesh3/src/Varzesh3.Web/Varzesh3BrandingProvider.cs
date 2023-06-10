using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Varzesh3.Web;

[Dependency(ReplaceServices = true)]
public class Varzesh3BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Varzesh3";
}

using Volo.Abp.Modularity;

namespace Varzesh3;

[DependsOn(
    typeof(Varzesh3ApplicationModule),
    typeof(Varzesh3DomainTestModule)
    )]
public class Varzesh3ApplicationTestModule : AbpModule
{

}

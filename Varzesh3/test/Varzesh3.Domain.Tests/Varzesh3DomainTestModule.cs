using Varzesh3.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Varzesh3;

[DependsOn(
    typeof(Varzesh3EntityFrameworkCoreTestModule)
    )]
public class Varzesh3DomainTestModule : AbpModule
{

}

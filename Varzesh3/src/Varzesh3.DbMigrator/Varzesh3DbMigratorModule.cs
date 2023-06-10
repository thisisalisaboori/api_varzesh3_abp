using Varzesh3.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Varzesh3.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Varzesh3EntityFrameworkCoreModule),
    typeof(Varzesh3ApplicationContractsModule)
    )]
public class Varzesh3DbMigratorModule : AbpModule
{

}

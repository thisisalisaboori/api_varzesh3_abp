using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Varzesh3.Data;

/* This is used if database provider does't define
 * IVarzesh3DbSchemaMigrator implementation.
 */
public class NullVarzesh3DbSchemaMigrator : IVarzesh3DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

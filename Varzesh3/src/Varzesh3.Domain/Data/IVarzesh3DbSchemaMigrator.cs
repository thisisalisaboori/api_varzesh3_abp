using System.Threading.Tasks;

namespace Varzesh3.Data;

public interface IVarzesh3DbSchemaMigrator
{
    Task MigrateAsync();
}

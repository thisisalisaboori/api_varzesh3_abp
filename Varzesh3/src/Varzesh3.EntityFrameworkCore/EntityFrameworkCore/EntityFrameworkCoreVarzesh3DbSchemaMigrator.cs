using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Varzesh3.Data;
using Volo.Abp.DependencyInjection;

namespace Varzesh3.EntityFrameworkCore;

public class EntityFrameworkCoreVarzesh3DbSchemaMigrator
    : IVarzesh3DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreVarzesh3DbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the Varzesh3DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<Varzesh3DbContext>()
            .Database
            .MigrateAsync();
    }
}

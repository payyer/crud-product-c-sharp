using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductDemo2.Data;
using Volo.Abp.DependencyInjection;

namespace ProductDemo2.EntityFrameworkCore;

public class EntityFrameworkCoreProductDemo2DbSchemaMigrator
    : IProductDemo2DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreProductDemo2DbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ProductDemo2DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ProductDemo2DbContext>()
            .Database
            .MigrateAsync();
    }
}

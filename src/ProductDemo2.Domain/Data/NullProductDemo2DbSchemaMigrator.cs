using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ProductDemo2.Data;

/* This is used if database provider does't define
 * IProductDemo2DbSchemaMigrator implementation.
 */
public class NullProductDemo2DbSchemaMigrator : IProductDemo2DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

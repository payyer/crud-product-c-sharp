using System.Threading.Tasks;

namespace ProductDemo2.Data;

public interface IProductDemo2DbSchemaMigrator
{
    Task MigrateAsync();
}

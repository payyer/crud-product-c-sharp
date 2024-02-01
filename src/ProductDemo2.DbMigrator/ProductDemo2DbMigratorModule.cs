using ProductDemo2.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ProductDemo2.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProductDemo2EntityFrameworkCoreModule),
    typeof(ProductDemo2ApplicationContractsModule)
    )]
public class ProductDemo2DbMigratorModule : AbpModule
{
}

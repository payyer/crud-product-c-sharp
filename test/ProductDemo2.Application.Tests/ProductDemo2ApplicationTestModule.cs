using Volo.Abp.Modularity;

namespace ProductDemo2;

[DependsOn(
    typeof(ProductDemo2ApplicationModule),
    typeof(ProductDemo2DomainTestModule)
)]
public class ProductDemo2ApplicationTestModule : AbpModule
{

}

using Volo.Abp.Modularity;

namespace ProductDemo2;

[DependsOn(
    typeof(ProductDemo2DomainModule),
    typeof(ProductDemo2TestBaseModule)
)]
public class ProductDemo2DomainTestModule : AbpModule
{

}

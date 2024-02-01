using Volo.Abp.Modularity;

namespace ProductDemo2;

public abstract class ProductDemo2ApplicationTestBase<TStartupModule> : ProductDemo2TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

using Volo.Abp.Modularity;

namespace ProductDemo2;

/* Inherit from this class for your domain layer tests. */
public abstract class ProductDemo2DomainTestBase<TStartupModule> : ProductDemo2TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

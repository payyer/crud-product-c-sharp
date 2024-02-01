using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ProductDemo2.Blazor;

[Dependency(ReplaceServices = true)]
public class ProductDemo2BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ProductDemo2";
}

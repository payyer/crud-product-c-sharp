using ProductDemo2.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ProductDemo2.Blazor;

public abstract class ProductDemo2ComponentBase : AbpComponentBase
{
    protected ProductDemo2ComponentBase()
    {
        LocalizationResource = typeof(ProductDemo2Resource);
    }
}

using ProductDemo2.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ProductDemo2.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ProductDemo2Controller : AbpControllerBase
{
    protected ProductDemo2Controller()
    {
        LocalizationResource = typeof(ProductDemo2Resource);
    }
}

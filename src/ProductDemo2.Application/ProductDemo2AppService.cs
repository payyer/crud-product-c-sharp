using System;
using System.Collections.Generic;
using System.Text;
using ProductDemo2.Localization;
using Volo.Abp.Application.Services;

namespace ProductDemo2;

/* Inherit your application services from this class.
 */
public abstract class ProductDemo2AppService : ApplicationService
{
    protected ProductDemo2AppService()
    {
        LocalizationResource = typeof(ProductDemo2Resource);
    }
}

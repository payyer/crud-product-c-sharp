using ProductDemo2.Samples;
using Xunit;

namespace ProductDemo2.EntityFrameworkCore.Applications;

[Collection(ProductDemo2TestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ProductDemo2EntityFrameworkCoreTestModule>
{

}

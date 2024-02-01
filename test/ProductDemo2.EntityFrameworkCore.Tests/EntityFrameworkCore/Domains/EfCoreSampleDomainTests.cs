using ProductDemo2.Samples;
using Xunit;

namespace ProductDemo2.EntityFrameworkCore.Domains;

[Collection(ProductDemo2TestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ProductDemo2EntityFrameworkCoreTestModule>
{

}

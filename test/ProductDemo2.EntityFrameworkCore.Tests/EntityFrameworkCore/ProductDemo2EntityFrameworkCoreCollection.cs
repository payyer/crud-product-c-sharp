using Xunit;

namespace ProductDemo2.EntityFrameworkCore;

[CollectionDefinition(ProductDemo2TestConsts.CollectionDefinitionName)]
public class ProductDemo2EntityFrameworkCoreCollection : ICollectionFixture<ProductDemo2EntityFrameworkCoreFixture>
{

}

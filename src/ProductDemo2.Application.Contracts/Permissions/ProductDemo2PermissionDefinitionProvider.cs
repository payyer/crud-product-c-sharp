using ProductDemo2.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ProductDemo2.Permissions;

public class ProductDemo2PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ProductDemo2Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ProductDemo2Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ProductDemo2Resource>(name);
    }
}

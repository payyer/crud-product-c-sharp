using Volo.Abp.Settings;

namespace ProductDemo2.Settings;

public class ProductDemo2SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ProductDemo2Settings.MySetting1));
    }
}

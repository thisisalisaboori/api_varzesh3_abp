using Volo.Abp.Settings;

namespace Varzesh3.Settings;

public class Varzesh3SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(Varzesh3Settings.MySetting1));
    }
}

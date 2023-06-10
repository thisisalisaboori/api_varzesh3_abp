using Varzesh3.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Varzesh3.Permissions;

public class Varzesh3PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Varzesh3Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(Varzesh3Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Varzesh3Resource>(name);
    }
}

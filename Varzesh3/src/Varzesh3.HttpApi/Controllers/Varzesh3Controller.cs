using Varzesh3.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Varzesh3.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Varzesh3Controller : AbpControllerBase
{
    protected Varzesh3Controller()
    {
        LocalizationResource = typeof(Varzesh3Resource);
    }
}

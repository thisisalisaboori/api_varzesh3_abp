using Varzesh3.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Varzesh3.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class Varzesh3PageModel : AbpPageModel
{
    protected Varzesh3PageModel()
    {
        LocalizationResourceType = typeof(Varzesh3Resource);
    }
}

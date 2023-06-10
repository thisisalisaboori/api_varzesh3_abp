using System;
using System.Collections.Generic;
using System.Text;
using Varzesh3.Localization;
using Volo.Abp.Application.Services;

namespace Varzesh3;

/* Inherit your application services from this class.
 */
public abstract class Varzesh3AppService : ApplicationService
{
    protected Varzesh3AppService()
    {
        LocalizationResource = typeof(Varzesh3Resource);
    }
}

using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Varzesh3;

public class Varzesh3WebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<Varzesh3WebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}

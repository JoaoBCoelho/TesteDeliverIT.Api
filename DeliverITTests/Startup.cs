using Autofac.Extensions.DependencyInjection;
using DeliverITTests.Dependencies;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using TesteDeliverIT.BLL;
using TesteDeliverIT.BLL.Interfaces;
using TesteDeliverIT.DAL.DAO.Interfaces;
using Xunit.DependencyInjection;
using Xunit.DependencyInjection.Demystifier;
using Xunit.DependencyInjection.Logging;

namespace DeliverITTests
{
    public class Startup
    {
        public void ConfigureHost(IHostBuilder hostBuilder) =>
            hostBuilder.UseServiceProviderFactory(new AutofacServiceProviderFactory());

        public void ConfigureServices2(IServiceCollection services) =>
        services.AddLogging()
            .AddScoped<IContaDAO, ContaDAOMock>()
            .AddScoped<IContaAtrasoDAO, ContaAtrasoDAOMock>()
            .AddScoped<IContaBLL, ContaBLL>()
            .AddSingleton<IAsyncExceptionFilter, DemystifyExceptionFilter>();

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IContaDAO, ContaDAOMock>();
            services.AddTransient<IContaAtrasoDAO, ContaAtrasoDAOMock>();

            services.AddTransient<IContaBLL, ContaBLL>();
        }

        public void Configure(ILoggerFactory loggerFactory, ITestOutputHelperAccessor accessor) =>
            loggerFactory.AddProvider(new XunitTestOutputLoggerProvider(accessor));
    }
}

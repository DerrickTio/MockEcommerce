using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MockEcommerce.Configuration;

namespace MockEcommerce.Web.Host.Startup
{
    [DependsOn(
       typeof(MockEcommerceWebCoreModule))]
    public class MockEcommerceWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MockEcommerceWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MockEcommerceWebHostModule).GetAssembly());
        }
    }
}

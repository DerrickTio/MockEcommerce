using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MockEcommerce.EntityFrameworkCore;
using MockEcommerce.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MockEcommerce.Web.Tests
{
    [DependsOn(
        typeof(MockEcommerceWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MockEcommerceWebTestModule : AbpModule
    {
        public MockEcommerceWebTestModule(MockEcommerceEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MockEcommerceWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MockEcommerceWebMvcModule).Assembly);
        }
    }
}
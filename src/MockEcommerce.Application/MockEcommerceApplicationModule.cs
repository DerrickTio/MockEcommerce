﻿using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MockEcommerce.Authorization;

namespace MockEcommerce
{
    [DependsOn(
        typeof(MockEcommerceCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MockEcommerceApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MockEcommerceAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MockEcommerceApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MockEcommerce.Controllers
{
    public abstract class MockEcommerceControllerBase: AbpController
    {
        protected MockEcommerceControllerBase()
        {
            LocalizationSourceName = MockEcommerceConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

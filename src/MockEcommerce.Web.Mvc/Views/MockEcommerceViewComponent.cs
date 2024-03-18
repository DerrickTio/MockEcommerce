using Abp.AspNetCore.Mvc.ViewComponents;

namespace MockEcommerce.Web.Views
{
    public abstract class MockEcommerceViewComponent : AbpViewComponent
    {
        protected MockEcommerceViewComponent()
        {
            LocalizationSourceName = MockEcommerceConsts.LocalizationSourceName;
        }
    }
}

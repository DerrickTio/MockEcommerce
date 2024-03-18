using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace MockEcommerce.Web.Views
{
    public abstract class MockEcommerceRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MockEcommerceRazorPage()
        {
            LocalizationSourceName = MockEcommerceConsts.LocalizationSourceName;
        }
    }
}

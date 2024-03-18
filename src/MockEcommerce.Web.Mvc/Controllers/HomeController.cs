using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MockEcommerce.Controllers;

namespace MockEcommerce.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MockEcommerceControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

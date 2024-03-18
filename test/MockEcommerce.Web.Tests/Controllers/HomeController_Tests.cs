using System.Threading.Tasks;
using MockEcommerce.Models.TokenAuth;
using MockEcommerce.Web.Controllers;
using Shouldly;
using Xunit;

namespace MockEcommerce.Web.Tests.Controllers
{
    public class HomeController_Tests: MockEcommerceWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
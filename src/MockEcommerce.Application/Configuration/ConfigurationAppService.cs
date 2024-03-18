using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MockEcommerce.Configuration.Dto;

namespace MockEcommerce.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MockEcommerceAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

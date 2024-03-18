using System.Threading.Tasks;
using MockEcommerce.Configuration.Dto;

namespace MockEcommerce.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

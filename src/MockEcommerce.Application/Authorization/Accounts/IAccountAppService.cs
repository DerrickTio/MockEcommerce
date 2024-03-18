using System.Threading.Tasks;
using Abp.Application.Services;
using MockEcommerce.Authorization.Accounts.Dto;

namespace MockEcommerce.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

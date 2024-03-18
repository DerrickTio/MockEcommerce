using System.Threading.Tasks;
using Abp.Application.Services;
using MockEcommerce.Sessions.Dto;

namespace MockEcommerce.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

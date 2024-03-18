using Abp.Application.Services;
using MockEcommerce.MultiTenancy.Dto;

namespace MockEcommerce.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


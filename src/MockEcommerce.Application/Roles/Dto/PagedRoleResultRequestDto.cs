using Abp.Application.Services.Dto;

namespace MockEcommerce.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}


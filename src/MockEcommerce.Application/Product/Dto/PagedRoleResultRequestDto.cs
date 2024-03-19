using Abp.Application.Services.Dto;

namespace MockEcommerce.Product.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}


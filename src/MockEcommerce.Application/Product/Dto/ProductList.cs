using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System;

namespace MockEcommerce.Product.Dto
{
    public class ProductList : EntityDto, IHasCreationTime
    {
        public string Name { get; set; }
        public DateTime CreationTime { get; set; }

    }
}

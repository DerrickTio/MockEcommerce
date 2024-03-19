using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockEcommerce.Product.Dto
{
    public class OrderDto : EntityDto, IHasCreationTime
    {
        public int ProductId { get; set; }
        public string OrderNumber { get; set; }
        public int Quantity { get; set; }
        public decimal OrderAmount { get; set; }
        public DateTime CreationTime { get; set; }

    }
}

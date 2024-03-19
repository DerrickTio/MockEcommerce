using System;

namespace MockEcommerce.Web.Models.Product
{
    public class OrerViewModel
    {
        public Guid OrderId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal OrderAmount { get; set; }

    }
}

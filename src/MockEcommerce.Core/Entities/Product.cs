using Abp.Domain.Entities;

namespace MockEcommerce.Entities
{
    public class Product : Entity<int>
    {
        public string Name { get; set; }
    }
}

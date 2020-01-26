using Margo.Domain.Entities.BaseModels;

namespace Margo.Domain.Entities.Catalog
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}

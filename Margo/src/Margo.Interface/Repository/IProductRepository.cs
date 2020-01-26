using Margo.Domain.Entities.Catalog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Margo.Interface.Repository
{
    public interface IProductRepository
    {
        bool AddProduct(Product product);
        Product GetProduct(int id);
        bool RemoveProduct(int id);
        ICollection<Product> GetAllProducts();
    }
}

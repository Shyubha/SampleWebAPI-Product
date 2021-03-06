using SampleWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SampleWebAPI.Services
{
    public interface IProductServices
    {
        IEnumerable<Product> GetAllProducts();
        int AddProduct(Product prod);
        int ModifyProduct(Product prod);
        int DeleteProduct(int id);
    }
}

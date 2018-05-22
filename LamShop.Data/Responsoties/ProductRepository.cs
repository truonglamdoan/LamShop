using LamShop.Data.Infrastructure;
using LamShop.Model.Models;

namespace LamShop.Data.Responsoties
{
    public interface IProductRepository
    {
    }

    public class ProductRepository : RespositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
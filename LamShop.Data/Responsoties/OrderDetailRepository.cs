using LamShop.Data.Infrastructure;
using LamShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamShop.Data.Responsoties
{
    public interface IOrderDetailRepository
    {
    }
    public class OrderdetailRepository : RespositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderdetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}

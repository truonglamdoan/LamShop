using LamShop.Data.Infrastructure;
using LamShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamShop.Data.Responsoties
{
    public interface IPageRepository
    {
    }

    public class PageRepository : RespositoryBase<Page>, IPageRepository
    {
        public PageRepository (IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}

using LamShop.Data.Infrastructure;
using LamShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamShop.Data.Responsoties
{
    public interface IPostRepository
    {
    }
    public class PostRepository: RespositoryBase<Post>,IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) :base(dbFactory)
        {

        }
    }
}

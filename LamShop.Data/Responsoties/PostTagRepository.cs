using LamShop.Data.Infrastructure;
using LamShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamShop.Data.Responsoties
{
    public interface IPostTagRepository
    {
    }
    public class PostTagRepository: RespositoryBase<PostTag>, IPostTagRepository
    {
        public PostTagRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}

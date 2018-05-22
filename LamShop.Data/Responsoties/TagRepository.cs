using LamShop.Data.Infrastructure;
using LamShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamShop.Data.Responsoties
{
    public interface ITagRepository
    {
    }

    public class TagRepository:RespositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) :base(dbFactory)
        {

        }
    }
}

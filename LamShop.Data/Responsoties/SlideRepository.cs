using LamShop.Data.Infrastructure;
using LamShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamShop.Data.Responsoties
{
    public interface ISlideRepository
    {
    }
    public class SlideRepository : RespositoryBase<Slide>, ISlideRepository
    {
        public SlideRepository(IDbFactory dbFactory) :base(dbFactory)
        {

        }
    }
}

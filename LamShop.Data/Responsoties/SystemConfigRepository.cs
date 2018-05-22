using LamShop.Data.Infrastructure;
using LamShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamShop.Data.Responsoties
{
    public interface ISystemConfigRepository
    {
    }

    public class SystemConfigRepository: RespositoryBase<SystemConfig>, ISystemConfigRepository
    {
        public SystemConfigRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}

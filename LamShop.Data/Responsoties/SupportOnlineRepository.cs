﻿using LamShop.Data.Infrastructure;
using LamShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamShop.Data.Responsoties
{
    public interface ISupportOnlineRepository
    {
    }
    public class SupportOnlineRepository: RespositoryBase<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDbFactory dbFactory) :base(dbFactory)
        {

        }
    }
}

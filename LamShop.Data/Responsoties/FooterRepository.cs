﻿using LamShop.Data.Infrastructure;
using LamShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamShop.Data.Responsoties
{
    public interface IFooterRepository
    {

    }
        public class FooterRepository : RespositoryBase<Footer>, IFooterRepository
        {
            public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
            {

            }
        }
}
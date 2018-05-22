using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamShop.Data.Infrastructure
{
    class DbFactory : Disposable, IDbFactory
    {
        LamShopDbContext dbContext;
        public LamShopDbContext Init()
        {
            return dbContext ?? (dbContext = new LamShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}

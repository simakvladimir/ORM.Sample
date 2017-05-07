using ORM.Sample.Core.Db;
using ORM.Sample.Core.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Sample.EF
{
    public class EfProvider : IOrmProvider
    {
        private IDbProvider _dbProvider;
        public EfProvider(IDbProvider provider)
        {
            _dbProvider = provider;
        }

        public IOrmSessionFactory BuildSessionFactory()
        {
            return new EfSessionFactory(_dbProvider.Connection);
        }

        public void Configure()
        {
        }
    }
}

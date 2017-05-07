using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORM.Sample.Core.Db;
using ORM.Sample.Core.Orm;

namespace ORM.Sample.Core
{
    public class DefaultHost : IHost
    {
        private IDbProvider _dbProvider;
        private IOrmProvider _ormProvider;

        public DefaultHost(
            IDbProvider dbProvider,
            IOrmProvider ormProvider)
        {
            _dbProvider = dbProvider;
            _ormProvider = ormProvider;
        }
        public void Initialize()
        {
            _dbProvider.Configure();
            _ormProvider.Configure();
        }


    }
}

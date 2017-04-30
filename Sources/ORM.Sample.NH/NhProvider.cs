using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.AdoNet;
using NHibernate.Cfg;
using NHibernate.Context;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Tool.hbm2ddl;
using ORM.Sample.Core.Db;
using ORM.Sample.Core.Orm;

namespace ORM.Sample.NH
{
    
    public class NhProvider : IOrmProvider
    {
        private Configuration _config;

        #region Import

        public IDbProvider DbProvider { get; set; }

        #endregion

        public void Configure()
        {
            ConfigureNH();
            BuildSchema();
        }

        public IOrmSessionFactory BuildSessionFactory()
        {
            return new NhSessionFactory(_config.BuildSessionFactory());
        }

        private void ConfigureNH()
        {
            // order is important. 1 - configure (read nhibernate.cfg) 2 - add assembly
            _config = new Configuration()
                .Configure()
                .AddAssembly("ORM.Sample.NH");
        }

        private void BuildSchema()
        {
            if (_config == null) return;

            // update schema
            new SchemaExport(_config).Execute(true, true, false);
        }
    }
    
}

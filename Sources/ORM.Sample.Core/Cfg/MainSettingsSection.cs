using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.ComponentModel;

namespace ORM.Sample.Core.Cfg
{
    public class MainSettingsSection : ConfigurationSection
    {
        //private readonly ConfigurationProperty _dbType = new ConfigurationProperty("dbType", typeof(Type), null);
        //private readonly ConfigurationProperty _ormType = new ConfigurationProperty("ormType", typeof(Type), null);

        [ConfigurationProperty("connection", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string ConnectionString
        {
            get { return (string) base["connection"]; }
        }

        [ConfigurationProperty("db")]
        [TypeConverter(typeof(TypeNameConverter))]
        public Type DbProviderType
        {
            get { return (Type) base["db"]; }
        }

        [ConfigurationProperty("orm")]
        [TypeConverter(typeof(TypeNameConverter))]
        public Type OrmProviderType
        {
            get { return (Type) base["orm"]; }
        }

        private readonly ConfigurationProperty _ormType = new ConfigurationProperty("ormType", typeof(Type), null);
    }
}

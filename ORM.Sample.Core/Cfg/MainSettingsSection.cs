using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ORM.Sample.Core.Cfg
{
    public class MainSettingsSection : ConfigurationSection
    {
        [ConfigurationProperty("connection", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string ConnectionString
        {
            get { return (string)base["connection"]; }
        }

        [ConfigurationProperty("type", DefaultValue = "", IsKey = false, IsRequired = true)]
        public string DbProvider
        {
            get { return (string)base["type"]; }
        }
    }
}

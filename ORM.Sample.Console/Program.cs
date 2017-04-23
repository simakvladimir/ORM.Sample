using ORM.Sample.Domain.Entities;
using ORM.Sample.NH;
using System;
using System.Configuration;
using ORM.Sample.Core.Cfg;

namespace ORM.Sample.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // connection
            MainSettingsSection section = (MainSettingsSection)ConfigurationManager.GetSection("main");
            if (section != null)
            {
                System.Console.WriteLine(string.Format("Connection: {0}", section.ConnectionString));
                System.Console.WriteLine(string.Format("Provider: {0}", section.DbProvider));
            }

            // NH or EF
            var ormConf = new NhConfigurator();
            ormConf.Configure();

            // Factory
            var factory = ormConf.BuildSessionFactory();
            
            User user = new User()
            {
                UserName = "Name"
            };

            // session
            var session = factory.GetNewSession();
            session.Save(user);
            session.Close();

            factory.Close();

            System.Console.ReadKey();
        }
    }
}

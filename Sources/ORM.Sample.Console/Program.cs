using ORM.Sample.Domain.Entities;
using ORM.Sample.NH;
using System;
using System.Configuration;
using Autofac;
using ORM.Sample.Core.Cfg;
using ORM.Sample.Core;
using ORM.Sample.Core.Orm;

namespace ORM.Sample.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = Starter.CreateHostContainer();
            var host = container.Resolve<IHost>();
             host.Initialize();

            // Orm provider
            var ormProvider = container.Resolve<IOrmProvider>();

            // Factory
            var factory = ormProvider.BuildSessionFactory();
            
            User user = new User()
            {
                UserName = "Name"
            };

            // session
            var session = factory.GetNewSession();
            session.Save(user);
            session.Close();

            factory.Close();

            System.Console.WriteLine("Press any key...");
            System.Console.ReadKey();
        }
    }
}

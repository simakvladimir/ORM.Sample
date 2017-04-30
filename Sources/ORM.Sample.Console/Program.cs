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

            // Db provider
            

            // Orm provider
            var ormProvider = container.Resolve<IOrmProvider>();
            ormProvider.Configure();

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

            System.Console.ReadKey();
        }
    }
}

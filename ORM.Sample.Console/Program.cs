using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORM.Sample.Domain.Entities;
using ORM.Sample.Infrastructure;
using ORM.Sample.NH;

namespace ORM.Sample.Console
{
    class Program
    {
        static void Main(string[] args)
        {
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

using Autofac;
using ORM.Sample.Core.Cfg;
using System.Configuration;
using ORM.Sample.Core.Db;
using ORM.Sample.Core.Orm;

namespace ORM.Sample.Core
{
    public static class Starter
    {
        public static IContainer CreateHostContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DefaultHost>().As<IHost>();
        
            // read settings
            MainSettingsSection section = (MainSettingsSection)ConfigurationManager.GetSection("main");
            if (section != null)
            {
                builder.RegisterType(section.DbProviderType)
                    .As<IDbProvider>()
                    .WithProperty("Connection", section.ConnectionString)
                    .SingleInstance();
                builder.RegisterType(section.OrmProviderType).As<IOrmProvider>().SingleInstance();
            }
            
            return builder.Build();
        }
    }
}

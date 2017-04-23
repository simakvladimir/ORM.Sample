namespace ORM.Sample.Core.Orm
{
    public interface IOrmConfigurator
    {
        void Configure();
        IOrmSessionFactory BuildSessionFactory();
    }
}

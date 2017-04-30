namespace ORM.Sample.Core.Orm
{
    public interface IOrmProvider
    {
        void Configure();
        IOrmSessionFactory BuildSessionFactory();
    }
}

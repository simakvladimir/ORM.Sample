using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using ORM.Sample.Core.Orm;

namespace ORM.Sample.NH
{
    public class NhSessionFactory : IOrmSessionFactory
    {
        private ISessionFactory _factory;
        public NhSessionFactory(ISessionFactory factory)
        {
            _factory = factory;
        }
        public IOrmSession GetNewSession()
        {
            return new NhSession(_factory.OpenSession());
        }

        public void Close()
        {
            if (_factory != null)
                _factory.Close();
        }
    }
}

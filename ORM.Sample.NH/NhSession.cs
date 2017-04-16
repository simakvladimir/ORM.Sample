using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using ORM.Sample.Infrastructure;

namespace ORM.Sample.NH
{
    public class NhSession : IOrmSession
    {
        private ISession _session;
        public NhSession(ISession session)
        {
            _session = session;
        }

        public void Close()
        {
            if (_session != null)
                _session.Close();
        }

        public void Save(object obj)
        {
            if (_session != null)
                _session.Save(obj);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORM.Sample.Core.Orm;
using ORM.Sample.EF.Context;

namespace ORM.Sample.EF
{
    public class EfSessionFactory : IOrmSessionFactory
    {
        private DbContext _context;

        public EfSessionFactory(string connection)
        {
            _context = new DomainContext(connection);
        }

        public string Connection { get; set; }

        public void Close()
        {
            _context.Dispose();
        }

        public IOrmSession GetNewSession()
        {
            return new EfSession(_context);
        }
    }
}

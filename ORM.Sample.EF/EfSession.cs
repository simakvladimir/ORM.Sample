using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORM.Sample.Core.Orm;

namespace ORM.Sample.EF
{
    public class EfSession : IOrmSession
    {
        private DbContext _context;

        public EfSession(DbContext context)
        {
            _context = context;
        }

        public void Close()
        {
        }

        public void Save(object obj)
        {
            if (_context == null || obj == null)
                return;

            var type = obj.GetType();
            var entities = _context.Set(type);
            if (entities == null)
                return;

            entities.Add(obj);

            _context.SaveChanges();
        }
    }
}

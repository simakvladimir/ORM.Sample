using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Sample.Core.Db
{
    public abstract class DbProvider : IDbProvider
    {
        public virtual string Connection { get; set; }
    }
}

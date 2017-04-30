using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Sample.Core.Orm
{
    public interface IOrmSessionFactory
    {
        void Close();
        IOrmSession GetNewSession();
    }
}

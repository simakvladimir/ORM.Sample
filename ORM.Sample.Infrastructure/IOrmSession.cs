using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Sample.Infrastructure
{
    public interface IOrmSession
    {
        void Close();
        void Save(object obj);
    }
}

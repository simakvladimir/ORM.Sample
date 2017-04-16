using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Sample.Infrastructure
{
    public interface IOrmConfigurator
    {
        void Configure();
        IOrmSessionFactory BuildSessionFactory();
    }
}

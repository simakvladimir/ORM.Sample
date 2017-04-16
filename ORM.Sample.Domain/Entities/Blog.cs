using System.Collections.Generic;
using System.Drawing;

namespace ORM.Sample.Domain.Entities
{
    public class Blog
    {
        public Blog()
        {
            Posts = new List<Post>();
        }

        public virtual int BlogId { get; protected set; }
        public virtual Image Picture { get; set; }
        public virtual long PostCount { get; protected set; }
        public virtual User Owner { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Post> Posts { get; protected set; }
    }
}
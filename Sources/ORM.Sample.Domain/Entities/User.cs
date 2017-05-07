using System;
using System.Collections.Generic;

namespace ORM.Sample.Domain.Entities
{
    public class User
    {
        public User()
        {
            //Blogs = new HashSet<Blog>();
            //Details = new UserDetail();
        }

        public virtual int UserId { get; protected set; }

        public virtual string UserName { get; set; }

        /*
        public virtual UserDetail Details { get; set; }

        public virtual DateTime? Bithdate { get; set; }

        public virtual ISet<Blog> Blogs { get; protected set; }
        */
    }
}

using System;
using System.Collections.Generic;

namespace ORM.Sample.Domain.Entities
{
    public class Post
    {
        public Post()
        {
            Tags = new HashSet<string>();
            Attachments = new HashSet<Attachment>();
            Comments = new List<Comment>();
        }

        public virtual int PostId { get; protected set; }
        public virtual Blog Blog { get; set; }
        public virtual DateTime Timestamp { get; set; }
        public virtual string Title { get; set; }
        public virtual string Content { get; set; }
        public virtual ISet<string> Tags { get; protected set; }
        public virtual ISet<Attachment> Attachments { get; protected set; }
        public virtual IList<Comment> Comments { get; protected set; }
    }
}
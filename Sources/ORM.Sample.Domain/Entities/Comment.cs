using System;

namespace ORM.Sample.Domain.Entities
{
    public class Comment
    {
        public Comment()
        {
            Details = new UserDetail();
        }

        public virtual int CommentId { get; protected set; }
        public virtual UserDetail Details { get; set; }
        public virtual DateTime Timestamp { get; set; }
        public virtual string Content { get; set; }
        public virtual Post Post { get; set; }
    }
}
using System;

namespace ORM.Sample.Domain.Entities
{
    public class Attachment
    {
        public virtual int AttachementId { get; protected set; }
        public virtual string FileName { get; set; }
        public virtual Byte[] Contents { get; set; }
        public virtual DateTime Timestamp { get; set; }
        public virtual Post Post { get; set; }
    }
}
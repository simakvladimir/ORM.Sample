using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORM.Sample.Domain.Entities;

namespace ORM.Sample.EF.Context
{
    public class DomainContext : DbContext
    {
        public DomainContext()
        {
            EnableDebug();
        }

        public DomainContext(string connection) :
            base(connection)
        {
            EnableDebug();
        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Fluent
            modelBuilder.Entity<User>().ToTable("User");

            base.OnModelCreating(modelBuilder);
        }

        private void EnableDebug()
        {
            Database.Log = Console.Write;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TodoWebApiV1.Entities
{
    public class TodoContext : DbContext
    {
        public TodoContext(): base("name=DefaultConnection")
        {
        }

        public TodoContext(DbConnection existingConnection, bool contextOwnsConnection): base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new TodoMap());
          


        }


        public DbSet<Todo> Todos { get; set; }

    }
}
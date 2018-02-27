using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFTest
{
    public class MyEntities:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<maintenance_staff>().ToTable("maintenance_staff");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<maintenance_staff> Staffs { get; set; }
    }
}
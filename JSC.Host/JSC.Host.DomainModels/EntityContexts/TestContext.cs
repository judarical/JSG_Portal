using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSC.Host.DomainModels.EntityContexts
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    using JSC.Host.DomainModels.EntityModels;

    class TestContext : DbContext
    {
        public TestContext() : base("TestContext")
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
            // PostgreSQL uses the public schema by default - not dbo.
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}

using NBUY_MOD.DAL.Mappings;
using NBUY_MOD.Entities;
using NBUY_MOD.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUY_MOD.DAL.Database
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()// : base("")
        {
            //Configuration.LazyLoadingEnabled = false;

            Database.Connection.ConnectionString = @"Server=.;Database=NBUY_MOD;Uid=sa;Pwd=123;";

            var id = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<News> News { get; set; } 

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new CategoryMappings());
            
        }
    }
}

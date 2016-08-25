using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Prodac16.WebUI.Models.Orm.Entity;

namespace Prodac16.WebUI.Models.Orm.Context
{
    public class ProdacDbContext:DbContext
    {
        public ProdacDbContext()
        {
            Database.Connection.ConnectionString =
                "Data Source=.\\SQLEXPRESS;Initial Catalog=Prodac2016Db;Persist Security Info=True;User ID=sa;Password=Pl123456;";
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Bolum> Bolums { get; set; }
        public DbSet<Gorev> Gorevs { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<YonetimNavBar> YonetimNavBars { get; set; }

    }
}
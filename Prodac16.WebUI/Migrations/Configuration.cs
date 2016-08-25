using Prodac16.WebUI.Models.Orm.Entity;

namespace Prodac16.WebUI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Prodac16.WebUI.Models.Orm.Context.ProdacDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Prodac16.WebUI.Models.Orm.Context.ProdacDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            
            // Varsayýlan Bölüm Ekleniyor.

            Bolum bolum = new Bolum()
            {
                ID = 1,
                BolumAdi = "Bilgi Islem"
            };
            context.Bolums.AddOrUpdate(bolum);

            // Varsayýlan Görev Ekleme
            Gorev gorev = new Gorev()
            {
                ID = 1,
                BolumID = 1,
                GorevAdi = "Yazilim Gelistirici"
            };

            context.Gorevs.AddOrUpdate(gorev);


            // Varsayýlan olan kendi kullanýcýmý ekliyorum.
            Kullanici kullanici = new Kullanici()
            {
                ID = 1,
                Adi = "Mesut",
                IsDeleted = false,
                Resim = null,
                SicilNo = "4444",
                Soyadi = "SEN",
                Parola = "bu2003se--",
                IsUpdated = false,
                AddDate = DateTime.Now,
                UpdatedDate = null,
                DeletedDate = null,
                BolumID = 1,
                GorevID = 1,
                KullaniciAdi = "admin",
                EMailAdresi = "mesut.sen@ermetal.com"
            };
            context.Kullanicis.AddOrUpdate(kullanici);

        }
    }
}

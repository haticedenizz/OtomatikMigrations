namespace _09032022_OtomatikMigrations.Migrations
{
    using _09032022_OtomatikMigrations.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_09032022_OtomatikMigrations.Models.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(_09032022_OtomatikMigrations.Models.DatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            for (int i = 0; i < 10; i++)
            {
                context.Kitaplar.AddOrUpdate(new Kitap()
                {
                    ID=i+1,
                    KitapAd = FakeData.NameData.GetCompanyName(),
                    Aciklama = FakeData.TextData.GetSentence(),
                    Aciklama2="test",
                    Aciklama3=0,
                    Aciklama4="deneme",
                    YayinTarihi = FakeData.DateTimeData.GetDatetime()
                });               
               
            }
            context.SaveChanges();

            for (int i = 0; i < 5; i++)
            {
                context.Yazarlar.AddOrUpdate(new Yazar()
                {
                    ID = i + 1,
                    isim=FakeData.NameData.GetFirstName(),
                    Soyisim=FakeData.NameData.GetSurname(),
                    DogumTarihi=FakeData.DateTimeData.GetDatetime()
                }) ;
            }
            context.SaveChanges();

        }
    }
}

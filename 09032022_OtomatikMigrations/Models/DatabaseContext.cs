using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _09032022_OtomatikMigrations.Models
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DatabaseContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContext, _09032022_OtomatikMigrations.Migrations.Configuration>());
        }

    }
}
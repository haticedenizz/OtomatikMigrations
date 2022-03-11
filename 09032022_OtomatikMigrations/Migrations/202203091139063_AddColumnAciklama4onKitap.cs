namespace _09032022_OtomatikMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnAciklama4onKitap : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kitap", "Aciklama4", c => c.String(nullable:false,
                defaultValue:"test",defaultValueSql:"deneme"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kitap", "Aciklama4");
        }
    }
}

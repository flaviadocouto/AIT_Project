namespace PetAdoption.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelsUpdates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "Info", c => c.String());
            AddColumn("dbo.Shelters", "email", c => c.String());
            AddColumn("dbo.Shelters", "phone", c => c.Int(nullable: false));
            DropColumn("dbo.Animals", "BreedID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Animals", "BreedID", c => c.Int(nullable: false));
            DropColumn("dbo.Shelters", "phone");
            DropColumn("dbo.Shelters", "email");
            DropColumn("dbo.Animals", "Info");
        }
    }
}

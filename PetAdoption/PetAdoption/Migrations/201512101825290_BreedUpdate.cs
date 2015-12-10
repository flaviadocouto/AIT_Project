namespace PetAdoption.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BreedUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Breeds", "BreedType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Breeds", "BreedType");
        }
    }
}

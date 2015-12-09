namespace PetAdoption.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeAdoptionModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Adoptions", "AnimalID", c => c.Int(nullable: false));
            AddColumn("dbo.Adoptions", "ShelterID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Adoptions", "ShelterID");
            DropColumn("dbo.Adoptions", "AnimalID");
        }
    }
}

namespace PetAdoption.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeAgain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shelters", "Adoption_AdoptionID", c => c.Int());
            CreateIndex("dbo.Shelters", "Adoption_AdoptionID");
            AddForeignKey("dbo.Shelters", "Adoption_AdoptionID", "dbo.Adoptions", "AdoptionID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shelters", "Adoption_AdoptionID", "dbo.Adoptions");
            DropIndex("dbo.Shelters", new[] { "Adoption_AdoptionID" });
            DropColumn("dbo.Shelters", "Adoption_AdoptionID");
        }
    }
}

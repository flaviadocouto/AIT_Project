namespace PetAdoption.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adoptions",
                c => new
                    {
                        AdoptionID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AdoptionID);
            
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        AnimalID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Gender = c.String(),
                        Breed_BreedID = c.Int(),
                        Shelter_ShelterID = c.Int(),
                    })
                .PrimaryKey(t => t.AnimalID)
                .ForeignKey("dbo.Breeds", t => t.Breed_BreedID)
                .ForeignKey("dbo.Shelters", t => t.Shelter_ShelterID)
                .Index(t => t.Breed_BreedID)
                .Index(t => t.Shelter_ShelterID);
            
            CreateTable(
                "dbo.Breeds",
                c => new
                    {
                        BreedID = c.Int(nullable: false, identity: true),
                        BreedName = c.String(),
                    })
                .PrimaryKey(t => t.BreedID);
            
            CreateTable(
                "dbo.Shelters",
                c => new
                    {
                        ShelterID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ShelterID);
            
            CreateTable(
                "dbo.AnimalAdoptions",
                c => new
                    {
                        Animal_AnimalID = c.Int(nullable: false),
                        Adoption_AdoptionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Animal_AnimalID, t.Adoption_AdoptionID })
                .ForeignKey("dbo.Animals", t => t.Animal_AnimalID, cascadeDelete: true)
                .ForeignKey("dbo.Adoptions", t => t.Adoption_AdoptionID, cascadeDelete: true)
                .Index(t => t.Animal_AnimalID)
                .Index(t => t.Adoption_AdoptionID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animals", "Shelter_ShelterID", "dbo.Shelters");
            DropForeignKey("dbo.Animals", "Breed_BreedID", "dbo.Breeds");
            DropForeignKey("dbo.AnimalAdoptions", "Adoption_AdoptionID", "dbo.Adoptions");
            DropForeignKey("dbo.AnimalAdoptions", "Animal_AnimalID", "dbo.Animals");
            DropIndex("dbo.AnimalAdoptions", new[] { "Adoption_AdoptionID" });
            DropIndex("dbo.AnimalAdoptions", new[] { "Animal_AnimalID" });
            DropIndex("dbo.Animals", new[] { "Shelter_ShelterID" });
            DropIndex("dbo.Animals", new[] { "Breed_BreedID" });
            DropTable("dbo.AnimalAdoptions");
            DropTable("dbo.Shelters");
            DropTable("dbo.Breeds");
            DropTable("dbo.Animals");
            DropTable("dbo.Adoptions");
        }
    }
}

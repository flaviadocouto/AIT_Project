namespace PetAdoption.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnimalModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Animals", "Breed_BreedID", "dbo.Breeds");
            DropIndex("dbo.Animals", new[] { "Breed_BreedID" });
            CreateTable(
                "dbo.BreedAnimals",
                c => new
                    {
                        Breed_BreedID = c.Int(nullable: false),
                        Animal_AnimalID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Breed_BreedID, t.Animal_AnimalID })
                .ForeignKey("dbo.Breeds", t => t.Breed_BreedID, cascadeDelete: true)
                .ForeignKey("dbo.Animals", t => t.Animal_AnimalID, cascadeDelete: true)
                .Index(t => t.Breed_BreedID)
                .Index(t => t.Animal_AnimalID);
            
            AddColumn("dbo.Animals", "BreedID", c => c.Int(nullable: false));
            AddColumn("dbo.Animals", "MF", c => c.Int(nullable: false));
            AddColumn("dbo.Animals", "ForAdoption", c => c.Boolean(nullable: false));
            DropColumn("dbo.Animals", "Gender");
            DropColumn("dbo.Animals", "Breed_BreedID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Animals", "Breed_BreedID", c => c.Int());
            AddColumn("dbo.Animals", "Gender", c => c.String());
            DropForeignKey("dbo.BreedAnimals", "Animal_AnimalID", "dbo.Animals");
            DropForeignKey("dbo.BreedAnimals", "Breed_BreedID", "dbo.Breeds");
            DropIndex("dbo.BreedAnimals", new[] { "Animal_AnimalID" });
            DropIndex("dbo.BreedAnimals", new[] { "Breed_BreedID" });
            DropColumn("dbo.Animals", "ForAdoption");
            DropColumn("dbo.Animals", "MF");
            DropColumn("dbo.Animals", "BreedID");
            DropTable("dbo.BreedAnimals");
            CreateIndex("dbo.Animals", "Breed_BreedID");
            AddForeignKey("dbo.Animals", "Breed_BreedID", "dbo.Breeds", "BreedID");
        }
    }
}

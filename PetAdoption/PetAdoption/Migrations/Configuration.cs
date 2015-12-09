namespace PetAdoption.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PetAdoption.Models.PetAdoptionModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PetAdoption.Models.PetAdoptionModelContext";
        }

        protected override void Seed(PetAdoption.Models.PetAdoptionModelContext context)
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
            var Animals = new List<Animal>
            {
                new Animal { AnimalID = 1, Name = "Carson",   Gender = "Male",
                    DOB = DateTime.Parse("2010-09-01") },
                new Animal { AnimalID = 2, Name = "Meredith", Gender = "Female",
                    DOB = DateTime.Parse("2012-09-01") },
                new Animal { AnimalID = 3, Name = "Arturo",   Gender = "Male",
                    DOB = DateTime.Parse("2013-09-01") },
                new Animal { AnimalID = 4, Name = "Gytis",    Gender = "Female",
                    DOB = DateTime.Parse("2012-09-01") },
                new Animal { AnimalID = 5, Name = "Yan",      Gender = "Male",
                    DOB = DateTime.Parse("2012-09-01") },
                new Animal { AnimalID = 6, Name = "Peggy",    Gender = "Female",
                    DOB = DateTime.Parse("2011-09-01") },
                new Animal { AnimalID = 7, Name  = "Laura",    Gender = "Female",
                    DOB = DateTime.Parse("2013-09-01") },
                new Animal { AnimalID = 8, Name = "Nino",     Gender = "Male",
                    DOB = DateTime.Parse("2005-08-11") }
            };
            Animals.ForEach(s => context.Animals.AddOrUpdate(p => p.AnimalID, s));
            context.SaveChanges();

            //*******************BREED********************
            var Breeds  = new List<Breed>
            {
                new Breed { BreedID = 1, BreedName = "Affenpinscher" },
new Breed { BreedID = 2, BreedName = "Afghan Hound" },
new Breed { BreedID = 3, BreedName = "Airedale Terrier" },
new Breed { BreedID = 4, BreedName = "Akita" },
new Breed { BreedID = 5, BreedName = "Alaskan Malamute" },
new Breed { BreedID = 6, BreedName = "American Eskimo Dog" },
new Breed { BreedID = 7, BreedName = "American Foxhound" },
new Breed { BreedID = 8, BreedName = "American Staffordshire Terrier" },
new Breed { BreedID = 9, BreedName = "American Water Spaniel" },
new Breed { BreedID = 10, BreedName = "Anatolian Shepherd Dog" },
new Breed { BreedID = 11, BreedName = "Australian Cattle Dog" },
new Breed { BreedID = 12, BreedName = "Australian Shepherd" },
new Breed { BreedID = 13, BreedName = "Australian Terrier" },
new Breed { BreedID = 14, BreedName = "Basenji" },
new Breed { BreedID = 15, BreedName = "Basset Hound" },
new Breed { BreedID = 16, BreedName = "Beagle" },
new Breed { BreedID = 17, BreedName = "Bearded Collie" },
new Breed { BreedID = 18, BreedName = "Beauceron " },
new Breed { BreedID = 19, BreedName = "Bedlington Terrier" },
new Breed { BreedID = 20, BreedName = "Belgian Malinois" },
new Breed { BreedID = 21, BreedName = "Belgian Sheepdog" },
new Breed { BreedID = 22, BreedName = "Belgian Tervuren" },
new Breed { BreedID = 23, BreedName = "Bernese Mountain Dog" },
new Breed { BreedID = 24, BreedName = "Bichon Frise " },
new Breed { BreedID = 25, BreedName = "Black And Tan Coonhound" },
new Breed { BreedID = 26, BreedName = "Bloodhound" },
new Breed { BreedID = 27, BreedName = "Bluetick Coonhound " },
new Breed { BreedID = 28, BreedName = "Border Collie" },
new Breed { BreedID = 29, BreedName = "Border Terrier" },
new Breed { BreedID = 30, BreedName = "Borzoi" },
new Breed { BreedID = 31, BreedName = "Boston Terrier " },
new Breed { BreedID = 32, BreedName = "Des Flandres" },
new Breed { BreedID = 33, BreedName = "Boxer" },
new Breed { BreedID = 34, BreedName = "Boykin Spaniel" },
new Breed { BreedID = 35, BreedName = "Briard" },
new Breed { BreedID = 36, BreedName = "Brittany" },
new Breed { BreedID = 37, BreedName = "Brussels Griffon" },
new Breed { BreedID = 38, BreedName = "Bull Terrier" },
new Breed { BreedID = 39, BreedName = "Bulldog" },
new Breed { BreedID = 40, BreedName = "Bullmastiff" },
new Breed { BreedID = 41, BreedName = "Cairn Terrier" },
new Breed { BreedID = 42, BreedName = "Canaan Dog" },
new Breed { BreedID = 43, BreedName = "Cane Corso" },
new Breed { BreedID = 44, BreedName = "Cardigan Welsh Corgi" },
new Breed { BreedID = 45, BreedName = "Cavalier King Charles Spaniel" },
new Breed { BreedID = 46, BreedName = "Chesapeake Bay Retriever" },
new Breed { BreedID = 47, BreedName = "Chihuahua" },
new Breed { BreedID = 48, BreedName = "Chinese CrestedGolden Retriever" },
new Breed { BreedID = 49, BreedName = "Chinese Shar-PeiGordon Setter" },
new Breed { BreedID = 50, BreedName = "Chow Chow" },
new Breed { BreedID = 51, BreedName = "Clumber Spaniel" },
new Breed { BreedID = 52, BreedName = "Cocker Spaniel" },
new Breed { BreedID = 53, BreedName = "Collie" },
new Breed { BreedID = 54, BreedName = "Curly-Coated Retriever" },
new Breed { BreedID = 55, BreedName = "Dachshund" },
new Breed { BreedID = 56, BreedName = "Dalmatian" },
new Breed { BreedID = 57, BreedName = "Dandie Dinmont Terrier" },
new Breed { BreedID = 58, BreedName = "Doberman Pinscher" },
new Breed { BreedID = 59, BreedName = "Dogue De Bordeaux" },
new Breed { BreedID = 60, BreedName = "English Cocker Spaniel" },
new Breed { BreedID = 61, BreedName = "English Setter" },
new Breed { BreedID = 62, BreedName = "English Springer Spaniel" },
new Breed { BreedID = 63, BreedName = "English Toy Spaniel" },
new Breed { BreedID = 64, BreedName = "Entlebucher Mountain Dog" },
new Breed { BreedID = 65, BreedName = "Field Spaniel" },
new Breed { BreedID = 66, BreedName = "Finnish Spitz" },
new Breed { BreedID = 67, BreedName = "Flat-Coated Retriever" },
new Breed { BreedID = 68, BreedName = "French Bulldog" },
new Breed { BreedID = 69, BreedName = "German Pinscher" },
new Breed { BreedID = 70, BreedName = "German Shepherd Dog" },
new Breed { BreedID = 71, BreedName = "German Shorthaired Pointer" },
new Breed { BreedID = 72, BreedName = "German Wirehaired Pointer" },
new Breed { BreedID = 73, BreedName = "Giant Schnauzer" },
new Breed { BreedID = 74, BreedName = "Glen Of Imaal Terrier " },
new Breed { BreedID = 75, BreedName = "Great Dane" },
new Breed { BreedID = 76, BreedName = "Great Pyrenees" },
new Breed { BreedID = 77, BreedName = "Greater Swiss Mountain Dog " },
new Breed { BreedID = 78, BreedName = "Greyhound" },
new Breed { BreedID = 79, BreedName = "Havanese" },
new Breed { BreedID = 80, BreedName = "Ibizan Hound" },
new Breed { BreedID = 81, BreedName = "Icelandic Sheepdog" },
new Breed { BreedID = 82, BreedName = "Irish Red And White Setter" },
new Breed { BreedID = 83, BreedName = "Irish Setter" },
new Breed { BreedID = 84, BreedName = "Irish Terrier" },
new Breed { BreedID = 85, BreedName = "Irish Water Spaniel" },
new Breed { BreedID = 86, BreedName = "Irish Wolfhound" },
new Breed { BreedID = 87, BreedName = "Italian Greyhound" },
new Breed { BreedID = 88, BreedName = "Japanese Chin" },
new Breed { BreedID = 89, BreedName = "Keeshond" },
new Breed { BreedID = 90, BreedName = "Kerry Blue Terrier" },
new Breed { BreedID = 91, BreedName = "KomondorPlott" },
new Breed { BreedID = 92, BreedName = "Kuvasz" },
new Breed { BreedID = 93, BreedName = "Labrador Retriever" },
new Breed { BreedID = 94, BreedName = "Lakeland Terrier" },
new Breed { BreedID = 95, BreedName = "Leonberger" },
new Breed { BreedID = 96, BreedName = "Lhasa Apso" },
new Breed { BreedID = 97, BreedName = "Lowchen" },
new Breed { BreedID = 98, BreedName = "Maltese" },
new Breed { BreedID = 99, BreedName = "Manchester Terrier " },
new Breed { BreedID = 100, BreedName = "Mastiff" },
new Breed { BreedID = 101, BreedName = "Miniature Schnauzer" },
new Breed { BreedID = 102, BreedName = "Neapolitan Mastiff " },
new Breed { BreedID = 103, BreedName = "Newfoundland" },
new Breed { BreedID = 104, BreedName = "Norfolk Terrier" },
new Breed { BreedID = 105, BreedName = "Norwegian Buhund" },
new Breed { BreedID = 106, BreedName = "Norwegian Elkhound" },
new Breed { BreedID = 107, BreedName = "Norwegian Lundehund" },
new Breed { BreedID = 108, BreedName = "Norwich Terrier" },
new Breed { BreedID = 109, BreedName = "Nova Scotia Duck Tolling Retriever" },
new Breed { BreedID = 110, BreedName = "Old English Sheepdog" },
new Breed { BreedID = 111, BreedName = "Otterhound" },
new Breed { BreedID = 112, BreedName = "Papillon" },
new Breed { BreedID = 113, BreedName = "Parson Russell Terrier" },
new Breed { BreedID = 114, BreedName = "Pekingese" },
new Breed { BreedID = 115, BreedName = "Pembroke Welsh Corgi" },
new Breed { BreedID = 116, BreedName = "Petit Basset Griffon Vendeen" },
new Breed { BreedID = 117, BreedName = "Pharaoh Hound" },
new Breed { BreedID = 118, BreedName = "Pointer" },
new Breed { BreedID = 119, BreedName = "Pomeranian" },
new Breed { BreedID = 120, BreedName = "Poodle" },
new Breed { BreedID = 121, BreedName = "Portuguese Water Dog" },
new Breed { BreedID = 122, BreedName = "Saint Bernard" },
new Breed { BreedID = 123, BreedName = "Silky Terrier" },
new Breed { BreedID = 124, BreedName = "Smooth Fox Terrier" },
new Breed { BreedID = 125, BreedName = "Tibetan Mastiff" },
new Breed { BreedID = 126, BreedName = "Welsh Springer Spaniel" },
new Breed { BreedID = 127, BreedName = "Wirehaired Pointing Griffon" },
new Breed { BreedID = 128, BreedName = "Xoloitzcuintli" },
new Breed { BreedID = 129, BreedName = "Yorkshire Terrier" }


            };
            Breeds.ForEach(s => context.Breeds.AddOrUpdate(p => p.BreedID, s));
            context.SaveChanges();

            //********************SHELTER*********************
            var Shelters = new List<Shelter>
            {
                new Shelter { ShelterID = 1, Name = "Happy Home" },
                new Shelter { ShelterID = 2, Name = "DSPCA" },
                new Shelter { ShelterID = 3, Name = "Irish dogs" },
                new Shelter { ShelterID = 4, Name = "Home Forever" },
                new Shelter { ShelterID = 6, Name = "Madra" },

            };
            Shelters.ForEach(s => context.Shelters.AddOrUpdate(p => p.ShelterID, s));
            context.SaveChanges();

            //********************ADOPTIONS*********************
            var Adoptions = new List<Adoption>
            {
                new Adoption { AdoptionID = 1, Date = DateTime.Parse("2015-09-01") },
                new Adoption { AdoptionID = 2, Date = DateTime.Parse("2015-09-01") },
                new Adoption { AdoptionID = 3, Date = DateTime.Parse("2015-09-01") },
                new Adoption { AdoptionID = 4, Date = DateTime.Parse("2015-09-01") },
            };
            Adoptions.ForEach(s => context.Adoptions.AddOrUpdate(p => p.AdoptionID, s));
            context.SaveChanges();
        }
    }
}

namespace PetAdoption.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PetAdoptionModelContext>
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
                new Animal
                {
                    AnimalID = 1,
                    Name = "Carson",
                    BreedID = 3,
                    MF = Gender.Male,
                    DOB = DateTime.Parse("2010-09-01"),
                    ForAdoption = false
                },
                new Animal
                {
                    AnimalID = 2,
                    Name = "Meredith",
                    BreedID = 40,
                    MF = Gender.Female,
                    DOB = DateTime.Parse("2012-09-01"),
                    ForAdoption = false
                },
                new Animal
                { AnimalID = 3,
                    Name = "Arturo",
                    BreedID = 33,
                    MF = Gender.Male,
                    DOB = DateTime.Parse("2013-09-01"),
                    ForAdoption = true
                },
                new Animal
                { AnimalID = 4,
                    Name = "Gytis",
                    MF = Gender.Female,
                    DOB = DateTime.Parse("2012-09-01"),
                    ForAdoption = true
                },
                new Animal
                { AnimalID = 5,
                    Name = "Yan",
                    BreedID = 79,
                    MF = Gender.Male,
                    DOB = DateTime.Parse("2012-09-01"),
                    ForAdoption = true
                },
                new Animal
                { AnimalID = 6,
                    Name = "Peggy",
                    BreedID = 111,
                    MF = Gender.Female,
                    DOB = DateTime.Parse("2011-09-01"),
                    ForAdoption = true
                },
                new Animal
                { AnimalID = 7,
                    Name  = "Laura",
                    MF = Gender.Female,
                    DOB = DateTime.Parse("2013-09-01"),
                    ForAdoption = true
                },
                new Animal { AnimalID = 8,
                    Name = "Nino",
                    BreedID = 78,
                    MF = Gender.Male,
                    DOB = DateTime.Parse("2005-08-11"),
                    ForAdoption = true
                }
            };
            Animals.ForEach(s => context.Animals.AddOrUpdate(p => p.AnimalID, s));
            context.SaveChanges();

            //*******************BREED********************
            var Breeds  = new List<Breed>
            {
                new Breed { BreedID = 1, BreedName = "Affenpinscher", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 2, BreedName = "Afghan Hound", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 3, BreedName = "Airedale Terrier", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 4, BreedName = "Akita", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 5, BreedName = "Alaskan Malamute", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 6, BreedName = "American Eskimo Dog", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 7, BreedName = "American Foxhound", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 8, BreedName = "American Staffordshire Terrier", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 9, BreedName = "American Water Spaniel", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 10, BreedName = "Anatolian Shepherd Dog", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 11, BreedName = "Australian Cattle Dog", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 12, BreedName = "Australian Shepherd", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 13, BreedName = "Australian Terrier", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 14, BreedName = "Basenji", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 15, BreedName = "Basset Hound", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 16, BreedName = "Beagle", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 17, BreedName = "Bearded Collie", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 18, BreedName = "Beauceron ", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 19, BreedName = "Bedlington Terrier", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 20, BreedName = "Belgian Malinois", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 21, BreedName = "Belgian Sheepdog", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 22, BreedName = "Belgian Tervuren", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 23, BreedName = "Bernese Mountain Dog", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 24, BreedName = "Bichon Frise ", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 25, BreedName = "Black And Tan Coonhound", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 26, BreedName = "Bloodhound", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 27, BreedName = "Bluetick Coonhound ", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 28, BreedName = "Border Collie", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 29, BreedName = "Border Terrier", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 30, BreedName = "Borzoi", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 31, BreedName = "Boston Terrier ", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 32, BreedName = "Des Flandres", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 33, BreedName = "Boxer", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 34, BreedName = "Boykin Spaniel", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 35, BreedName = "Briard", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 36, BreedName = "Brittany", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 37, BreedName = "Brussels Griffon", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 38, BreedName = "Bull Terrier", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 39, BreedName = "Bulldog", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 40, BreedName = "Bullmastiff", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 41, BreedName = "Cairn Terrier", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 42, BreedName = "Canaan Dog", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 43, BreedName = "Cane Corso", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 44, BreedName = "Cardigan Welsh Corgi", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 45, BreedName = "Cavalier King Charles Spaniel", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 46, BreedName = "Chesapeake Bay Retriever", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 47, BreedName = "Chihuahua", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 48, BreedName = "Chinese CrestedGolden Retriever", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 49, BreedName = "Chinese Shar-PeiGordon Setter", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 50, BreedName = "Chow Chow", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 51, BreedName = "Clumber Spaniel", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 52, BreedName = "Cocker Spaniel", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 53, BreedName = "Collie", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 54, BreedName = "Curly-Coated Retriever", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 55, BreedName = "Dachshund", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 56, BreedName = "Dalmatian", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 57, BreedName = "Dandie Dinmont Terrier", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 58, BreedName = "Doberman Pinscher", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 59, BreedName = "Dogue De Bordeaux", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 60, BreedName = "English Cocker Spaniel", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 61, BreedName = "English Setter", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 62, BreedName = "English Springer Spaniel", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 63, BreedName = "English Toy Spaniel", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 64, BreedName = "Entlebucher Mountain Dog", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 65, BreedName = "Field Spaniel", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 66, BreedName = "Finnish Spitz", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 67, BreedName = "Flat-Coated Retriever", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 68, BreedName = "French Bulldog", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 69, BreedName = "German Pinscher", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 70, BreedName = "German Shepherd Dog", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 71, BreedName = "German Shorthaired Pointer", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 72, BreedName = "German Wirehaired Pointer", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 73, BreedName = "Giant Schnauzer", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 74, BreedName = "Glen Of Imaal Terrier ", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 75, BreedName = "Great Dane", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 76, BreedName = "Great Pyrenees", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 77, BreedName = "Greater Swiss Mountain Dog ", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 78, BreedName = "Greyhound", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 79, BreedName = "Havanese", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 80, BreedName = "Ibizan Hound", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 81, BreedName = "Icelandic Sheepdog", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 82, BreedName = "Irish Red And White Setter", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 83, BreedName = "Irish Setter", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 84, BreedName = "Irish Terrier", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 85, BreedName = "Irish Water Spaniel", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 86, BreedName = "Irish Wolfhound", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 87, BreedName = "Italian Greyhound", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 88, BreedName = "Japanese Chin", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 89, BreedName = "Keeshond", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 90, BreedName = "Kerry Blue Terrier", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 91, BreedName = "KomondorPlott", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 92, BreedName = "Kuvasz", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 93, BreedName = "Labrador Retriever", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 94, BreedName = "Lakeland Terrier", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 95, BreedName = "Leonberger", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 96, BreedName = "Lhasa Apso", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 97, BreedName = "Lowchen", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 98, BreedName = "Maltese", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 99, BreedName = "Manchester Terrier ", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 100, BreedName = "Mastiff", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 101, BreedName = "Miniature Schnauzer", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 102, BreedName = "Neapolitan Mastiff ", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 103, BreedName = "Newfoundland", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 104, BreedName = "Norfolk Terrier", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 105, BreedName = "Norwegian Buhund", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 106, BreedName = "Norwegian Elkhound", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 107, BreedName = "Norwegian Lundehund", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 109, BreedName = "Nova Scotia Duck Tolling Retriever", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 110, BreedName = "Old English Sheepdog", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 111, BreedName = "Otterhound", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 112, BreedName = "Papillon", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 113, BreedName = "Parson Russell Terrier", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 114, BreedName = "Pekingese", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 115, BreedName = "Pembroke Welsh Corgi", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 116, BreedName = "Petit Basset Griffon Vendeen", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 117, BreedName = "Pharaoh Hound", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 118, BreedName = "Pointer", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 119, BreedName = "Pomeranian", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 120, BreedName = "Poodle", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 121, BreedName = "Portuguese Water Dog", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 122, BreedName = "Saint Bernard", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 123, BreedName = "Silky Terrier", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 124, BreedName = "Smooth Fox Terrier", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 125, BreedName = "Tibetan Mastiff", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 126, BreedName = "Welsh Springer Spaniel", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 127, BreedName = "Wirehaired Pointing Griffon", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 128, BreedName = "Xoloitzcuintli", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"},
                new Breed { BreedID = 129, BreedName = "Yorkshire Terrier", BreedType = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"}
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
                new Adoption { AdoptionID = 1, AnimalID = 2, Date = DateTime.Parse("2015-09-01"), ShelterID = 0 },
                new Adoption { AdoptionID = 2, AnimalID = 3, Date = DateTime.Parse("2015-09-01"), ShelterID = 2 },
            };
            Adoptions.ForEach(s => context.Adoptions.AddOrUpdate(p => p.AdoptionID, s));
            context.SaveChanges();
        }
    }
}

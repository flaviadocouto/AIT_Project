using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PetAdoption.Models
{
    public class PetAdoptionModelContext : DbContext
    {
        public PetAdoptionModelContext() : base("PetAdoptionContext")
        {

        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Shelter> Shelters { get; set; }
        public DbSet<Adoption> Adoptions { get; set; }
     }
}
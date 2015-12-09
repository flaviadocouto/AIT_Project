using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetAdoption.Models
{
    public class Breed
    {
        private ICollection<Animal> _animals;

        public Breed()
        {
            _animals = new List<Animal>();
        }


        public int BreedID { get; set; }
        [Display(Name = "Breed")]
        public string BreedName { get; set; }
        

        public virtual ICollection<Animal> Animal
        {
            get { return _animals; }
            set { _animals = value; }
        }
    }
}
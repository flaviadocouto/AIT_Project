using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetAdoption.Models
{
    public class Adoption
    {
        private ICollection<Animal> _animals;

        public Adoption()
        {
            _animals = new List<Animal>();
        }


        public int AdoptionID { get; set; }
        [Display(Name = "Adopted Animals")]
        public int AnimalID { get; set; }
        [Display(Name = "Adoption Date")]
        public DateTime Date{ get; set; }
        [Display(Name = "Adopted From")]
        public int ShelterID { get; set; }


        public virtual ICollection<Animal> Animal
        {
            get { return _animals; }
            set { _animals = value; }
        }
    }
}
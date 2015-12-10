using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetAdoption.Models
{
    public class Shelter
    {
        private ICollection<Animal> _animals;

        public Shelter()
        {
            _animals = new List<Animal>();
        }


        public int ShelterID { get; set; }

        [Display(Name = "Shelter")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Phone Number")]
        public int phone { get; set; }

        public virtual ICollection<Animal> Animal
        {
            get { return _animals; }
            set { _animals = value; }
        }
    }
}
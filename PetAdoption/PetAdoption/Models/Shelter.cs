using System;
using System.Collections.Generic;
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
        public string Name { get; set; }


        public virtual ICollection<Animal> Animal
        {
            get { return _animals; }
            set { _animals = value; }
        }
    }
}
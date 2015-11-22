using System;
using System.Collections.Generic;
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
        public DateTime Date{ get; set; }


        public virtual ICollection<Animal> Animal
        {
            get { return _animals; }
            set { _animals = value; }
        }
    }
}
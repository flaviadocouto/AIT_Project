using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetAdoption.Models
{
    public class Animal
    {
        private ICollection<Adoption> _adoptions;
        private ICollection<Breed> _breeds;

        public Animal()
        {
            _adoptions = new List<Adoption>();
            _breeds = new List<Breed>();
        }


        public int AnimalID { get; set; }

        [Display(Name = "Pet Name")]
        public string Name { get; set; }

        [Display(Name = "Breed")]
        public int BreedID { get; set; }

        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }

        [Display(Name = "Gender")]
        public Gender MF { get; set; }

        [Display(Name = "For Adoption")]
        public bool ForAdoption { get; set; }


        public virtual ICollection<Adoption> Adoption
        {
            get { return _adoptions; }
            set { _adoptions = value; }
        }
        public virtual ICollection<Breed> Breed 
        {
            get { return _breeds; }
            set { _breeds = value; }
        }
    }
}
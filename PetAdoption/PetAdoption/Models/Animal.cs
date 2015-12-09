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

        public Animal()
        {
            _adoptions = new List<Adoption>();
        }


        public int AnimalID { get; set; }
        [Display(Name = "Pet Name")]
        public string Name { get; set; }
        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
       

        public virtual ICollection<Adoption> Adoption
        {
            get { return _adoptions; }
            set { _adoptions = value; }
        }
    }
}
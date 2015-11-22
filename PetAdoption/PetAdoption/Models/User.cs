using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetAdoption.Models
{
    public class User
    {
        private ICollection<Adoption> _adoptions;

        public User()
        {
            _adoptions = new List<Adoption>();
        }


        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public EmailService Email { get; set; }

        public virtual ICollection<Adoption> Adoption
        {
            get { return _adoptions; }
            set { _adoptions = value; }
        }
    }
}
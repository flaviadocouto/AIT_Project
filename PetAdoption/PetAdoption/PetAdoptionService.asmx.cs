using PetAdoption.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PetAdoption
{
    /// <summary>
    /// Summary description for PetAdoptionService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PetAdoptionService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        private PetAdoptionModelContext entities = new PetAdoptionModelContext();

        [WebMethod]
        public string[] GetDogsByName(string name)
        {
            List<string> animals = new List<string>();

            foreach (var dog in entities.Animals
                                         .Where(b => b.Name.Contains(name))
                                         .ToList())
            {
                animals.Add(dog.Name);
            }
            return animals.ToArray();
        }

        [WebMethod]
        public string[] GetShelterByName(string name)
        {
            List<string> shelters = new List<string>();

            foreach (var shelter in entities.Shelters
                                         .Where(b => b.Name.Contains(name))
                                         .ToList())
            {
                shelters.Add(shelter.Name);
            }
            return shelters.ToArray();
        }

        [WebMethod]
        public string[] GetBreedByName(string name)
        {
            List<string> breeds = new List<string>();

            foreach (var breed in entities.Breeds
                                         .Where(b => b.BreedName.Contains(name))
                                         .ToList())
            {
                breeds.Add(breed.BreedName);
            }
            return breeds.ToArray();
        }

        [WebMethod]
        public string[] GetDogsForAdoption()
        {
            List<string> dogs = new List<string>();

            foreach (var dog in entities.Animals
                                         .Where(b => b.ForAdoption)
                                         .ToList())
            {
                dogs.Add(dog.Name);
            }
            return dogs.ToArray();
        }

        [WebMethod]
        public string[] GetAdoptedDogs()
        {
            List<string> dogs = new List<string>();

            foreach (var dog in entities.Animals
                                         .Where(b => b.ForAdoption.Equals(false)))
            {
                dogs.Add(dog.Name);
            }
            return dogs.ToArray();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Repository;
using Model;

 namespace PubsService
{

    public static class AuthorMapperExtensionMethods
    {
        public static authorViewModel ConvertToViewModel(this author authorIn)
        {
            authorViewModel avm = new authorViewModel(authorIn.id);

            avm.LastName = authorIn._lname;
            avm.FirstName = authorIn._fname;
            avm.Phone = authorIn._phone;
            avm.Address = authorIn._address;
            avm.City = authorIn._city;
            avm.State = authorIn._state;
            avm.Zip = authorIn._zip;
            avm.Contract = authorIn._contract ? "Yes" : "No";

            return avm;
        }
    }

    public class authorViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Contract { get; set; }

        public string Name { get { return FirstName + " " + LastName; } }

        public authorViewModel(string id)
        {
            ID = id;
        }

        public authorViewModel(string id, string fname, string lname, string phone, string address, string city, string state, string zip, string contract)
        {
            
            LastName = lname;
            FirstName = fname;
            ID = id;
            Phone = phone;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            Contract = contract;
        }
    }

    public class authorsService
    {

        IRepository<author> _repository;
        public authorsService(authorRepository repo)
        {
            _repository = repo;
        }
        public List<authorViewModel> getAll()
        {
            List<authorViewModel> authors = new List<authorViewModel>();
            List < author> lstAuthors;

            lstAuthors = _repository.FindAll();

            foreach (author au in lstAuthors)
            {
                authors.Add(au.ConvertToViewModel());
            }

            return authors;
        }
    }
}

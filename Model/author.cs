using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class author
    {
        private string _id;
        public string _fname;
        public string _lname;
        public string _phone;
        public string _address;
        public string _city;
        public string _state;
        public string _zip;
        public bool _contract;

        public string id
        {
            get
            {
                return _id;
            }

        }

        public string FirstName
        {
            get
            {
                return _fname;
            }

            set
            {
                _fname = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lname;
            }

            set
            {
                _lname = value;
            }
        }

        public string Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }

        public string City
        {
            get
            {
                return _city;
            }

            set
            {
                _city = value;
            }
        }

        public string State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = value;
            }
        }

        public string Zip
        {
            get
            {
                return _zip;
            }

            set
            {
                _zip = value;
            }
        }

        public bool Contract
        {
            get
            {
                return _contract;
            }

            set
            {
                _contract = value;
            }
        }

        public string Name
        {
            get { return _fname + " " + _lname; }
        }

        public author(string id, string fname, string lname, string phone, string address, string city, string state, string zip, bool contract)
        {
            _id = id;
            _fname = fname;
            _lname = lname;
            _phone = phone;
            _address = address;
            _city = city;
            _state = state;
            _zip = zip;
            _contract = contract;
        }
    }
}

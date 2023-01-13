using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Customers
    {
        private readonly int _customersId;
        private  string _fullName;
        private  string _address;

        public int Id
        {
            get { return _customersId; }
        }

        public string FullName
        {
            get { return _fullName; }
            set
            {
                Validator.AssertStringOnLength(value, 200, nameof(FullName));
                _fullName= value;
            }
        }
       public string Address
        { get { return _address; } 
            set
            {
                Validator.AssertStringOnLength(value, 500, nameof(Address));
                _address= value;
            }
        }

        public Customers(int id,string fullName, string address)
        {
            _customersId= IdGenerator.GetNextCustomersId();
            fullName = _fullName;
            address = _address;

        }
        public Customers()
        {
            _customersId= IdGenerator.GetNextCustomersId();
            FullName= "FullName";
            Address = "Address";
        }


    }
}

using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Customers
    {
        private readonly int _customersId;
        private  string _fullName;
        private Address _address;

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
       public Address Address
        {
            get
            {
                return _address;
            }
            set { _address= value; }
        }

        public Customers(int id,string fullName, int index, string Country,string City,string Street,string Building, string Apartment)
        {
            _customersId= IdGenerator.GetNextCustomersId();
            fullName = _fullName;
            Address=new Address(index,Country,City,Street,Building,Apartment);
            

        }
        public Customers()
        {
            _customersId= IdGenerator.GetNextCustomersId();
            FullName= "FullName";
            Address=new Address();
        }


    }
}

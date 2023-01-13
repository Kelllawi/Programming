using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Address
    {
        private int _index;

        private string _country;

        private string _city;   

        private string _street;
        private string _building;
        private string _apartament;

        public int Index 
        { get
            {
                return _index;
            } 
            set
            { 
                Validator.AssertValueInRange(value,10000,999999,nameof(_index)); 
                _index = value;
            } 
        }
        public string Country
        { 
            get
            {
                return _country;
            }
            set
            {
                Validator.AssertStringOnLength(value,50,nameof(_country));
                _country = value;
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
                Validator.AssertStringOnLength(value,50,nameof(_city));
                _city = value;
            }
        }
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                Validator.AssertStringOnLength(value, 100, nameof(_street));
                _street = value;
            }
        }
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                Validator.AssertStringOnLength(value, 10, nameof(_building));
                _building = value;
            }
        }
        public string Apartament
        {
            get
            {
                return _apartament;
            }
            set
            {
                Validator.AssertStringOnLength(value,10, nameof(_apartament));
                _apartament = value;
            }
        }

        public Address(int index, string country, string city, string street, string building, string apartament)
        { 
            Index = _index;
            Country = _country;
            City=_city;
            Street=_street;
            Building = _building;
            Apartament = apartament;
        }
        public Address()
        {
            Index= 10000;
            Country = "Empty";
            City= "Empty";
            Street= "Empty";
            Building= "Empty";
            Apartament= "Empty";
        }
    }
}

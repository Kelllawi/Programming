using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Item
    {
        private readonly int _ItemsId;

        private string _name;

        private string _info;

        private double _cost;

        

        public int Id
        {
            get { return _ItemsId; }
        }

        public string Name
        {
            get 
            { 
                return _name; 
            }
            set
            {
                Validator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }
        public string Info
        {
            get { return _info; }
            set
            {
                Validator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }
        public double Cost
        {
            get { return _cost; }
            set
            {
                Validator.AssertValueInRange(value, 0, 10000, nameof(Cost));
                _cost = value;
            }
        }

        public Category category { get; set; }
        

        public Item(int Id, string Name, string Info, double Cost, int categoryindex)
        {
            _ItemsId = IdGenerator.GetNextId();
            Name = _name;
            Info = _info;
            Cost = _cost;
            category = (Category)categoryindex;

        }
        public Item()
        {
            _ItemsId = IdGenerator.GetNextId();
            Name = "Empty";
            Info = "Empty";
            Cost = 0;
            category = 0;
        }
    }
}

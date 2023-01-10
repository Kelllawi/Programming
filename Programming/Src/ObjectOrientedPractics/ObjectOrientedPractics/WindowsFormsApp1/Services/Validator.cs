using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
     class Validator
    {
        public static void AssertStringOnLength(string @string, int value, string fieldname )
        {
            if ( @string.Length<value )
            {
                throw new ArgumentException($"{fieldname} can't be more than{value} characters");
            }
        }

        public static void AssertValueInRange(double value , double min, double max, string fieldname) 
        {
            if (!( value >= min )||(!(value<=max))
                {
                throw new ArgumentException($"Value in {fieldname} must be greater than {min} and less than {max}");
            }
        }
    }
}

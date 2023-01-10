using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    internal class IdGenerator
    {
        private static int _ItemsId=1;
        private static int _CustomersId=1;
        public static int GetNextId()
        { return _ItemsId++; }

        public static int GetNextCustomersId() 
        { return _CustomersId++; }
    }
}

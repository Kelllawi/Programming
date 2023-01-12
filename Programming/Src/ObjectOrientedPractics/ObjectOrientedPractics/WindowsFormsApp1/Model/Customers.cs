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
        /// <summary>
        /// Уникальный индефикатор
        /// </summary>
        private readonly int _customersId;
        /// <summary>
        /// Полное имя покупателя. Должно быть меньше 200 символов.
        /// </summary>
        private  string _fullName;
        /// <summary>
        /// Адрес доставки. Должно быть меньше 500 символов.
        /// </summary>
        private  string _address;

        /// <summary>
        /// Возвращает уникальный модификатор.
        /// </summary>
        public int Id
        {
            get { return _customersId; }
        }

        /// <summary>
        /// Возвращает и задаёт полное имя покупателя товара. Должно быть не больше 200 символов.
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set
            {
                Validator.AssertStringOnLength(value, 200, nameof(FullName));
                _fullName= value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес доставки товара. Должен быть не больше 500 символов.
        /// </summary>
        public string Address
        { get { return _address; } 
            set
            {
                Validator.AssertStringOnLength(value, 500, nameof(Address));
                _address= value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customers"/>.
        /// </summary>
        /// <param name="Id">Уникальный индетификатор.</param>
        /// <param name="FullName">Полное имя покупателя. Должно быть меньше 200 символов.</param>
        /// <param name="Address">Адрес доставки. Должен быть меньше 500 символов.</param>
        public Customers(int id,string FullName, string address)
        {
            _customersId= IdGenerator.GetNextCustomersId();
            FullName = _fullName;
            address = _address;

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customers"/>.
        /// </summary>
        public Customers()
        {
            _customersId= IdGenerator.GetNextCustomersId();
            FullName= "Empty";
            Address = "Empty";
        }


    }
}

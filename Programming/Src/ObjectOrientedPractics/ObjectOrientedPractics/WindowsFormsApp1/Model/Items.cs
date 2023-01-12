using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Item
    {
        /// <summary>
        /// Уникальный модификатор
        /// </summary>
        private readonly int _ItemsId;

        /// <summary>
        /// Название товара
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание товара
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара 
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает уникальный модификатор
        /// </summary>
        public int Id
        {
            get { return _ItemsId; }
        }

        /// <summary>
        /// Возвращает название товара 
        /// </summary>
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
        /// <summary>
        /// Возвращает информацию товара 
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                Validator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает стоимость товара 
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set
            {
                Validator.AssertValueInRange(value, 0, 10000, nameof(Cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>
        /// </summary>
        /// <param name="Id">Уникальный индетификатор.</param>
        /// <param name="Name">Название товара. Должно быть меньше 200 символов.</param>
        /// <param name="Info">Описание товара. Должно быть меньше 1000 символов.</param>
        /// <param name="Cost">Цена товара. Должна быть в пределах от 0 до 100 000.</param>
        public Item(int Id, string Name, string Info, double Cost)
        {
            _ItemsId = IdGenerator.GetNextId();
            Name = _name;
            Info = _info;
            Cost = _cost;

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            _ItemsId = IdGenerator.GetNextId();
            Name = "Empty";
            Info = "Empty";
            Cost = 0;
        }
    }
}

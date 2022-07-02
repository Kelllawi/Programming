﻿using System;

namespace Programming.Model.Geometryy
{
    /// <summary>
    /// Хранит Информарицю об кольце
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Внешний радиус
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Внутренний радиус
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Созадет экземпляр класса <see cref="Ring"/>
        /// </summary>
        /// <param name="center"> Координаты цента кольца</param>
        /// <param name="outerRadius"> Внешний радиус.Положительное число
        /// Должен быть больше внутреннего радиуса</param>
        /// <param name="innerRadius"> Внутренний радиус.Положительное число
        /// Долдно быть меньше внешнего радиуса</param>
        public Ring(Point2D center,
            double outerRadius,
            double innerRadius)
        {
            Center = center;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
        }

        /// <summary>
        /// Возвращает и задает координаты центра кольца
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задает внешний радиус кольца Положительное число
        /// Должен быть больше внутреннего радиуса
        /// </summary>
        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            private set
            {
                Validator.AssertOnPositiveValue(nameof(OuterRadius), value);
                Validator.AssertValueInRange(nameof(OuterRadius), value,
                    _innerRadius, double.MaxValue);
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задает внутренний радиус колько Положительно число
        /// Должно быть меньше внешнего радиуса
        /// </summary>
        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            private set
            {
                Validator.AssertOnPositiveValue(nameof(InnerRadius), value);
                Validator.AssertValueInRange(nameof(InnerRadius), value, 0, _outerRadius);
                _innerRadius = value;
            }
        }
        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * (Math.Pow(_outerRadius, 2) - Math.Pow(_innerRadius, 2));
            }
        }
    }
}
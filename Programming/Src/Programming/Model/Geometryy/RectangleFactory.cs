using Programming.Model.Enums;
using System;

namespace Programming.Model.Geometryy
{
   /// <summary>
   /// Класс создания прямоугольников
   /// </summary>
    public static class RectangleFactory
    {
        /// <summary>
        /// Отступ от краев внутри панели
        /// </summary>
        private static readonly int Margin = 15;

       /// <summary>
       /// Генератор случайных чисел
       /// </summary>
        private static readonly Random _random = new Random();

        /// <summary>
        /// Минимальный размер прямоугольника
        /// </summary>
        private const int MinSize = 10;

        /// <summary>
        /// максимальный размер прямоугольника
        /// </summary>
        private const int MaxSize = 100;

        /// <summary>
        /// Создает прямоугольник внутри панели
        /// </summary>
        /// <param name="canvasWidth">Граница создания по ширине</param>
        /// <param name="canvasHeight"> Граница создания по высоте</param>
        /// <returns> Возвращает экземпляр Rectangle со случайными значениями  </returns>
        public static Rectangle Randomize(int canvasWidth, int canvasHeight)
        {
            var rectangleHeight = _random.Next(MinSize, MaxSize);
            var rectangleWidth = _random.Next(MinSize, MaxSize);
            var rectangleX = _random.Next(Margin, canvasWidth - MaxSize - Margin);
            var rectangleY = _random.Next(Margin, canvasHeight - MaxSize - Margin);
            var rectanglePosition = new Point2D(rectangleX, rectangleY);
            var color = "Green";

            return new Rectangle(
                rectangleHeight,
                rectangleWidth,
                color,
                rectanglePosition
                );
        }

        /// <summary>
        /// Создает прямоугольник 
        /// </summary>
        /// <returns>Возвращает экземпляр Rectangle со случайными значениями</returns>
        public static Rectangle Randomize()
        {
            return Randomize(500,500);
        }
    }
}
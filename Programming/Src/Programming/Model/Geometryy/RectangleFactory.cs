using Programming.Model.Enums;
using System;

namespace Programming.Model.Geometryy
{
   
    public static class RectangleFactory
    {
        
        private static readonly int Margin = 15;

       
        private static readonly Random _random = new Random();

        private const int MinSize = 10;

        private const int MaxSize = 100;

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

        public static Rectangle Randomize()
        {
            var colors = Enum.GetValues(typeof(Colors));
            Rectangle rectangle = new Rectangle();
            rectangle.Center = new Point2D(_random.Next(1, 500), _random.Next(1, 500));
            rectangle.Width = _random.Next(30, 100);
            rectangle.Height = _random.Next(30, 100);
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            return rectangle;
        }
    }
}
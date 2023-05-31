using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Model
{
    public static class Validator
    {
        /// <summary>
        /// Проверяет, что строка состоит только из букв алфавита.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">
        /// Ошибка, когда в строке есть цифры</exception>
        public static void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            foreach (var i in value)
            {
                if (!char.IsLetter(i))
                {
                    throw new ArgumentException(
                        $"{propertyName} must consist only of letters");
                }
            }
        }

        /// <summary>
        /// Проверяет, что число лежит в диапазоне.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="min">Левая граница диапазона.</param>
        /// <param name="max">Правая граница диапазона.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">
        /// Ошибка, если число находится вне диапазона.</exception>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"{propertyName} must be in range ({min} to {max})");
            }
        }

        /// <summary>
        /// Проверяет, что число лежит в диапазоне.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="min">Левая граница диапазона.</param>
        /// <param name="max">Правая граница диапазона.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">
        /// Ошибка, если число находится вне диапазона.</exception>
        public static void AssertValueInRange(double value, double min,
                                              double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"{propertyName} must be in range ({min} to {max})");
            }
        }

    }
}

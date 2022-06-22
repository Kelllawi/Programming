namespace Programming.Model
{
    using System;
    /// <summary>
    /// Предоставляет методы проверки для входных данных
    /// </summary>
    public class Validator
    {
        /// <summary>
        /// Проверяет является ли число положительным
        /// </summary>
        /// <param name="nameProperty"> Имя свойства, откуда был вызван метод</param>
        /// <param name="value">Значение </param>
        /// <exception cref="ArgumentException">Выбрасывается если число меньше нуля</exception>
        public static void AssertOnPositiveValue(string nameProperty, int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field must be positive");
            }
        }
        /// <summary>
        /// Проверяет является ли число положительным
        /// </summary>
        /// <param name="nameProperty"> Имя свойства, откуда был вызван метод</param>
        /// <param name="value">Значение </param>
        /// <exception cref="ArgumentException">Выбрасывается если число меньше нуля</exception>
        public static void AssertOnPositiveValue(string nameProperty, double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field must be positive");
            }
        }
        /// <summary>
        /// Проверяет находится ли число в данном диапазоне
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод</param>
        /// <param name="value">Значение</param>
        /// <param name="min">левая граница диапазона</param>
        /// <param name="max">правая граница диапазона</param>
        /// <exception cref="ArgumentException">Выбрасывается если число находится вне диапазона</exception>
        public static void AssertValueInRange(string nameProperty, int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field should be between {min} and {max} (inclusive)");
            }
        }
        /// <summary>
        /// Проверяет находится ли число в данном диапазоне
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод</param>
        /// <param name="value">Значение</param>
        /// <param name="min">левая граница диапазона</param>
        /// <param name="max">правая граница диапазона</param>
        /// <exception cref="ArgumentException">Выбрасывается если число находится вне диапазона</exception>
        public static void AssertValueInRange(string nameProperty, double value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field should be between {min} and {max} (inclusive)");
            }
        }
        /// <summary>
        /// Проверяет находится ли число в данном диапазоне
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод</param>
        /// <param name="value">Значение</param>
        /// <param name="min">левая граница диапазона</param>
        /// <param name="max">правая граница диапазона</param>
        /// <exception cref="ArgumentException">Выбрасывается если число находится вне диапазона</exception>
        public static void AssertValueInRange(string nameProperty, double value, double min, double max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field should be between {min} and {max} (inclusive)");
            }
        }
        /// <summary>
        /// Проверяет состоит ли строка только из букв английского алфавита
        /// </summary>
        /// <param name="value">Строка</param>
        /// <param name="nameProperty">Имя свойства откуда был вызван метод</param>
        /// <exception cref="ArgumentException">Выбрасывается если строка состоит не только из букв английского алфавита</exception>
        public static void AssertStringContainsOnlyLetters(string value, string nameProperty)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    throw new ArgumentException(
                        $"the value of the {nameProperty} field should consist only of English letters.");
                }
            }
        }
    }

}
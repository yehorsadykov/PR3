using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання._Варіант_7
{
    internal class TCircle
    {
        private double radius; // поле для зберігання радіуса

        // Конструктор без параметрів
        public TCircle()
        {
            radius = 1.0; // значення за замовчуванням
        }

        // Конструктор з параметрами
        public TCircle(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentException("Радіус повинен бути позитивним числом.");
            }
            radius = r;
        }

        // Конструктор копіювання
        public TCircle(TCircle circle)
        {
            radius = circle.radius;
        }

        // Метод для введення даних
        public void InputData()
        {
            Console.Write("Введіть радіус кола: ");
            radius = double.Parse(Console.ReadLine());
            if (radius <= 0)
            {
                throw new ArgumentException("Радіус повинен бути позитивним числом.");
            }
        }

        // Метод для виведення даних
        public void DisplayData()
        {
            Console.WriteLine($"Радіус кола: {radius}");
            Console.WriteLine($"Площа кола: {Area()}");
            Console.WriteLine($"Довжина кола: {Circumference()}");
        }

        // Визначення площі кола
        public double Area()
        {
            return Math.PI * radius * radius; // формула для площі кола
        }

        // Визначення площі сектора (в радіанах)
        public double SectorArea(double angleInRadians)
        {
            return 0.5 * radius * radius * angleInRadians; // формула для площі сектора
        }

        // Визначення довжини кола
        public double Circumference()
        {
            return 2 * Math.PI * radius; // формула для довжини кола
        }

        // Порівняння з іншим колом
        public int CompareTo(TCircle other)
        {
            return radius.CompareTo(other.radius); // порівняння радіусів
        }

        // Перевантаження операторів
        public static TCircle operator +(TCircle a, TCircle b)
        {
            return new TCircle(a.radius + b.radius); // додавання радіусів
        }

        public static TCircle operator -(TCircle a, TCircle b)
        {
            return new TCircle(Math.Max(a.radius - b.radius, 0)); // віднімання радіусів
        }

        public static TCircle operator *(TCircle a, double multiplier)
        {
            return new TCircle(a.radius * multiplier); // множення радіуса на число
        }
    }
}
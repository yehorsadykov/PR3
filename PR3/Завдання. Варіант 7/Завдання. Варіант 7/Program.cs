using Завдання._Варіант_7;

class Program
{
    static void Main(string[] args)
    {
        // Створення кола за замовчуванням
        TCircle circle1 = new TCircle();
        circle1.DisplayData();

        // Введення радіусу для другого кола
        TCircle circle2 = new TCircle();
        circle2.InputData();
        circle2.DisplayData();

        // Додавання радіусів двох кіл
        TCircle circle3 = circle1 + circle2;
        Console.WriteLine("Результат додавання радіусів:");
        circle3.DisplayData();

        // Віднімання радіусів двох кіл
        TCircle circle4 = circle1 - circle2;
        Console.WriteLine("Результат віднімання радіусів:");
        circle4.DisplayData();

        // Множення радіусу першого кола на число
        Console.Write("Введіть число для множення радіусу першого кола: ");
        double multiplier = double.Parse(Console.ReadLine());
        TCircle circle5 = circle1 * multiplier;
        Console.WriteLine("Результат множення радіусу:");
        circle5.DisplayData();

        // Порівняння двох кіл
        int comparison = circle1.CompareTo(circle2);
        if (comparison > 0)
        {
            Console.WriteLine("Перше коло більше другого.");
        }
        else if (comparison < 0)
        {
            Console.WriteLine("Друге коло більше першого.");
        }
        else
        {
            Console.WriteLine("Обидва кола однакові.");
        }
    }
}
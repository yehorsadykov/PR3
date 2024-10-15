using System;

internal class Arrays
{
    public bool error = false; // помилка
    int[] a; // масив
    int length; // довжина масиву

    public Arrays(int size) // створення конструктора
    {
        a = new int[size]; // ініціалізація масиву
        length = size; // збереження довжини
    }

    public int Length
    {
        get
        {
            return length; // повернення довжини масиву
        }
    }

    public static Arrays generateRandomArray(Arrays array)
    {
        Random rand = new Random(); // генератор випадкових чисел
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(0, 100); // заповнення масиву випадковими значеннями
        }
        return array; // повернення масиву
    }

    public static Arrays operator *(Arrays arrays, int mul) // перевантаження оператора множення
    {
        Arrays resArray = new Arrays(arrays.Length); // створення нового масиву
        for (int i = 0; i < resArray.Length; i++)
        {
            resArray[i] = arrays[i] * mul; // множення елементів масиву
        }
        return resArray; // повернення нового масиву
    }

    public int this[int i] // індексатор
    {
        get
        {
            if (i >= 0 && i < length) return a[i]; // повернення елемента за індексом
            else error = true; return 0; // помилка при некоректному індексі
        }

        set
        {
            if (i >= 0 && i < length && value >= -100 && value <= 10000) a[i] = value; // встановлення значення
            else error = true; // помилка при некоректному значенні
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть розмір масиву: "); // запит на розмір масиву
        int size = int.Parse(Console.ReadLine()); // зчитування розміру

        Arrays myArray = new Arrays(size); // створення масиву
        myArray = Arrays.generateRandomArray(myArray); // генерація випадкового масиву

        Console.WriteLine("Сгенерований масив:"); // повідомлення про згенерований масив
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i] + " "); // виведення елементів масиву
        }
        Console.WriteLine(); // перехід на новий рядок

        Console.Write("Введіть число для множення елементів масиву: "); // запит на множник
        int multiplier = int.Parse(Console.ReadLine()); // зчитування множника

        Arrays multipliedArray = myArray * multiplier; // множення масиву на число

        Console.WriteLine("Масив після множення на " + multiplier + ":"); // повідомлення про результат
        for (int i = 0; i < multipliedArray.Length; i++)
        {
            Console.Write(multipliedArray[i] + " "); // виведення елементів нового масиву
        }
        Console.WriteLine(); // перехід на новий рядок
    }
}
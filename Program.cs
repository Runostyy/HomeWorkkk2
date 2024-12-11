using System;

class Program
{
    static void Main()
    {
        int[] intArray = { 1, 2, 3, 4, 5 };
        double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };

        // Для цілочисельного масиву
        (int minInt, int maxInt) = FindMinMax(intArray);
        Console.WriteLine($"Integer Array: Min = {minInt}, Max = {maxInt}");

        // Для масиву дійсних чисел
        (double minDouble, double maxDouble) = FindMinMax(doubleArray);
        Console.WriteLine($"Double Array: Min = {minDouble}, Max = {maxDouble}");
    }

    // Універсальний метод для пошуку мінімального та максимального елементів
    static (T min, T max) FindMinMax<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty");
        }

        T min = array[0];
        T max = array[0];

        foreach (T item in array)
        {
            if (item.CompareTo(min) < 0) min = item;
            if (item.CompareTo(max) > 0) max = item;
        }

        return (min, max);
    }
}

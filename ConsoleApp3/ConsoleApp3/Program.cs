using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите два целых числа:");
        Console.Write("Первое число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Второе число: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        int maxNumber = Math.Max(number1, number2);
        Console.WriteLine($"Максимальное число: {maxNumber}");
        Console.ReadKey();
    }
}
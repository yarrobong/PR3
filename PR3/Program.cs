using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число: ");
        string inputString = Console.ReadLine();

        int number;
        if (int.TryParse(inputString, out number))
        {
            Console.WriteLine($"The next number for the number {number} is {number + 1}.");
            Console.WriteLine($"The previous number for the number {number} is {number - 1}.");
        }
        else
        {
            Console.WriteLine("Это не число");
        }
    }
}

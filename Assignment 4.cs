using System;

class Program
{
    static void Main()
    {
        int num;

        do
        {
            Console.Write("Enter a number between 2 and 9: ");
            num = Convert.ToInt32(Console.ReadLine());
        } while (num < 2 || num > 9);

        Console.WriteLine($"Multiplication table for {num}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} * {i} = {num * i}");
        }
    }
}

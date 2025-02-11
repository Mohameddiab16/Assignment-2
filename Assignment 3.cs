using System;

class Program
{
    static void Main()
    {
        int sum = 0;

        while (sum <= 100)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            sum += num;
        }

        Console.WriteLine($"Your sum ({sum}) exceeds 100 now");
    }
}

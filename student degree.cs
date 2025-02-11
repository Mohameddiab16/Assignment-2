using System;

class Program
{
    static void Main()
    {
        // Input student grade
        Console.Write("Enter student grade (A-E): ");
        char grade = Convert.ToChar(Console.ReadLine().ToUpper());

        // Determine the corresponding description
        string result;

        switch (grade)
        {
            case 'A':
                result = "Excellent";
                break;
            case 'B':
                result = "Very Good";
                break;
            case 'C':
                result = "Good";
                break;
            case 'D':
                result = "Fair";
                break;
            case 'E':
                result = "Failed";
                break;
            default:
                result = "No match";
                break;
        }

        // Output the result
        Console.WriteLine(result);
    }
}

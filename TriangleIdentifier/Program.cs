using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the lengths of the three sides of a triangle:");

        Console.Write("Side 1: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Side 2: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Side 3: ");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a == b && b == c)
            Console.WriteLine("Triangle Type: Equilateral");
        else if (a == b || b == c || a == c)
            Console.WriteLine("Triangle Type: Isosceles");
        else
            Console.WriteLine("Triangle Type: Scalene");
    }
}

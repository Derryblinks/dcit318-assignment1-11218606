﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        int ticketPrice = (age <= 12 || age >= 65) ? 7 : 10;

        Console.WriteLine($"Ticket Price: GHC{ticketPrice}");
    }
}

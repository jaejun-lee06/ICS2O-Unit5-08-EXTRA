// Created by: Marshall Demars
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function does division
        int integer1;
        int integer2;
        int remainder;
        int total = 0;

        // input
        Console.WriteLine("Division, with CSharp");

        Console.WriteLine("");
        Console.Write("Please enter the first integer: ");
        integer1 = Convert.ToInt32(Console.ReadLine());
        remainder = integer1;

        Console.WriteLine("");
        Console.Write("Please enter the second integer: ");
        integer2 = Convert.ToInt32(Console.ReadLine());

        // process
        if ((integer1 > 0) && (integer2 > 0))
        {
            while (remainder >= integer2)
            {
                remainder = remainder - integer2;
                total++;
            }
        }
        else if ((integer1 < 0) && (integer2 < 0))
        {
            remainder = Math.Abs(remainder);
            integer2 = Math.Abs(integer2);
            while (remainder >= integer2)
            {
                remainder = remainder - integer2;
                total++;
            }

            integer2 = -Math.Abs(integer2);
        }
        else
        {
            remainder = Math.Abs(remainder);
            integer2 = Math.Abs(integer2);
            while (remainder >= integer2)
            {
                remainder = remainder - integer2;
                total++;
            }

            total = -Math.Abs(total);
        }

        Console.WriteLine("");
        Console.WriteLine(integer1 + " ÷ " + integer2 + " = " + total + " R " + remainder);
        Console.WriteLine("\nDone.");
    }
}
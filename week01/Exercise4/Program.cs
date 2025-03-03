using System;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int typed = -1;
        List<int>numbers = new List<int>();
        int total = 0;
        int max = 0;

        while (typed != 0){
            Console.Write("Enter number ");
            typed = int.Parse(Console.ReadLine());

            if (typed != 0){
            numbers.Add(typed);
            }
        }

        foreach (int numberlist in numbers){
            total = total + numberlist;
        }

        Console.WriteLine($"The sum is: {total}");

        float avg = ((float)total)/numbers.Count;
        Console.WriteLine($"The avg is: {avg}");

        foreach (int number in numbers){
            if (number > max){
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("What is your grade percentage?");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90) {

            letter = "A";
        }
        else if (percent >= 80){
            letter = "B";
        }

        else if (percent >= 70){
            letter = "C";
        }
        else if (percent >= 60){
            letter = "D";
        }
        else{
            letter = "F";
        }

        Console.WriteLine($"Your letter is {letter}");

        if (percent >= 70){
            Console.WriteLine("You did it!");
        }
        else{
            Console.WriteLine("Sorry.. not this time");
        }
}
}
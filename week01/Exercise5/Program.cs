using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int numberSquare = squareNumber(userNumber);

        DisplayResult(userName, numberSquare);


    }

            static void DisplayWelcome(){
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName(){
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber(){
            Console.WriteLine("What's your favorite number?");
            string number = Console.ReadLine();
            int favNumber = int.Parse(number);
            
            return favNumber;
        }

        static int squareNumber(int number){
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int square){
            Console.WriteLine($"Hi {name}! Your square number is {square}");
        }
}
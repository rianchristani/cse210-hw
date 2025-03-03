using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // Console.WriteLine("What is the magic number?");
        // string magic = Console.ReadLine();
        // int magicNumber = int.Parse(magic);
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int guessNumber = -1;

        while (guessNumber != magicNumber){

            Console.WriteLine("What is your guess?");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber > magicNumber){
                Console.WriteLine("Lower");
                
            }
            else if (guessNumber < magicNumber){
                Console.WriteLine("Higher");
            }
            else if (guessNumber == magicNumber){
                Console.WriteLine("You guessed it!");
            }

        }
    }
}
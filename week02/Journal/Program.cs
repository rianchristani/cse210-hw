using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Please select one of the following choices:");
        int choice = 1;

        Journal journal = new Journal();

        while (choice != 5){
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do?");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1){
                Entry entry = new Entry();
                Console.WriteLine(entry._promptText);
                entry._entryText = Console.ReadLine();
                journal.AddEntry(entry);
            }

            else if (choice == 2){
                journal.DisplayAll();
            }

            else if (choice == 3){
                Console.WriteLine("What is the filename? ");

                journal.LoadFromFile(Console.ReadLine());
            }

            else if (choice == 4){
                Console.WriteLine("What is the filename? "); 

                journal.SaveToFile(Console.ReadLine());
            }

            else{
                Console.WriteLine("PUT A VALID BRO!");
            }
        }
    }
}
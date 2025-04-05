using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        int answer = 0;
        while (answer != 4){
            Console.Clear();

            Console.WriteLine("Menu Options:\nPlease select from the following activities:");
            Console.WriteLine("    1. Breathing\n    2. Reflection\n    3. Listing\n    4. Quit");
            Console.Write("Select a choice from the menu: ");
            answer = int.Parse(Console.ReadLine());

            if (answer == 1){
                BreathingActivity breathing  = new BreathingActivity();
                breathing.Run();
            }
            else if (answer == 2){
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            else if (answer == 3){
                ListiningActivity listining = new ListiningActivity();
                listining.Run();
            }
            else if (answer == 4){
                Console.WriteLine("\nBye bye!");
                break;
            }
            else{
                Console.WriteLine("\nSorry, wrong wrong/caracther. Please run again");
            }
        }
    }
}




using System.IO.Compression;
using System.Runtime.InteropServices.Marshalling;

public class Activity{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(){
        _name = "";
        _description = "";
        _duration = 0;   
    }

    public void DisplayStartingMessage(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);

        Console.Write("\nHow long, in seconds, would you like for your sesstion? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGet ready...\n");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage(){
        Console.WriteLine("\nWell Done!!\n");
        ShowSpinner(2);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds){
        List<string>animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        DateTime currentDate = DateTime.Now;
        DateTime futureDate = currentDate.AddSeconds(seconds);

        int i = 0;
        
        while (DateTime.Now < futureDate){
            Console.Write(animation[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i ++;

            if (i >= animation.Count){
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds){
        DateTime currentDate = DateTime.Now;
        DateTime futureDate = currentDate.AddSeconds(seconds);

        while (DateTime.Now < futureDate){
            for (int index = seconds; index > 0; index --){
                Console.Write(index);
                Thread.Sleep(1000);

            if (seconds >= 10){
            Console.Write("\b\b   \b\b");
            }
            else {
            Console.Write("\b \b");
            }
            }
        }
    }
}
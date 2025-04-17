using System;

class Program
{
    static void Main(string[] args)
    {
        
        Running run1 = new Running(5, 30);
        Running run2 = new Running(8, 45);
        Running run3 = new Running(12, 60);
        Running run4 = new Running(15, 75);
        Running run5 = new Running(20, 90);

        
        StationaryBicycles bike1 = new StationaryBicycles(10, 60);
        StationaryBicycles bike2 = new StationaryBicycles(20, 90);
        StationaryBicycles bike3 = new StationaryBicycles(25, 120);
        StationaryBicycles bike4 = new StationaryBicycles(30, 150);
        StationaryBicycles bike5 = new StationaryBicycles(40, 180);

        
        Swimming swim1 = new Swimming(10, 15);
        Swimming swim2 = new Swimming(15, 20);
        Swimming swim3 = new Swimming(20, 30);
        Swimming swim4 = new Swimming(25, 40);
        Swimming swim5 = new Swimming(30, 50);

        List<Activity>activity = new List<Activity>();
        activity.Add(run1);
        activity.Add(run2);
        activity.Add(run3);
        activity.Add(run4);
        activity.Add(run5);

        activity.Add(bike1);
        activity.Add(bike2);
        activity.Add(bike3);
        activity.Add(bike4);
        activity.Add(bike5);

        activity.Add(swim1);
        activity.Add(swim2);
        activity.Add(swim3);
        activity.Add(swim4);
        activity.Add(swim5);

        foreach (Activity activities in activity){
            Console.WriteLine(activities.GetSummary());
        }
    }
}
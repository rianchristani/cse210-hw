using System.ComponentModel.Design;
using System.Formats.Asn1;
using System.IO.Enumeration;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

public class GoalManager{
    private List<Goal>_goals = new List<Goal>();
    private int _score;

    public GoalManager(){
        _score = 0;
    }

    public void Start(){
        Clear();
        int answer = 0;

        while(answer !=6){
            Clear();
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options");
            Console.WriteLine("   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit");
            Console.Write("Select a choice from the menu: ");
            answer = int.Parse(Console.ReadLine());

            if (answer == 1){
                CreateGoal();
            }
            else if (answer == 2){
                ListGoalDetails();
            }

            else if (answer == 3){
                SaveGoals();
            }

            else if (answer == 4){
                LoadGoals();
            }

            else if (answer == 5){
                RecordEvent();
            }

            else if (answer == 6){
                Clear();
                Console.WriteLine("Bye bye user!");
                break;
            }
            
        }
    }

    public void DisplayPlayerInfo(){
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames(){
        int counter = 0;
        foreach(Goal goal in _goals){
            counter ++;
            Console.WriteLine($"{counter}. {goal.GetName()}");
        }
    }

    public void ListGoalDetails(){
        Clear();
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        EnterLoop();
    }

    public void CreateGoal()
    {
        Clear();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("   1. Simple Goal\n   2. Eternal Goal\n   3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int answer = int.Parse(Console.ReadLine());
        Clear();
        if (answer == 1){
            Console.WriteLine("You choose: Simple Goal");
        }
        else if (answer == 2){
            Console.WriteLine("You choose: Eternal Goal");
        }
        else if (answer == 3){
            Console.WriteLine("You choose: Checklist Goal");
        }
        else{
            Console.WriteLine("Sorry, ivalid answer. Please try again");
            CreateGoal();
        }

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (answer == 1)
        {
            SimpleGoal simple = new SimpleGoal(name, description, points);
            _goals.Add(simple);
        }
        else if (answer == 2)
        {
            EternalGoal eternal = new EternalGoal(name, description, points);
            _goals.Add(eternal);
        }
        else if (answer == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklist = new ChecklistGoal(name, description, points, bonus, target);
            _goals.Add(checklist);
        }
    }

    public void RecordEvent(){
        Clear();
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int answer = int.Parse(Console.ReadLine());
        Clear();
        if (answer > 0 && answer <= _goals.Count)
        {
            Goal selectedGoal = _goals[answer - 1];
            selectedGoal.RecordEvent();
            _score += selectedGoal.GetPoints();

            Console.WriteLine($"Congratulations! You have earned {selectedGoal.GetPoints()} points.");
            Console.WriteLine($"You now have {_score} points.");

            EnterLoop();
        }
        }

    public void SaveGoals(){
        Clear();
        Console.WriteLine("What is going to be the name of the file? ");
        string saveFilename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter ($"{saveFilename}.csv", false))
            {
                outputFile.WriteLine(_score);
                foreach (Goal goal in _goals){
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
    }

    public void LoadGoals(){
        Clear();
        Console.WriteLine("What is the name of the file? ");
        string loadFilename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines($"{loadFilename}.csv");

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++){

            string line = lines[i];
            string[] parts = line.Split(",");

            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (goalType == "SimpleGoal"){
                SimpleGoal simple = new SimpleGoal(name, description, points);
                _goals.Add(simple);
            }

            if (goalType == "EternalGoal"){
                EternalGoal eternal = new EternalGoal(name, description, points);
                _goals.Add(eternal);
            }

            if (goalType == "ChecklistGoal"){
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int completed = int.Parse(parts[6]);

                ChecklistGoal check = new ChecklistGoal(name, description, points, bonus, target);
                check.SetCompletedCount(completed);
                _goals.Add(check);
            }
        }      
        }

            public void Clear(){
            Console.Clear();
        }  

        public void EnterLoop(){
            string continuee = "a";
            while (continuee != ""){
                Console.WriteLine("\nPlease hit 'enter' to continue...");
                continuee = Console.ReadLine();
            }
        }
}
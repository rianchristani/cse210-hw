public class EternalGoal : Goal{
    public EternalGoal(string name, string description, int points) : base(name, description, points){
        // Console.WriteLine("What is the name of your goal? ");
        // name = Console.ReadLine();

        // Console.WriteLine("What is a short descrpition of it? ");
        // description = Console.ReadLine();
        
        // Console.WriteLine("What is the amount of points associated with this goal? ");
        // points = int.Parse(Console.ReadLine());
    }

    public override void RecordEvent(){
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{_shortName},{_description},{_points}";
    }
}

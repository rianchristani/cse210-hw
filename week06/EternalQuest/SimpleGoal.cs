using System.Drawing;

public class SimpleGoal : Goal{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points){
        // Console.WriteLine("What is the name of your goal? ");
        // name = Console.ReadLine();

        // Console.WriteLine("What is a short descrpition of it? ");
        // description = Console.ReadLine();
        
        // Console.WriteLine("What is the amount of points associated with this goal? ");
        // points = int.Parse(Console.ReadLine());

        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal,{_shortName},{_description},{_points},{_isComplete}";
    }
}

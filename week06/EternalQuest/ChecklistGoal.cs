public class ChecklistGoal : Goal{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int bonus, int target) : base(name, description, points){
        _bonus = bonus;
        _target = target;
        _amountCompleted = 0;

        // Console.WriteLine("What is the name of your goal? ");
        // name = Console.ReadLine();

        // Console.WriteLine("What is a short descrpition of it? ");
        // description = Console.ReadLine();

        // Console.WriteLine("What is the amount of points associated with this goal? ");
        // points = int.Parse(Console.ReadLine());

        // Console.WriteLine("How many times does this goal need to be accomplished for a bonus");
        // target = int.Parse(Console.ReadLine());

        // Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        // bonus = int.Parse(Console.ReadLine());
    }

    public override void RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted == _target){
            _points = _bonus + _points;
            Console.WriteLine($"You win a bonus of {_bonus}!!!\n");
        }

    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetDetailsString()
    {
        string isOrNotCompleted = "";

        if (IsComplete() == true){
            isOrNotCompleted = $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else{
            isOrNotCompleted= $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }

        return isOrNotCompleted;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }

        public void SetCompletedCount(int completed)
    {
        _amountCompleted = completed; // Define o progresso carregado do arquivo
    }
}
public abstract class Goal{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points){
        _shortName = name;
        _description = description;
        _points	= points;
    }
    
    public string GetName(){
        return _shortName;
    }

    public  int GetPoints(){
        return _points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString(){
        string isOrNotCompleted = "";

        if (IsComplete() == true){
            isOrNotCompleted = $"[X] {_shortName} ({_description})";
        }
        else{
            isOrNotCompleted= $"[ ] {_shortName} ({_description})";
        }

        return isOrNotCompleted;
    }  
    
    public abstract string GetStringRepresentation();
}
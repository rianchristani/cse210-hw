using System.Runtime.CompilerServices;

public class Running : Activity{
    private double _distance;
    public Running(double distance, double minutes) : base(minutes){
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

}

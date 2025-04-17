public class Swimming : Activity{
    private double _laps;

    public Swimming(double laps, double minutes) : base (minutes){
        _laps = laps;
    }
    public override double Distance()
    {
        return _laps * 50 / 1000;
    }

}
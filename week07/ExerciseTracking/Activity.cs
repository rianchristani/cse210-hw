public abstract class Activity{
    protected double _minutes;
    protected string _date;

    public Activity(double minutes){
        _minutes = minutes;
        DateTime dateTime = DateTime.Now;
        _date = dateTime.ToString("dd MMM yyyy");
    }

    public abstract double Distance();


    public double SpeedAvg(double distance, double minutes){
        double speedAvg = distance/minutes * 60;
        return speedAvg;
    }

    public double PaceAvg(double distance, double minutes){
        double paceAvg = minutes / distance;
        return paceAvg;
    }

    public double Speed(double pace){
        double speed = 60 / pace;
        return  Math.Round(speed, 2);
    }

    public double Pace(double speed){
        double pace = 60 / speed;
        return Math.Round(pace, 2);
    }

    public string GetSummary()
    {
        double paceValue = Math.Round(PaceAvg(Distance(), _minutes), 2);
        double speedValue = Math.Round(SpeedAvg(Distance(), _minutes), 2);
        return $"• {_date} Running ({_minutes} min) - Distance {Distance()} km, Speed {Speed(speedValue)} kph, Pace {Pace(paceValue)} min per km";
    }
}

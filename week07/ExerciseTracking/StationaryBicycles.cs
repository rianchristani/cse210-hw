public class StationaryBicycles : Activity{
        private double _distance;
        public StationaryBicycles(double distance, double minutes) : base(minutes){
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

}

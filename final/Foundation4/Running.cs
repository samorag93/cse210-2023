using System;

public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return Math.Round(_distance / GetDuration() * 60, 1);
    }

    public override double GetPace()
    {
        return Math.Round(GetDuration() / _distance, 1);
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running (Distance: {_distance} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min/km)";
    }
}

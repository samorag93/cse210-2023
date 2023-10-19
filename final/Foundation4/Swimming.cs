using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return Math.Round(_laps * 50.0 / 1000, 1);
    }

    public override double GetSpeed()
    {
        return Math.Round(GetDistance() / GetDuration() * 60, 1);
    }

    public override double GetPace()
    {
        return Math.Round(GetDuration() / GetDistance(), 1);
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming (Laps: {_laps}, Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min/km)";
    }
}

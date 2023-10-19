using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return Math.Round(_speed, 1);
    }

    public override double GetPace()
    {
        return Math.Round(60 / _speed, 1);
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Cycling (Speed: {_speed} km/h, Pace: {GetPace()} min/km)";
    }
}

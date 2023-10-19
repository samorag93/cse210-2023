public class Conference : Event
{
    private string _speakerName;
    private int _capacity;

    public Conference(string title, string description, DateTime date, string time, Address address, string speakerName, int capacity, string eventType)
        : base(title, description, date, time, address, eventType)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nEvent Type: Conference\nSpeaker: {_speakerName}\nCapacity: {_capacity}";
    }
}

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail, string eventType)
        : base(title, description, date, time, address, eventType)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nEvent Type: Reception\nRSVP Email: {_rsvpEmail}";
    }
}

public class OutdoorMeeting : Event
{
    private string _weatherForecast;

    public OutdoorMeeting(string title, string description, DateTime date, string time, Address address, string weatherForecast, string eventType)
        : base(title, description, date, time, address, eventType)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nEvent Type: Outdoor Meeting\nWeather Forecast: {_weatherForecast}";
    }
}

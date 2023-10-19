class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Oak Ave", "Sometown", "NY", "USA");
        Address address3 = new Address("789 Pine Rd", "OtherTown", "ON", "Canada");

        Event event1 = new Conference("Tech Conference", "A conference about new technologies", new DateTime(2023, 10, 20), "10:00 AM", address1, "King Benjamin", 100, "Conference");
        Event event2 = new Reception("Networking Reception", "An evening of networking and socializing", new DateTime(2023, 11, 15), "6:00 PM", address2, "moronyag90@gmail.com", "Reception");
        Event event3 = new OutdoorMeeting("Community Picnic", "A community gathering for a picnic", new DateTime(2023, 12, 10), "12:00 PM", address3, "Sunny", "Outdoor Meeting");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(event1.GetStandardDetails());
        Console.WriteLine(event2.GetStandardDetails());
        Console.WriteLine(event3.GetStandardDetails());

        Console.WriteLine("\nFull Details:");
        Console.WriteLine(event1.GetFullDetails());
        Console.WriteLine(event2.GetFullDetails());
        Console.WriteLine(event3.GetFullDetails());

        Console.WriteLine("\nBrief Descriptions:");
        Console.WriteLine(event1.GetBriefDescription());
        Console.WriteLine(event2.GetBriefDescription());
        Console.WriteLine(event3.GetBriefDescription());
    }
}

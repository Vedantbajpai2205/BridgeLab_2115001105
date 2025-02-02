using System;

class HotelBooking
{
    public string GuestName { get; set; }
    public string RoomType { get; set; }
    public int Nights { get; set; }

    public HotelBooking()
    {
        GuestName = "Unknown";
        RoomType = "Standard";
        Nights = 1;
    }

    public HotelBooking(string guestName, string roomType, int nights)
    {
        GuestName = guestName;
        RoomType = roomType;
        Nights = nights;
    }

    public HotelBooking(HotelBooking other)
    {
        GuestName = other.GuestName;
        RoomType = other.RoomType;
        Nights = other.Nights;
    }

    public void DisplayBooking()
    {
        Console.WriteLine("Guest: " + GuestName);
        Console.WriteLine("Room Type: " + RoomType);
        Console.WriteLine("Nights: " + Nights);
    }
}

class HotelBook
{
    static void Main()
    {
        HotelBooking booking1 = new HotelBooking();
        Console.WriteLine("Booking 1 (Default Constructor):");
        booking1.DisplayBooking();

        Console.WriteLine();

        HotelBooking booking2 = new HotelBooking("John Doe", "Suite", 5);
        Console.WriteLine("Booking 2 (Parameterized Constructor):");
        booking2.DisplayBooking();

        Console.WriteLine();

        HotelBooking booking3 = new HotelBooking(booking2);
        Console.WriteLine("Booking 3 (Copy Constructor):");
        booking3.DisplayBooking();
    }
}

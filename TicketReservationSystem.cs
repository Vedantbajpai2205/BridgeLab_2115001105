using System;

class Ticket
{
    public int TicketID;
    public string CustomerName;
    public string MovieName;
    public string SeatNumber;
    public DateTime BookingTime;
    public Ticket Next;

    public Ticket(int ticketID, string customerName, string movieName, string seatNumber, DateTime bookingTime)
    {
        TicketID = ticketID;
        CustomerName = customerName;
        MovieName = movieName;
        SeatNumber = seatNumber;
        BookingTime = bookingTime;
        Next = null;
    }
}

class TicketReservationSystem
{
    private Ticket head;
    private Ticket tail;

    public TicketReservationSystem()
    {
        head = null;
        tail = null;
    }

    public void AddTicketReservation(int ticketID, string customerName, string movieName, string seatNumber)
    {
        Ticket newTicket = new Ticket(ticketID, customerName, movieName, seatNumber, DateTime.Now);

        if (head == null)
        {
            head = newTicket;
            tail = newTicket;
            newTicket.Next = head;  
        }
        else
        {
            tail.Next = newTicket;
            tail = newTicket;
            tail.Next = head;  
        }
        Console.WriteLine("Ticket booked successfully: " + newTicket.TicketID);
    }

    public void RemoveTicket(int ticketID)
    {
        if (head == null)
        {
            Console.WriteLine("No tickets to remove.");
            return;
        }

        Ticket temp = head;
        Ticket prev = null;
        
        if (head.TicketID == ticketID)
        {
            if (head == tail)  
            {
                head = null;
                tail = null;
            }
            else
            {
                tail.Next = head.Next;
                head = head.Next;
            }
            Console.WriteLine("Ticket " + ticketID + " removed successfully.");
            return;
        }

        do
        {
            prev = temp;
            temp = temp.Next;
            if (temp.TicketID == ticketID)
            {
                prev.Next = temp.Next;
                if (temp == tail)  
                {
                    tail = prev;
                }
                Console.WriteLine("Ticket " + ticketID + " removed successfully.");
                return;
            }
        } while (temp != head);

        Console.WriteLine("Ticket with ID " + ticketID + " not found.");
    }

    public void DisplayTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }

        Ticket temp = head;
        do
        {
            Console.WriteLine("Ticket ID: " + temp.TicketID);
            Console.WriteLine("Customer: " + temp.CustomerName);
            Console.WriteLine("Movie: " + temp.MovieName);
            Console.WriteLine("Seat Number: " + temp.SeatNumber);
            Console.WriteLine("Booking Time: " + temp.BookingTime);
            Console.WriteLine("----------------------------");
            temp = temp.Next;
        } while (temp != head);
    }

    public void SearchTicket(string customerName = "", string movieName = "")
    {
        if (head == null)
        {
            Console.WriteLine("No tickets available.");
            return;
        }

        Ticket temp = head;
        bool found = false;
        
        do
        {
            if ((customerName != "" && temp.CustomerName == customerName) || (movieName != "" && temp.MovieName == movieName))
            {
                Console.WriteLine("Ticket ID: " + temp.TicketID);
                Console.WriteLine("Customer: " + temp.CustomerName);
                Console.WriteLine("Movie: " + temp.MovieName);
                Console.WriteLine("Seat Number: " + temp.SeatNumber);
                Console.WriteLine("Booking Time: " + temp.BookingTime);
                Console.WriteLine("----------------------------");
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found)
        {
            Console.WriteLine("No tickets found with the given criteria.");
        }
    }

    public int GetTotalBookedTickets()
    {
        if (head == null)
        {
            return 0;
        }

        int count = 0;
        Ticket temp = head;
        do
        {
            count++;
            temp = temp.Next;
        } while (temp != head);

        return count;
    }
    static void Main(string[] args)
    {
        TicketReservationSystem system = new TicketReservationSystem();

        system.AddTicketReservation(1, "Yash", "Bahubali", "A1");
        system.AddTicketReservation(2, "Vedant", "Pushpa", "B2");
        system.AddTicketReservation(3, "Raghav", "Stranger Things", "C3");
        system.AddTicketReservation(4, "Rajat", "Raid", "A2");
        system.AddTicketReservation(5, "Thor", "Avenger", "B1");

        Console.WriteLine("All Tickets:");
        system.DisplayTickets();

        Console.WriteLine("Search by Customer Name Yash:");
        system.SearchTicket(customerName: "Bob");

        Console.WriteLine("Search by Movie Name Pushpa:");
        system.SearchTicket(movieName: "Pushpa");

        Console.WriteLine("Total Booked Tickets: " + system.GetTotalBookedTickets());

        Console.WriteLine("Remove Ticket by ID (3):");
        system.RemoveTicket(3);

        Console.WriteLine("All Tickets after Removal:");
        system.DisplayTickets();

        Console.WriteLine("Total Booked Tickets: " + system.GetTotalBookedTickets());
    }
}

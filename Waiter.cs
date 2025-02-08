using System;

public interface IWorker
{
    void PerformDuties();
}

public class Person
{
    public string Name { get; set; }
    public int Id { get; set; }

    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }
}

public class Chef : Person, IWorker
{
    public string Specialization { get; set; }

    public Chef(string name, int id, string specialization)
        : base(name, id)
    {
        Specialization = specialization;
    }

    public void PerformDuties()
    {
        Console.WriteLine(Name + " (Chef) is preparing meals with specialization in " + Specialization + ".");
    }
}

public class Waiter : Person, IWorker
{
    public string Section { get; set; }

    public Waiter(string name, int id, string section)
        : base(name, id)
    {
        Section = section;
    }

    public void PerformDuties()
    {
        Console.WriteLine(Name + " (Waiter) is serving customers in the " + Section + " section.");
    }
    public static void Main(string[] args)
    {
        Chef chef = new Chef("Yash", 1, "Italian Cuisine");
        Waiter waiter = new Waiter("Vedant", 2, "North Wing");

        Console.WriteLine("Chef Duties:");
        chef.PerformDuties();
        Console.WriteLine();

        Console.WriteLine("Waiter Duties:");
        waiter.PerformDuties();
    }
}

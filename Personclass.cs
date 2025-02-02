using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person()
    {
        Name = "Unknown";
        Age = 0;
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public Person(Person other)
    {
        Name = other.Name;
        Age = other.Age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name + " , Age: " + Age);
    }
}

class Personclass
{
    static void Main()
    {
        Person person1 = new Person("Alice", 30);
        person1.DisplayInfo();

        Console.WriteLine();

        Person person2 = new Person(person1);
        person2.DisplayInfo();
    }
}

using System;

class Student
{
    public int RollNumber;
    public string Name;
    public int Age;
    public string Grade;
    public Student Next;
}

class StudentRecordManager
{
    Student head;

    public void AddAtBeginning(int rollNumber, string name, int age, string grade)
    {
        Student newStudent = new Student();
        newStudent.RollNumber = rollNumber;
        newStudent.Name = name;
        newStudent.Age = age;
        newStudent.Grade = grade;
        newStudent.Next = head;
        head = newStudent;
    }

    public void AddAtEnd(int rollNumber, string name, int age, string grade)
    {
        Student newStudent = new Student();
        newStudent.RollNumber = rollNumber;
        newStudent.Name = name;
        newStudent.Age = age;
        newStudent.Grade = grade;
        if (head == null)
        {
            head = newStudent;
        }
        else
        {
            Student temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newStudent;
        }
    }

    public void AddAtPosition(int rollNumber, string name, int age, string grade, int position)
    {
        Student newStudent = new Student();
        newStudent.RollNumber = rollNumber;
        newStudent.Name = name;
        newStudent.Age = age;
        newStudent.Grade = grade;
        if (position == 0)
        {
            newStudent.Next = head;
            head = newStudent;
            return;
        }
        Student temp = head;
        for (int i = 0; i < position - 1 && temp != null; i++)
        {
            temp = temp.Next;
        }
        if (temp != null)
        {
            newStudent.Next = temp.Next;
            temp.Next = newStudent;
        }
    }

    public void DeleteByRollNumber(int rollNumber)
    {
        if (head == null) return;
        if (head.RollNumber == rollNumber)
        {
            head = head.Next;
            return;
        }
        Student temp = head;
        while (temp.Next != null && temp.Next.RollNumber != rollNumber)
        {
            temp = temp.Next;
        }
        if (temp.Next != null)
        {
            temp.Next = temp.Next.Next;
        }
    }

    public Student SearchByRollNumber(int rollNumber)
    {
        Student temp = head;
        while (temp != null)
        {
            if (temp.RollNumber == rollNumber)
            {
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }

    public void DisplayAll()
    {
        Student temp = head;
        while (temp != null)
        {
            Console.WriteLine("Roll Number: " + temp.RollNumber + ", Name: " + temp.Name + ", Age: " + temp.Age + ", Grade: " + temp.Grade);
            temp = temp.Next;
        }
    }

    public void UpdateGrade(int rollNumber, string newGrade)
    {
        Student student = SearchByRollNumber(rollNumber);
        if (student != null)
        {
            student.Grade = newGrade;
        }
    }
    static void Main(string[] args)
    {
        StudentRecordManager manager = new StudentRecordManager();

        manager.AddAtBeginning(1, "Yash", 20, "A+");
        manager.AddAtEnd(2, "Vedant", 22, "B");
        manager.AddAtPosition(3, "Raghav", 21, "B+", 1);

        manager.DisplayAll();

        manager.UpdateGrade(2, "A");
        Console.WriteLine("After grade update:");
        manager.DisplayAll();

        manager.DeleteByRollNumber(1);
        Console.WriteLine("After deletion:");
        manager.DisplayAll();
        
        Student foundStudent = manager.SearchByRollNumber(2);
        if (foundStudent != null)
        {
            Console.WriteLine("Found Student: Roll Number: " + foundStudent.RollNumber + ", Name: " + foundStudent.Name + ", Age: " + foundStudent.Age + ", Grade: " + foundStudent.Grade);
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }
}

using System;
using System.IO;

class Store
{
    static void Main(string[] args)
    {
        string filePath = "studentData.dat";

        StoreStudentDetails(filePath);

        RetrieveStudentDetails(filePath);
    }

    static void StoreStudentDetails(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            int rollNumber = 101;
            string name = "Yash";
            double gpa = 3.75;

            writer.Write(rollNumber);
            writer.Write(name);
            writer.Write(gpa);

            Console.WriteLine("Student details stored successfully.");
        }
    }

    static void RetrieveStudentDetails(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            int rollNumber = reader.ReadInt32();
            string name = reader.ReadString();
            double gpa = reader.ReadDouble();

            Console.WriteLine("Retrieved Student Details:");
            Console.WriteLine("Roll Number: " + rollNumber);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("GPA: " + gpa);
        }
    }
}

using System;
using System.Collections.Generic;

    class Hosptal
    {
        static void Main(string[] args)
        {
            PriorityQueue<Patient, int> priorityQueue = new PriorityQueue<Patient, int>();

            priorityQueue.Enqueue(new Patient("Yash", 3), 3);
            priorityQueue.Enqueue(new Patient("Vedant", 5), 5);
            priorityQueue.Enqueue(new Patient("Vatsal", 2), 2);

            Console.WriteLine("Order of treatment:");
            while (priorityQueue.Count > 0)
            {
                Patient patient = priorityQueue.Dequeue();
                Console.WriteLine(patient.Name);
            }
        }
    }

    class Patient
    {
        public string Name { get; set; }
        public int Severity { get; set; }

        public Patient(string name, int severity)
        {
            Name = name;
            Severity = severity;
        }
	}

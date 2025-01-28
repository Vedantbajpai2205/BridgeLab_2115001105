using System; 
namespace StudentScorecard 
{ 
class Studentscore
{ 
static void Main() 
{ 

Console.WriteLine("Enter the number of students:"); 
int numberOfStudents = int.Parse(Console.ReadLine()); 
// Generate random scores for Physics, Chemistry, and 
int[,] scores = GenerateRandomScores(numberOfStudents); 

double[,] results = CalculateResults(scores); 
// Display the scorecard 
DisplayScorecard(scores, results); 
} 
} 
} 
static int[,] GenerateRandomScores(int numberOfStudents) 
{ 
Random random = new Random(); 
int[,] scores = new int[numberOfStudents, 3]; 
for (int i = 0; i < numberOfStudents; i++) 
{ 
scores[i, 0] = random.Next(10, 100); 
scores[i, 1] = random.Next(10, 100); 
scores[i, 2] = random.Next(10, 100); 
return scores; 
static double[,] CalculateResults(int[,] scores) 
{ 
int numberOfStudents = scores.GetLength(0); 
double[,] results = new double[numberOfStudents, 3]; 
for (int i = 0; i < numberOfStudents; i++) 
{ 

int total = scores[i, 0] + scores[i, 1] + scores[i, 2]; 
double average = Math.Round((double)total / 3, 2); 
double percentage = Math.Round((double)total / 300 * 100, 2); 

results[i, 0] = total; 
results[i, 1] = average; 
results[i, 2] = percentage; 
}
return results; 
} 
{ 
static void DisplayScorecard(int[,] scores, double[,] results) 
Console.WriteLine("Student\tPhysics\tChemistry\tMath\tTotal\tAverage\tPercentage"); 
for (int i = 0; i < scores.GetLength(0); i++) 
{ 
Console.WriteLine($"{i + 1}\t{scores[i, 0]}\t{scores[i, 1]}\t\t{scores[i, 2]}\t{results[i, 0]}\t{results[i, 1]}\t{results[i, 2]}"); 
} 
} 
} 
} 
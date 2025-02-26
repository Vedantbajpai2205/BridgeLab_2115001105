using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

class Report
{
    static void Main(string[] args)
    {
        string connectionString = "YourConnectionStringHere";
        string outputFilePath = "employees_report.csv";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        using (StreamWriter writer = new StreamWriter(outputFilePath))
                        {
                            writer.WriteLine("Employee ID,Name,Department,Salary");

                            while (reader.Read())
                            {
                                string employeeId = reader["EmployeeID"].ToString();
                                string name = reader["Name"].ToString();
                                string department = reader["Department"].ToString();
                                string salary = reader["Salary"].ToString();

                                writer.WriteLine($"{employeeId},{name},{department},{salary}");
                            }
                        }
                    }
                }
            }

            Console.WriteLine("CSV report generated successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}


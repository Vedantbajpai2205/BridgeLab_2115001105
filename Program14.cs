using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Runtime.Remoting.Contexts;

namespace JSON
{
    class Program14
    {
        static void Main()
        {
            using (var context = new ApplicationDbContext())
            {
                var records = context.Users.ToList(); 
                var jsonReport = JsonConvert.SerializeObject(records, Formatting.Indented);
                Console.WriteLine(jsonReport);
            }
        }
    }

    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("your_connection_string");
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }

}

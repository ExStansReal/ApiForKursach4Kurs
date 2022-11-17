using System;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int Id { get; set; } 
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public DateTime Date_of_birth { get; set; }
        public string Education { get; set; }

        public string email { get; set; }
        public string dolztost { get; set; }

      
    }
}

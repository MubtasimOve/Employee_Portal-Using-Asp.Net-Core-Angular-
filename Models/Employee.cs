using System.ComponentModel.DataAnnotations;

namespace EmployeePortal.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }

        public int Email { get; set; }

        public string? Mobile  { get; set; }

        public int Salary { get; set; }

        public bool status { get; set; }
    }
}

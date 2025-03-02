using System.ComponentModel.DataAnnotations;

namespace LastWebTaskW3D1.Models
{
    public class Employee
    {
        [Key] // Marks Id as the primary key
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public decimal Salary { get; set; }
    }
}

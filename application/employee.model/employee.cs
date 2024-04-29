using System;
using System.ComponentModel.DataAnnotations;

namespace employee.model
{
    public class Employee
    {
        public int Employee_ID { get; set; }

        [MaxLength(50)]
        public string First_Name { get; set; }

        [MaxLength(50)]
        public string Last_Name { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public DateTime DOB { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(10)]
        public string Mobile { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Employee_Management_System.models
{
    public class Emp_Salary_Details
    {
       
            public int Employee_ID { get; set; }
            [ForeignKey("Employee")]
            public string? First_Name { get; set; }
            public string? Last_Name { get; set; }
            public string? Gender { get; set; }
            public string? Address { get; set; }
            public DateTime DOB { get; set; }
            public string? Email { get; set; }

            public string? Mobile { get; set; }
            [MaxLength(10)]
            public string? Department { get; set; }
            public string? Designation { get; set; }
            public string? PaymentMethod { get; set; }
            public string? PayMonth { get; set; }

        
    }
}

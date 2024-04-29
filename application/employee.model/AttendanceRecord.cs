using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee.model
{
    internal class AttendanceRecord
    {
        public int Id { get; set; }
        [ForeignKeyAttribute("Employee")]
        public string Name { get; set; }
        public string Contact_Details { get; set; }
        public int EmployeeDescription { get; set; }
        [MaxLength(100)]
        public DateTime DOB { get; set; }
        public DateTime DateJoined { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public string Payment_Method { get; set; }
        [ForeignKeyAttribute("Method"]

        public string PayMonth { get; set; }
        [ForeignKeyAttribute("TaxYear")]

        public int TaxCode { get; set; }
        [Column(TypeName = "money" )]

        public DateTime HourlyRate { get; set; }
        [Column(TypeName = "money" )]

        public decimal HoursWorked { get; set; }
        [Column(TypeName = "money" )]
        public decimal ContractualHours { get; set; }
        public decimal OvertimeHours { get; set; }
        [Column(TypeName = "money" )]
        public decimal ContractualEarnings { get; set; }
        [Column(TypeName = "money" )]
        public decimal OvertimeEarnings { get; set; }
        [Column(TypeName = "money" )]

        public decimal NIC { get; set; }
        [Column(TypeName = "money" )]




    
    }

            
        }
    }
}

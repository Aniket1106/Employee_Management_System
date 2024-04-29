using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace application.net
{
    public enum Employee_Attendance_Status
    {
        public int Id { get; set; }
        [ForeignKey("Employee")]
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
        [ForeignKey("Method")]
       
    }
}

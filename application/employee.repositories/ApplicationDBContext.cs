using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee.repositories
{
    public class ApplicationDBContext : Identity DbContext
    {
        public ApplicationDBContext() : base("name=DefaultConnection")
        {
        }

        public DbSet<Employee_ID> Employees { get; set; }
        public DbSet<PaymentRecord> PaymentRecords { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<AttendanceRecord> AttendanceRecords { get; set; }
    }
    {
public class AttendanceRecord
    {
    }

    public class PaymentMethod
    {
    }

    public class Employee_ID
    {
    }

    public class PaymentRecord
    {
    }
}
}

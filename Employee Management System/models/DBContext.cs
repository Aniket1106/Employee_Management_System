using Microsoft.EntityFrameworkCore;

namespace Employee_Management_System.models
{
    
        public partial class DBContext : DbContext
        {
        public  DBContext()
        {
        }
            public DBContext(DbContextOptions<DBContext> options)
                : base(options)
            {
            }
            public virtual DbSet<Emp_Details> Emp_Details { get; set; }
           // public virtual DbSet<Emp_Salary_Detailscs> Emp_Salary_Detailscs { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Emp_Details>(entity => 
                {
                    entity.HasKey(k => k.Employee_ID).HasName("PK_Emp 1");

                    entity.ToTable("emp_details");

                    entity.Property(e => e.Employee_ID).HasColumnName("Employee_ID");
                    entity.Property(e => e.First_Name).HasColumnName("First_Name");
                    entity.Property(e => e.Last_Name).HasColumnName("Last_Name");
                    entity.Property(e => e.Gender).HasColumnName("Gender");
                    entity.Property(e => e.Address).HasColumnName("Address");
                    entity.Property(e => e.DOB).HasColumnName("DOB");
                    entity.Property(e => e.Email).HasColumnName("Email");
                    entity.Property(e => e.Mobile).HasColumnName("Mobile");

                });


            modelBuilder.Entity<Emp_Salary_Detailscs>(entity =>
            {
                entity.HasKey(k => k.Employee_ID).HasName("PK_EmpSalary");

                entity.ToTable("Emp_salary_details");

                entity.Property(e => e.Employee_ID).HasColumnName("Employee_ID");
                entity.Property(e => e.First_Name).HasColumnName("First_Name");
                entity.Property(e => e.Last_Name).HasColumnName("Last_Name");
                entity.Property(e => e.Gender).HasColumnName("Gender");
                entity.Property(e => e.Address).HasColumnName("Address");
                entity.Property(e => e.DOB).HasColumnName("DOB");
                entity.Property(e => e.Email).HasColumnName("Email");
                entity.Property(e => e.Mobile).HasColumnName("Mobile");
                entity.Property(e => e.Department).HasColumnName("Department");
                entity.Property(e => e.Designation).HasColumnName("Designation");
                entity.Property(e => e.PaymentMethod).HasColumnName("PaymentMethod");
                entity.Property(e => e.PayMonth).HasColumnName("PayMonth");


            });


            OnModelCreatingPartial(modelBuilder);
            }
            partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        }
    }


namespace Employees.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EmployeesModel : DbContext
    {
        public EmployeesModel()
            : base("name=EmployeeModel")
        {
        }

        public virtual DbSet<BusinessPartner> BusinessPartner { get; set; }
        public virtual DbSet<BusinessPartnerEmployee> BusinessPartnerEmployee { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Supervisors> Supervisors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusinessPartner>()
                .Property(e => e.BPName)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessPartner>()
                .Property(e => e.EmplEmail)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessPartner>()
                .Property(e => e.EmplPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmplName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmplPositoin)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Supervisors)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.SOId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Supervisors1)
                .WithOptional(e => e.Employee1)
                .HasForeignKey(e => e.SVId);
        }
    }
}

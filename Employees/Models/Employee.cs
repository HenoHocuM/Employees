namespace Employees.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            BusinessPartnerEmployee = new HashSet<BusinessPartnerEmployee>();
            Supervisors = new HashSet<Supervisors>();
            Supervisors1 = new HashSet<Supervisors>();
        }

        [Key]
        public int EmpId { get; set; }

        [Required]
        [StringLength(255)]
        public string EmplName { get; set; }

        [Required]
        [StringLength(120)]
        public string EmplPositoin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessPartnerEmployee> BusinessPartnerEmployee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supervisors> Supervisors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supervisors> Supervisors1 { get; set; }
    }
}

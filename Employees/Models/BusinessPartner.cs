namespace Employees.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessPartner")]
    public partial class BusinessPartner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BusinessPartner()
        {
            BusinessPartnerEmployee = new HashSet<BusinessPartnerEmployee>();
        }

        [Key]
        public int BPId { get; set; }

        [Required]
        [StringLength(255)]
        public string BPName { get; set; }

        [Required]
        [StringLength(120)]
        public string EmplEmail { get; set; }

        [StringLength(90)]
        public string EmplPhone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessPartnerEmployee> BusinessPartnerEmployee { get; set; }
    }
}

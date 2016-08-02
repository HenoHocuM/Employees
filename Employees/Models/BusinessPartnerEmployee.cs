namespace Employees.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessPartnerEmployee")]
    public partial class BusinessPartnerEmployee
    {
        [Key]
        public int BPEMPId { get; set; }

        public int? EMPId { get; set; }

        public int? BPId { get; set; }

        public virtual BusinessPartner BusinessPartner { get; set; }

        public virtual Employee Employee { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.ACS_ROLE")]
    public partial class ACS_ROLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACS_ROLE()
        {
            ACS_APPLICATION_ROLE = new HashSet<ACS_APPLICATION_ROLE>();
            ACS_CONTROL_ROLE = new HashSet<ACS_CONTROL_ROLE>();
            ACS_MODULE_ROLE = new HashSet<ACS_MODULE_ROLE>();
            ACS_ROLE_BASE = new HashSet<ACS_ROLE_BASE>();
            ACS_ROLE_BASE1 = new HashSet<ACS_ROLE_BASE>();
            ACS_ROLE_USER = new HashSet<ACS_ROLE_USER>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public long? CREATE_TIME { get; set; }

        public long? MODIFY_TIME { get; set; }

        [StringLength(50)]
        public string CREATOR { get; set; }

        [StringLength(50)]
        public string MODIFIER { get; set; }

        [StringLength(50)]
        public string APP_CREATOR { get; set; }

        [StringLength(50)]
        public string APP_MODIFIER { get; set; }

        public short? IS_ACTIVE { get; set; }

        public short? IS_DELETE { get; set; }

        [StringLength(50)]
        public string GROUP_CODE { get; set; }

        [Required]
        [StringLength(8)]
        public string ROLE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string ROLE_NAME { get; set; }

        public short? IS_FULL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACS_APPLICATION_ROLE> ACS_APPLICATION_ROLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACS_CONTROL_ROLE> ACS_CONTROL_ROLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACS_MODULE_ROLE> ACS_MODULE_ROLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACS_ROLE_BASE> ACS_ROLE_BASE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACS_ROLE_BASE> ACS_ROLE_BASE1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACS_ROLE_USER> ACS_ROLE_USER { get; set; }
    }
}

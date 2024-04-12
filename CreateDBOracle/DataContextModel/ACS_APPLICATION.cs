namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.ACS_APPLICATION")]
    public partial class ACS_APPLICATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACS_APPLICATION()
        {
            ACS_APPLICATION_ROLE = new HashSet<ACS_APPLICATION_ROLE>();
            ACS_CONTROL = new HashSet<ACS_CONTROL>();
            ACS_MODULE = new HashSet<ACS_MODULE>();
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
        [StringLength(3)]
        public string APPLICATION_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string APPLICATION_NAME { get; set; }

        [StringLength(20)]
        public string ALLOW_VERSION { get; set; }

        public short? IS_CHECK_VERSION { get; set; }

        [StringLength(500)]
        public string SMS_URL { get; set; }

        [StringLength(4000)]
        public string SMS_ACTIVE_TEMP { get; set; }

        [StringLength(4000)]
        public string SMS_CHANGE_PASS_TEMP { get; set; }

        public short? IS_VERIFY_OTP { get; set; }

        public short? IS_LICENSE_ISSUED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACS_APPLICATION_ROLE> ACS_APPLICATION_ROLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACS_CONTROL> ACS_CONTROL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACS_MODULE> ACS_MODULE { get; set; }
    }
}

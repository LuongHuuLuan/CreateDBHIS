namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_KSK_CONTRACT")]
    public partial class HIS_KSK_CONTRACT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_KSK_CONTRACT()
        {
            HIS_KSK = new HashSet<HIS_KSK>();
            HIS_KSK_ACCESS = new HashSet<HIS_KSK_ACCESS>();
            HIS_PATIENT_TYPE_ALTER = new HashSet<HIS_PATIENT_TYPE_ALTER>();
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
        [StringLength(20)]
        public string KSK_CONTRACT_CODE { get; set; }

        public long WORK_PLACE_ID { get; set; }

        public long? CONTRACT_DATE { get; set; }

        public long? EFFECT_DATE { get; set; }

        public long? EXPIRY_DATE { get; set; }

        public decimal? CONTRACT_VALUE { get; set; }

        public decimal? DEPOSIT_AMOUNT { get; set; }

        public decimal PAYMENT_RATIO { get; set; }

        public short? IS_REQUIRED_APPROVAL { get; set; }

        public short? IS_RESTRICTED { get; set; }

        public long? DEPARTMENT_ID { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_KSK> HIS_KSK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_KSK_ACCESS> HIS_KSK_ACCESS { get; set; }

        public virtual HIS_WORK_PLACE HIS_WORK_PLACE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PATIENT_TYPE_ALTER> HIS_PATIENT_TYPE_ALTER { get; set; }
    }
}

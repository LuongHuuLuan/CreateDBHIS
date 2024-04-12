namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_PATIENT_CLASSIFY")]
    public partial class HIS_PATIENT_CLASSIFY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_PATIENT_CLASSIFY()
        {
            HIS_EXME_REASON_CFG = new HashSet<HIS_EXME_REASON_CFG>();
            HIS_PATIENT = new HashSet<HIS_PATIENT>();
            HIS_SERVICE_PATY = new HashSet<HIS_SERVICE_PATY>();
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
        [StringLength(10)]
        public string PATIENT_CLASSIFY_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string PATIENT_CLASSIFY_NAME { get; set; }

        [StringLength(20)]
        public string DISPLAY_COLOR { get; set; }

        public long? PATIENT_TYPE_ID { get; set; }

        public short? IS_POLICE { get; set; }

        public long? OTHER_PAY_SOURCE_ID { get; set; }

        [StringLength(500)]
        public string BHYT_WHITELIST_IDS { get; set; }

        [StringLength(500)]
        public string MILITARY_RANK_IDS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXME_REASON_CFG> HIS_EXME_REASON_CFG { get; set; }

        public virtual HIS_OTHER_PAY_SOURCE HIS_OTHER_PAY_SOURCE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PATIENT> HIS_PATIENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_PATY> HIS_SERVICE_PATY { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_ICD_CM")]
    public partial class HIS_ICD_CM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_ICD_CM()
        {
            HIS_SERVICE = new HashSet<HIS_SERVICE>();
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
        public string ICD_CM_CODE { get; set; }

        [Required]
        [StringLength(1000)]
        public string ICD_CM_NAME { get; set; }

        [StringLength(10)]
        public string ICD_CM_CHAPTER_CODE { get; set; }

        [StringLength(500)]
        public string ICD_CM_CHAPTER_NAME { get; set; }

        [StringLength(10)]
        public string ICD_CM_GROUP_CODE { get; set; }

        [StringLength(500)]
        public string ICD_CM_GROUP_NAME { get; set; }

        [StringLength(10)]
        public string ICD_CM_SUB_GROUP_CODE { get; set; }

        [StringLength(500)]
        public string ICD_CM_SUB_GROUP_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE> HIS_SERVICE { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_DEBATE_TEMP")]
    public partial class HIS_DEBATE_TEMP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_DEBATE_TEMP()
        {
            HIS_DEBATE_INVITE_USER = new HashSet<HIS_DEBATE_INVITE_USER>();
            HIS_DEBATE_USER = new HashSet<HIS_DEBATE_USER>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [Required]
        [StringLength(20)]
        public string DEBATE_TEMP_CODE { get; set; }

        [Required]
        [StringLength(200)]
        public string DEBATE_TEMP_NAME { get; set; }

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

        [StringLength(10)]
        public string ICD_CODE { get; set; }

        [StringLength(500)]
        public string ICD_NAME { get; set; }

        [StringLength(500)]
        public string ICD_SUB_CODE { get; set; }

        [StringLength(500)]
        public string ICD_TEXT { get; set; }

        [StringLength(2000)]
        public string TREATMENT_TRACKING { get; set; }

        [StringLength(2000)]
        public string TREATMENT_METHOD { get; set; }

        [StringLength(500)]
        public string LOCATION { get; set; }

        [StringLength(1000)]
        public string REQUEST_CONTENT { get; set; }

        [StringLength(2000)]
        public string PATHOLOGICAL_HISTORY { get; set; }

        [StringLength(2000)]
        public string HOSPITALIZATION_STATE { get; set; }

        [StringLength(2000)]
        public string BEFORE_DIAGNOSTIC { get; set; }

        [StringLength(2000)]
        public string DIAGNOSTIC { get; set; }

        [StringLength(2000)]
        public string CARE_METHOD { get; set; }

        [StringLength(2000)]
        public string CONCLUSION { get; set; }

        [StringLength(2000)]
        public string DISCUSSION { get; set; }

        [StringLength(2000)]
        public string MEDICINE_TUTORIAL { get; set; }

        [StringLength(100)]
        public string MEDICINE_USE_FORM_NAME { get; set; }

        [StringLength(500)]
        public string MEDICINE_TYPE_NAME { get; set; }

        [StringLength(1000)]
        public string MEDICINE_CONCENTRA { get; set; }

        public short? IS_PUBLIC { get; set; }

        public long? DEPARTMENT_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEBATE_INVITE_USER> HIS_DEBATE_INVITE_USER { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEBATE_USER> HIS_DEBATE_USER { get; set; }
    }
}

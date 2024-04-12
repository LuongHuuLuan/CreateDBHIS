namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_DEBATE")]
    public partial class HIS_DEBATE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_DEBATE()
        {
            HIS_DEBATE_EKIP_USER = new HashSet<HIS_DEBATE_EKIP_USER>();
            HIS_DEBATE_INVITE_USER = new HashSet<HIS_DEBATE_INVITE_USER>();
            HIS_DEBATE_USER = new HashSet<HIS_DEBATE_USER>();
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

        public long TREATMENT_ID { get; set; }

        public long? ICD_ID__DELETE { get; set; }

        [StringLength(10)]
        public string ICD_CODE { get; set; }

        [StringLength(500)]
        public string ICD_NAME { get; set; }

        [StringLength(500)]
        public string ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string ICD_TEXT { get; set; }

        public long? DEPARTMENT_ID { get; set; }

        public long? DEBATE_TIME { get; set; }

        [StringLength(50)]
        public string REQUEST_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REQUEST_USERNAME { get; set; }

        [StringLength(4000)]
        public string TREATMENT_TRACKING { get; set; }

        public long? TREATMENT_FROM_TIME { get; set; }

        public long? TREATMENT_TO_TIME { get; set; }

        [StringLength(2000)]
        public string TREATMENT_METHOD { get; set; }

        [StringLength(500)]
        public string LOCATION { get; set; }

        [StringLength(1000)]
        public string REQUEST_CONTENT { get; set; }

        [StringLength(4000)]
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

        public long? MEDICINE_USE_TIME { get; set; }

        public long? DEBATE_TYPE_ID { get; set; }

        public long? CONTENT_TYPE { get; set; }

        [StringLength(4000)]
        public string SUBCLINICAL_PROCESSES { get; set; }

        [StringLength(4000)]
        public string INTERNAL_MEDICINE_STATE { get; set; }

        public long? SURGERY_SERVICE_ID { get; set; }

        public long? EMOTIONLESS_METHOD_ID { get; set; }

        public long? SURGERY_TIME { get; set; }

        [StringLength(4000)]
        public string PROGNOSIS { get; set; }

        public long? PTTT_METHOD_ID { get; set; }

        [StringLength(1000)]
        public string PTTT_METHOD_NAME { get; set; }

        [StringLength(500)]
        public string MEDICINE_TYPE_IDS { get; set; }

        [StringLength(500)]
        public string ACTIVE_INGREDIENT_IDS { get; set; }

        public long? TRACKING_ID { get; set; }

        public long? SERVICE_ID { get; set; }

        [StringLength(100)]
        public string TMP_ID { get; set; }

        public long? DEBATE_REASON_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEBATE_EKIP_USER> HIS_DEBATE_EKIP_USER { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }

        public virtual HIS_DEBATE_TYPE HIS_DEBATE_TYPE { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        public virtual HIS_EMOTIONLESS_METHOD HIS_EMOTIONLESS_METHOD { get; set; }

        public virtual HIS_SERVICE HIS_SERVICE { get; set; }

        public virtual HIS_PTTT_METHOD HIS_PTTT_METHOD { get; set; }

        public virtual HIS_TRACKING HIS_TRACKING { get; set; }

        public virtual HIS_SERVICE HIS_SERVICE1 { get; set; }

        public virtual HIS_DEBATE_REASON HIS_DEBATE_REASON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEBATE_INVITE_USER> HIS_DEBATE_INVITE_USER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEBATE_USER> HIS_DEBATE_USER { get; set; }
    }
}

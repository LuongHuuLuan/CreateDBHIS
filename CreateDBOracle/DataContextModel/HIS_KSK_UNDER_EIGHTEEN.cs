namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_KSK_UNDER_EIGHTEEN")]
    public partial class HIS_KSK_UNDER_EIGHTEEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_KSK_UNDER_EIGHTEEN()
        {
            HIS_KSK_UNEI_VATY = new HashSet<HIS_KSK_UNEI_VATY>();
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

        public long SERVICE_REQ_ID { get; set; }

        public long TDL_TREATMENT_ID { get; set; }

        public long TDL_PATIENT_ID { get; set; }

        public long? DHST_ID { get; set; }

        public long? DHST_RANK { get; set; }

        [StringLength(4000)]
        public string PATHOLOGICAL_HISTORY_FAMILY { get; set; }

        [StringLength(4000)]
        public string MEDICINE_USING { get; set; }

        [StringLength(4000)]
        public string MATERNITY_HISTORY { get; set; }

        [StringLength(4000)]
        public string EXAM_CIRCULATION { get; set; }

        public long? EXAM_CIRCULATION_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_RESPIRATORY { get; set; }

        public long? EXAM_RESPIRATORY_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_DIGESTION { get; set; }

        public long? EXAM_DIGESTION_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_KIDNEY_UROLOGY { get; set; }

        public long? EXAM_KIDNEY_UROLOGY_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_NEURO_MENTAL { get; set; }

        public long? EXAM_NEURO_MENTAL_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_CLINICAL_OTHER { get; set; }

        public long? EXAM_CLINICAL_OTHER_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_ENT { get; set; }

        public long? EXAM_ENT_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_STOMATOLOGY { get; set; }

        public long? EXAM_STOMATOLOGY_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_EYE { get; set; }

        public long? EXAM_EYE_RANK { get; set; }

        public long? HEALTH_EXAM_RANK_ID { get; set; }

        [StringLength(4000)]
        public string PATHOLOGICAL_HISTORY { get; set; }

        [StringLength(4000)]
        public string EXAM_EYE_DISEASE { get; set; }

        [StringLength(500)]
        public string EXAM_EYESIGHT_GLASS_LEFT { get; set; }

        [StringLength(500)]
        public string EXAM_EYESIGHT_GLASS_RIGHT { get; set; }

        [StringLength(500)]
        public string EXAM_EYESIGHT_LEFT { get; set; }

        [StringLength(500)]
        public string EXAM_EYESIGHT_RIGHT { get; set; }

        [StringLength(4000)]
        public string EXAM_ENT_DISEASE { get; set; }

        [StringLength(4000)]
        public string EXAM_ENT_LEFT_NORMAL { get; set; }

        [StringLength(4000)]
        public string EXAM_ENT_LEFT_WHISPER { get; set; }

        [StringLength(4000)]
        public string EXAM_ENT_RIGHT_NORMAL { get; set; }

        [StringLength(4000)]
        public string EXAM_ENT_RIGHT_WHISPER { get; set; }

        [StringLength(4000)]
        public string EXAM_STOMATOLOGY_DISEASE { get; set; }

        [StringLength(4000)]
        public string EXAM_STOMATOLOGY_LOWER { get; set; }

        [StringLength(4000)]
        public string EXAM_STOMATOLOGY_UPPER { get; set; }

        [StringLength(4000)]
        public string RESULT_SUBCLINICAL { get; set; }

        [StringLength(4000)]
        public string NORMAL_HEALTH { get; set; }

        [StringLength(4000)]
        public string PROBLEM_HEALTH { get; set; }

        public virtual HIS_SERVICE_REQ HIS_SERVICE_REQ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_KSK_UNEI_VATY> HIS_KSK_UNEI_VATY { get; set; }
    }
}

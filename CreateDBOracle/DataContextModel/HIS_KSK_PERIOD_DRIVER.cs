namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_KSK_PERIOD_DRIVER")]
    public partial class HIS_KSK_PERIOD_DRIVER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_KSK_PERIOD_DRIVER()
        {
            HIS_PERIOD_DRIVER_DITY = new HashSet<HIS_PERIOD_DRIVER_DITY>();
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

        [StringLength(4000)]
        public string PATHOLOGICAL_HISTORY_FAMILY { get; set; }

        [StringLength(4000)]
        public string MEDICINE_USING { get; set; }

        [StringLength(4000)]
        public string MATERNITY_HISTORY { get; set; }

        [StringLength(4000)]
        public string EXAM_RESPIRATORY { get; set; }

        public long? EXAM_RESPIRATORY_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_RESPIRATORY_CONCLUDE { get; set; }

        [StringLength(4000)]
        public string EXAM_NEUROLOGICAL { get; set; }

        public long? EXAM_NEUROLOGICAL_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_NEUROLOGICAL_CONCLUDE { get; set; }

        [StringLength(4000)]
        public string EXAM_MUSCLE_BONE { get; set; }

        public long? EXAM_MUSCLE_BONE_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_MUSCLE_BONE_CONCLUDE { get; set; }

        [StringLength(4000)]
        public string EXAM_ENT { get; set; }

        public long? EXAM_ENT_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_ENT_CONCLUDE { get; set; }

        [StringLength(4000)]
        public string EXAM_EYE { get; set; }

        public long? EXAM_EYE_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_EYE_CONCLUDE { get; set; }

        [StringLength(4000)]
        public string EXAM_MENTAL { get; set; }

        public long? EXAM_MENTAL_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_MENTAL_CONCLUDE { get; set; }

        [StringLength(4000)]
        public string EXAM_OEND { get; set; }

        public long? EXAM_OEND_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_OEND_CONCLUDE { get; set; }

        public long? HEALTH_EXAM_RANK_ID { get; set; }

        [StringLength(4000)]
        public string EXAM_MATERNITY { get; set; }

        public long? EXAM_MATERNITY_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_MATERNITY_CONCLUDE { get; set; }

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

        [StringLength(500)]
        public string EXAM_TWO_EYESIGHT { get; set; }

        [StringLength(500)]
        public string EXAM_TWO_EYESIGHT_GLASS { get; set; }

        [StringLength(500)]
        public string EXAM_EYEFIELD_HORI_NORMAL { get; set; }

        [StringLength(500)]
        public string EXAM_EYEFIELD_HORI_LIMIT { get; set; }

        [StringLength(500)]
        public string EXAM_EYEFIELD_VERT_NORMAL { get; set; }

        [StringLength(500)]
        public string EXAM_EYEFIELD_VERT_LIMIT { get; set; }

        public short? EXAM_EYECOLOR_IS_NORMAL { get; set; }

        public short? EXAM_EYECOLOR_IS_BLIND { get; set; }

        public short? EXAM_EYECOLOR_IS_BLIND_RED { get; set; }

        public short? EXAM_EYECOLOR_IS_BLIND_GREEN { get; set; }

        public short? EXAM_EYECOLOR_IS_BLIND_YELOW { get; set; }

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
        public string EXAM_CARDIOVASCULAR { get; set; }

        public long? EXAM_CARDIOVASCULAR_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_CARDIOVASCULAR_CONCLUDE { get; set; }

        public long? EXAM_CARDIOVASCULAR_PULSE { get; set; }

        public long? EXAM_CARDIOVASCULAR_BLOOD_MAX { get; set; }

        public long? EXAM_CARDIOVASCULAR_BLOOD_MIN { get; set; }

        [StringLength(500)]
        public string TEST_MORPHIN_HEROIN { get; set; }

        [StringLength(500)]
        public string TEST_AMPHETAMIN { get; set; }

        [StringLength(500)]
        public string TEST_METHAMPHETAMIN { get; set; }

        [StringLength(500)]
        public string TEST_MARIJUANA { get; set; }

        [StringLength(500)]
        public string TEST_CONCENTRATION { get; set; }

        [StringLength(4000)]
        public string RESULT_SUBCLINICAL { get; set; }

        [StringLength(4000)]
        public string NOTE_SUBCLINICAL { get; set; }

        [StringLength(4000)]
        public string CONCLUDE { get; set; }

        public long? LICENSE_CLASS_ID { get; set; }

        [StringLength(100)]
        public string LICENSE_CLASS_NAME { get; set; }

        public virtual HIS_SERVICE_REQ HIS_SERVICE_REQ { get; set; }

        public virtual HIS_LICENSE_CLASS HIS_LICENSE_CLASS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PERIOD_DRIVER_DITY> HIS_PERIOD_DRIVER_DITY { get; set; }
    }
}

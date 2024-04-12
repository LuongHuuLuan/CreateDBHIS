namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_KSK_OVER_EIGHTEEN")]
    public partial class HIS_KSK_OVER_EIGHTEEN
    {
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
        public string EXAM_NEUROLOGICAL { get; set; }

        public long? EXAM_NEUROLOGICAL_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_MUSCLE_BONE { get; set; }

        public long? EXAM_MUSCLE_BONE_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_ENT { get; set; }

        public long? EXAM_ENT_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_STOMATOLOGY { get; set; }

        public long? EXAM_STOMATOLOGY_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_EYE { get; set; }

        public long? EXAM_EYE_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_MENTAL { get; set; }

        public long? EXAM_MENTAL_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_DERMATOLOGY { get; set; }

        public long? EXAM_DERMATOLOGY_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_SURGERY { get; set; }

        public long? EXAM_SURGERY_RANK { get; set; }

        public long? HEALTH_EXAM_RANK_ID { get; set; }

        [StringLength(4000)]
        public string EXAM_OBSTETRIC { get; set; }

        public long? EXAM_OBSTETRIC_RANK { get; set; }

        [StringLength(4000)]
        public string DISEASES { get; set; }

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

        [StringLength(50)]
        public string TEST_BLOOD_HC { get; set; }

        [StringLength(50)]
        public string TEST_BLOOD_BC { get; set; }

        [StringLength(50)]
        public string TEST_BLOOD_TC { get; set; }

        [StringLength(500)]
        public string TEST_BLOOD_GLUCO { get; set; }

        [StringLength(500)]
        public string TEST_BLOOD_URE { get; set; }

        [StringLength(500)]
        public string TEST_BLOOD_CREATININ { get; set; }

        [StringLength(500)]
        public string TEST_BLOOD_ASAT { get; set; }

        [StringLength(500)]
        public string TEST_BLOOD_ALAT { get; set; }

        [StringLength(500)]
        public string TEST_BLOOD_OTHER { get; set; }

        [StringLength(500)]
        public string TEST_URINE_GLUCO { get; set; }

        [StringLength(500)]
        public string TEST_URINE_PROTEIN { get; set; }

        [StringLength(500)]
        public string TEST_URINE_OTHER { get; set; }

        [StringLength(4000)]
        public string RESULT_DIIM { get; set; }

        public virtual HIS_SERVICE_REQ HIS_SERVICE_REQ { get; set; }
    }
}

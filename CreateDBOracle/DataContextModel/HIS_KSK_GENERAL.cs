namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_KSK_GENERAL")]
    public partial class HIS_KSK_GENERAL
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

        public long? DHST_ID { get; set; }

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
        public string EXAM_OEND { get; set; }

        public long? EXAM_OEND_RANK { get; set; }

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
        public string NOTE_BLOOD { get; set; }

        [StringLength(4000)]
        public string NOTE_BIOCHEMICAL { get; set; }

        [StringLength(4000)]
        public string NOTE_PROSTASE { get; set; }

        [StringLength(4000)]
        public string NOTE_SUPERSONIC { get; set; }

        [StringLength(4000)]
        public string NOTE_XRAY { get; set; }

        [StringLength(4000)]
        public string DISEASES { get; set; }

        [StringLength(4000)]
        public string TREATMENT_INSTRUCTION { get; set; }

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
        public string HISTORY_DISEASE_ONE { get; set; }

        [StringLength(20)]
        public string HISTORY_DISEASE_ONE_YEAR { get; set; }

        [StringLength(4000)]
        public string HISTORY_DISEASE_TWO { get; set; }

        [StringLength(20)]
        public string HISTORY_DISEASE_TWO_YEAR { get; set; }

        [StringLength(4000)]
        public string HISTORY_DISEASE_OCCU_ONE { get; set; }

        [StringLength(20)]
        public string HISTORY_DISEASE_OCCU_ONE_YEAR { get; set; }

        [StringLength(4000)]
        public string HISTORY_DISEASE_OCCU_TWO { get; set; }

        [StringLength(20)]
        public string HISTORY_DISEASE_OCCU_TWO_YEAR { get; set; }

        [StringLength(500)]
        public string RECENT_WORK_ONE { get; set; }

        public long? RECENT_WORK_ONE_YEAR { get; set; }

        public long? RECENT_WORK_ONE_MONTH { get; set; }

        public long? RECENT_WORK_ONE_FROM { get; set; }

        public long? RECENT_WORK_ONE_TO { get; set; }

        [StringLength(500)]
        public string RECENT_WORK_TWO { get; set; }

        public long? RECENT_WORK_TWO_YEAR { get; set; }

        public long? RECENT_WORK_TWO_MONTH { get; set; }

        public long? RECENT_WORK_TWO_FROM { get; set; }

        public long? RECENT_WORK_TWO_TO { get; set; }

        [StringLength(4000)]
        public string RESULT_SUBCLINICAL { get; set; }

        [StringLength(4000)]
        public string NOTE_SUBCLINICAL { get; set; }

        [StringLength(4000)]
        public string EXAM_OBSTETRIC { get; set; }

        public long? EXAM_OBSTETRIC_RANK { get; set; }

        public long? DHST_RANK { get; set; }

        [StringLength(4000)]
        public string NOTE_DIIM { get; set; }

        [StringLength(4000)]
        public string NOTE_TEST_URINE { get; set; }

        [StringLength(4000)]
        public string NOTE_TEST_OTHER { get; set; }

        [StringLength(4000)]
        public string EXAM_NUTRION { get; set; }

        public long? EXAM_NUTRION_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_TRADITIONAL { get; set; }

        public long? EXAM_TRADITIONAL_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_OCCUPATIONAL_THERAPY { get; set; }

        public long? EXAM_OCCUPATIONAL_THERAPY_RANK { get; set; }

        [StringLength(50)]
        public string KSK_GENERAL_CODE { get; set; }

        [StringLength(50)]
        public string CONCLUDER_LOGINNAME { get; set; }

        [StringLength(100)]
        public string CONCLUDER_USERNAME { get; set; }

        public long? CONCLUSION_TIME { get; set; }

        [StringLength(6)]
        public string HEIN_MEDI_ORG_CODE { get; set; }

        public virtual HIS_DHST HIS_DHST { get; set; }

        public virtual HIS_SERVICE_REQ HIS_SERVICE_REQ { get; set; }
    }
}

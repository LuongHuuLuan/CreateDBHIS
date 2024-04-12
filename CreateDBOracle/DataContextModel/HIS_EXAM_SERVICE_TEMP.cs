namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_EXAM_SERVICE_TEMP")]
    public partial class HIS_EXAM_SERVICE_TEMP
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

        [Required]
        [StringLength(6)]
        public string EXAM_SERVICE_TEMP_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string EXAM_SERVICE_TEMP_NAME { get; set; }

        [StringLength(500)]
        public string PART_EXAM_CIRCULATION { get; set; }

        [StringLength(500)]
        public string PART_EXAM_RESPIRATORY { get; set; }

        [StringLength(500)]
        public string PART_EXAM_DIGESTION { get; set; }

        [StringLength(500)]
        public string PART_EXAM_KIDNEY_UROLOGY { get; set; }

        [StringLength(500)]
        public string PART_EXAM_NEUROLOGICAL { get; set; }

        [StringLength(500)]
        public string PART_EXAM_MUSCLE_BONE { get; set; }

        [StringLength(500)]
        public string PART_EXAM_ENT { get; set; }

        [StringLength(500)]
        public string PART_EXAM_EAR { get; set; }

        [StringLength(500)]
        public string PART_EXAM_NOSE { get; set; }

        [StringLength(500)]
        public string PART_EXAM_THROAT { get; set; }

        [StringLength(500)]
        public string PART_EXAM_STOMATOLOGY { get; set; }

        [StringLength(500)]
        public string PART_EXAM_EYE { get; set; }

        [StringLength(500)]
        public string PART_EXAM_EYE_TENSION_LEFT { get; set; }

        [StringLength(500)]
        public string PART_EXAM_EYE_TENSION_RIGHT { get; set; }

        [StringLength(500)]
        public string PART_EXAM_EYESIGHT_LEFT { get; set; }

        [StringLength(500)]
        public string PART_EXAM_EYESIGHT_RIGHT { get; set; }

        [StringLength(500)]
        public string PART_EXAM_EYESIGHT_GLASS_LEFT { get; set; }

        [StringLength(500)]
        public string PART_EXAM_EYESIGHT_GLASS_RIGHT { get; set; }

        [StringLength(500)]
        public string PART_EXAM_OEND { get; set; }

        [StringLength(500)]
        public string PART_EXAM_MENTAL { get; set; }

        [StringLength(500)]
        public string PART_EXAM_OBSTETRIC { get; set; }

        [StringLength(500)]
        public string PART_EXAM_NUTRITION { get; set; }

        [StringLength(500)]
        public string PART_EXAM_MOTION { get; set; }

        [StringLength(200)]
        public string HOSPITALIZATION_REASON { get; set; }

        [StringLength(4000)]
        public string PATHOLOGICAL_PROCESS { get; set; }

        [StringLength(500)]
        public string PATHOLOGICAL_HISTORY { get; set; }

        [StringLength(500)]
        public string PATHOLOGICAL_HISTORY_FAMILY { get; set; }

        [StringLength(4000)]
        public string FULL_EXAM { get; set; }

        [StringLength(500)]
        public string PART_EXAM { get; set; }

        [StringLength(1000)]
        public string CONCLUDE { get; set; }

        [StringLength(1000)]
        public string DESCRIPTION { get; set; }

        [StringLength(500)]
        public string NOTE { get; set; }

        public short? IS_PUBLIC { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_EAR_RIGHT_NORMAL { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_EAR_RIGHT_WHISPER { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_EAR_LEFT_NORMAL { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_EAR_LEFT_WHISPER { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_UPPER_JAW { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_LOWER_JAW { get; set; }

        public long? PART_EXAM_HORIZONTAL_SIGHT { get; set; }

        public long? PART_EXAM_VERTICAL_SIGHT { get; set; }

        public long? PART_EXAM_EYE_BLIND_COLOR { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_DERMATOLOGY { get; set; }
    }
}

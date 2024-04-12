namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.L_HIS_TREATMENT_BED_ROOM")]
    public partial class L_HIS_TREATMENT_BED_ROOM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public long TREATMENT_ID { get; set; }

        public long? CO_TREATMENT_ID { get; set; }

        public long ADD_TIME { get; set; }

        public long BED_ROOM_ID { get; set; }

        public long? REMOVE_TIME { get; set; }

        public long? TREATMENT_ROOM_ID { get; set; }

        public long? TDL_OBSERVED_TIME_FROM { get; set; }

        public long? TDL_OBSERVED_TIME_TO { get; set; }

        public long PATIENT_ID { get; set; }

        [Required]
        [StringLength(12)]
        public string TREATMENT_CODE { get; set; }

        [Required]
        [StringLength(30)]
        public string TDL_PATIENT_FIRST_NAME { get; set; }

        [StringLength(70)]
        public string TDL_PATIENT_LAST_NAME { get; set; }

        [Required]
        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        public long TDL_PATIENT_DOB { get; set; }

        [Required]
        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        [Required]
        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        [StringLength(20)]
        public string TDL_HEIN_CARD_NUMBER { get; set; }

        [StringLength(6)]
        public string TDL_HEIN_MEDI_ORG_CODE { get; set; }

        [StringLength(10)]
        public string ICD_CODE { get; set; }

        [StringLength(500)]
        public string ICD_NAME { get; set; }

        [StringLength(4000)]
        public string ICD_TEXT { get; set; }

        [StringLength(500)]
        public string ICD_SUB_CODE { get; set; }

        public long TDL_PATIENT_GENDER_ID { get; set; }

        [StringLength(500)]
        public string TDL_HEIN_MEDI_ORG_NAME { get; set; }

        public short? IS_PAUSE { get; set; }

        public short? IS_APPROVE_FINISH { get; set; }

        [StringLength(500)]
        public string APPROVE_FINISH_NOTE { get; set; }

        public long? TDL_PATIENT_CLASSIFY_ID { get; set; }

        public long? TDL_TREATMENT_TYPE_ID { get; set; }

        public long? EMR_COVER_TYPE_ID { get; set; }

        public long? CLINICAL_IN_TIME { get; set; }

        [StringLength(200)]
        public string CO_TREAT_DEPARTMENT_IDS { get; set; }

        public long? OUT_TIME { get; set; }

        [StringLength(500)]
        public string TDL_PATIENT_AVATAR_URL { get; set; }

        public long? LAST_DEPARTMENT_ID { get; set; }

        [StringLength(150)]
        public string TDL_PATIENT_UNSIGNED_NAME { get; set; }

        public long? TREATMENT_END_TYPE_ID { get; set; }

        [StringLength(3000)]
        public string TREATMENT_METHOD { get; set; }

        [StringLength(20)]
        public string TDL_PATIENT_PHONE { get; set; }

        public long? TDL_HEIN_CARD_FROM_TIME { get; set; }

        public long? TDL_HEIN_CARD_TO_TIME { get; set; }

        [Required]
        [StringLength(100)]
        public string PATIENT_TYPE_NAME { get; set; }

        [StringLength(200)]
        public string BED_NAME { get; set; }

        [StringLength(10)]
        public string BED_CODE { get; set; }

        [Required]
        [StringLength(6)]
        public string PATIENT_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string BED_ROOM_NAME { get; set; }

        [StringLength(100)]
        public string PATIENT_CLASSIFY_NAME { get; set; }

        [StringLength(20)]
        public string DISPLAY_COLOR { get; set; }

        [StringLength(20)]
        public string TREATMENT_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string TREATMENT_ROOM_NAME { get; set; }

        [StringLength(20)]
        public string LAST_DEPARTMENT_CODE { get; set; }

        [StringLength(100)]
        public string LAST_DEPARTMENT_NAME { get; set; }
    }
}

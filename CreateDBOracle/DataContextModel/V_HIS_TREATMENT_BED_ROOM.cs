namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_TREATMENT_BED_ROOM")]
    public partial class V_HIS_TREATMENT_BED_ROOM
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

        public long TREATMENT_ID { get; set; }

        public long BED_ROOM_ID { get; set; }

        [StringLength(50)]
        public string ADD_LOGINNAME { get; set; }

        [StringLength(100)]
        public string ADD_USERNAME { get; set; }

        public long ADD_TIME { get; set; }

        [StringLength(50)]
        public string REMOVE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REMOVE_USERNAME { get; set; }

        public long? REMOVE_TIME { get; set; }

        public long? BED_ID { get; set; }

        public long? CO_TREATMENT_ID { get; set; }

        public long? TREATMENT_ROOM_ID { get; set; }

        public long? TDL_OBSERVED_TIME_FROM { get; set; }

        public long? TDL_OBSERVED_TIME_TO { get; set; }

        [Required]
        [StringLength(12)]
        public string TREATMENT_CODE { get; set; }

        public long PATIENT_ID { get; set; }

        [StringLength(200)]
        public string JSON_PRINT_ID { get; set; }

        public long IN_TIME { get; set; }

        public long? OUT_TIME { get; set; }

        [StringLength(20)]
        public string TDL_HEIN_CARD_NUMBER { get; set; }

        [Required]
        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [Required]
        [StringLength(30)]
        public string TDL_PATIENT_FIRST_NAME { get; set; }

        [StringLength(70)]
        public string TDL_PATIENT_LAST_NAME { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        [Required]
        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        public long TDL_PATIENT_DOB { get; set; }

        [Required]
        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        public long TDL_PATIENT_GENDER_ID { get; set; }

        [StringLength(6)]
        public string TDL_HEIN_MEDI_ORG_CODE { get; set; }

        [StringLength(500)]
        public string TDL_HEIN_MEDI_ORG_NAME { get; set; }

        [StringLength(500)]
        public string TDL_PATIENT_AVATAR_URL { get; set; }

        public long? TDL_TREATMENT_TYPE_ID { get; set; }

        public long? TDL_PATIENT_TYPE_ID { get; set; }

        [StringLength(10)]
        public string ICD_CODE { get; set; }

        [StringLength(500)]
        public string ICD_NAME { get; set; }

        [StringLength(4000)]
        public string ICD_TEXT { get; set; }

        [StringLength(500)]
        public string ICD_SUB_CODE { get; set; }

        public long? CLINICAL_IN_TIME { get; set; }

        public short? TREATMENT_IS_ACTIVE { get; set; }

        public short? IS_PAUSE { get; set; }

        public short? IS_LOCK_HEIN { get; set; }

        public short? IS_APPROVE_FINISH { get; set; }

        [StringLength(500)]
        public string APPROVE_FINISH_NOTE { get; set; }

        [StringLength(10)]
        public string ICD_CAUSE_CODE { get; set; }

        [StringLength(500)]
        public string ICD_CAUSE_NAME { get; set; }

        public long? OTHER_PAY_SOURCE_ID { get; set; }

        public long? TDL_PATIENT_CLASSIFY_ID { get; set; }

        public long ROOM_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string BED_ROOM_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string BED_ROOM_NAME { get; set; }

        [StringLength(200)]
        public string BED_NAME { get; set; }

        [StringLength(10)]
        public string BED_CODE { get; set; }

        [Required]
        [StringLength(6)]
        public string PATIENT_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string PATIENT_TYPE_NAME { get; set; }

        public long DEPARTMENT_ID { get; set; }

        [StringLength(10)]
        public string PATIENT_CLASSIFY_CODE { get; set; }

        [StringLength(100)]
        public string PATIENT_CLASSIFY_NAME { get; set; }
    }
}

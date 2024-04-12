namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_DEBATE")]
    public partial class V_HIS_DEBATE
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

        [Required]
        [StringLength(12)]
        public string TREATMENT_CODE { get; set; }

        public long PATIENT_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [Required]
        [StringLength(30)]
        public string TDL_PATIENT_FIRST_NAME { get; set; }

        [StringLength(70)]
        public string TDL_PATIENT_LAST_NAME { get; set; }

        [Required]
        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        public long TDL_PATIENT_DOB { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        [Required]
        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        [StringLength(10)]
        public string DEBATE_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string DEBATE_TYPE_NAME { get; set; }

        [StringLength(500)]
        public string SURGERY_SERVICE_NAME { get; set; }

        [StringLength(25)]
        public string SURGERY_SERVICE_CODE { get; set; }

        [StringLength(100)]
        public string EMOTIONLESS_METHOD_NAME { get; set; }

        [StringLength(6)]
        public string EMOTIONLESS_METHOD_CODE { get; set; }

        [StringLength(6)]
        public string PTTT_METHOD_CODE { get; set; }

        [StringLength(10)]
        public string DEBATE_REASON_CODE { get; set; }

        [StringLength(100)]
        public string DEBATE_REASON_NAME { get; set; }

        [StringLength(4000)]
        public string INVITE_USER_LOGINNAME { get; set; }

        [StringLength(25)]
        public string SERVICE_CODE { get; set; }

        [StringLength(500)]
        public string SERVICE_NAME { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_MEDICAL_ASSESSMENT")]
    public partial class V_HIS_MEDICAL_ASSESSMENT
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

        public long ASSESSMENT_OBJECT_ID { get; set; }

        public long? ASSESSMENT_TYPE_ID { get; set; }

        [StringLength(20)]
        public string WELFARE_TYPE_IDS { get; set; }

        public long ASSESSMENT_TIME_FROM { get; set; }

        [StringLength(20)]
        public string REPORT_NUMBER { get; set; }

        public decimal? PREVIOUS_INJURY_RATE { get; set; }

        [StringLength(20)]
        public string REFERRAL_CODE { get; set; }

        public long? REQUEST_TIME { get; set; }

        [StringLength(20)]
        public string REQUEST_ORG_CODE { get; set; }

        [StringLength(1000)]
        public string REQUEST_ORG_NAME { get; set; }

        [StringLength(4000)]
        public string EXAMINATION_RESULT { get; set; }

        [StringLength(200)]
        public string LEGAL_GROUND_NUMBERS { get; set; }

        public decimal? INJURY_RATE { get; set; }

        public decimal? INJURY_RATE_TOTAL { get; set; }

        public long? DISABILITY_TYPE_ID { get; set; }

        public long? DISABILITY_STATUS_ID { get; set; }

        [StringLength(4000)]
        public string REQUEST_AFTER_ASSESSMENT { get; set; }

        [StringLength(4000)]
        public string CONCLUSION { get; set; }

        [StringLength(200)]
        public string ASSESSMENT_BOARD_NAME { get; set; }

        public long? ASSESSMENT_TIME_TO { get; set; }

        [StringLength(4000)]
        public string ASSESSMENT_PURPOSE { get; set; }

        [StringLength(4000)]
        public string LEGAL_GROUND_DOCUMENTS { get; set; }

        [StringLength(4000)]
        public string ASSESSMENT_REQUEST_CONTENT { get; set; }

        [StringLength(4000)]
        public string PATHOLOGICAL_HISTORY { get; set; }

        [StringLength(4000)]
        public string DISCUSSION { get; set; }

        [Required]
        [StringLength(12)]
        public string TREATMENT_CODE { get; set; }

        [Required]
        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [Required]
        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        public long TDL_PATIENT_DOB { get; set; }

        [Required]
        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        public long IN_TIME { get; set; }

        public long? OUT_TIME { get; set; }

        [StringLength(20)]
        public string TDL_HEIN_CARD_NUMBER { get; set; }

        [StringLength(3)]
        public string TDL_PATIENT_NATIONAL_CODE { get; set; }

        public long? TDL_PATIENT_CCCD_DATE { get; set; }

        [StringLength(12)]
        public string TDL_PATIENT_CCCD_NUMBER { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_CCCD_PLACE { get; set; }

        public long? TDL_PATIENT_CMND_DATE { get; set; }

        [StringLength(9)]
        public string TDL_PATIENT_CMND_NUMBER { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_CMND_PLACE { get; set; }

        public long? TDL_PATIENT_PASSPORT_DATE { get; set; }

        [StringLength(9)]
        public string TDL_PATIENT_PASSPORT_NUMBER { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_PASSPORT_PLACE { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        [StringLength(3)]
        public string TDL_PATIENT_PROVINCE_CODE { get; set; }

        [StringLength(4)]
        public string TDL_PATIENT_DISTRICT_CODE { get; set; }

        [StringLength(6)]
        public string TDL_PATIENT_COMMUNE_CODE { get; set; }

        public long? NUMBER_OF_PREMATURE_BIRTH { get; set; }

        public long BRANCH_ID { get; set; }

        [StringLength(20)]
        public string TDL_SOCIAL_INSURANCE_NUMBER { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_COMMUNE_NAME { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_DISTRICT_NAME { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_NATIONAL_NAME { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_PROVINCE_NAME { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_CAREER_NAME { get; set; }

        [StringLength(12)]
        public string TDL_PATIENT_MOBILE { get; set; }

        [Required]
        [StringLength(10)]
        public string ASSESSMENT_OBJECT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string ASSESSMENT_OBJECT_NAME { get; set; }

        [StringLength(4000)]
        public string WELFARE_TYPE_NAMES { get; set; }

        [StringLength(100)]
        public string PRESIDENT_USERNAME { get; set; }

        [StringLength(100)]
        public string ON_BEHALF_USERNAME { get; set; }
    }
}

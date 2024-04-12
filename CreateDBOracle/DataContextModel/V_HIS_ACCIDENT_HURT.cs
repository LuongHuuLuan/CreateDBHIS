namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_ACCIDENT_HURT")]
    public partial class V_HIS_ACCIDENT_HURT
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

        [StringLength(200)]
        public string CONTENT { get; set; }

        public long ACCIDENT_HURT_TYPE_ID { get; set; }

        public long? ACCIDENT_BODY_PART_ID { get; set; }

        public long? ACCIDENT_LOCATION_ID { get; set; }

        public long? ACCIDENT_POISON_ID { get; set; }

        public long? ACCIDENT_VEHICLE_ID { get; set; }

        public long? ACCIDENT_HELMET_ID { get; set; }

        public long? ACCIDENT_RESULT_ID { get; set; }

        public long? ACCIDENT_CARE_ID { get; set; }

        public long? ACCIDENT_TIME { get; set; }

        public short? IS_USE_ALCOHOL { get; set; }

        public long? EXECUTE_ROOM_ID { get; set; }

        public long? EXECUTE_DEPARTMENT_ID { get; set; }

        [StringLength(50)]
        public string EXECUTE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string EXECUTE_USERNAME { get; set; }

        [StringLength(2000)]
        public string STATUS_IN { get; set; }

        [StringLength(2000)]
        public string STATUS_OUT { get; set; }

        [StringLength(4000)]
        public string TREATMENT_INFO { get; set; }

        public short? ALCOHOL_TEST_RESULT { get; set; }

        public short? NARCOTICS_TEST_RESULT { get; set; }

        [StringLength(10)]
        public string ISSUE_NUMBER { get; set; }

        [StringLength(50)]
        public string SEEDING_ISSUED_CODE { get; set; }

        [StringLength(61)]
        public string VIR_ISSUE_NUMBER { get; set; }

        [StringLength(10)]
        public string ACCIDENT_HURT_ICD_CODE { get; set; }

        [StringLength(500)]
        public string ACCIDENT_HURT_ICD_NAME { get; set; }

        [StringLength(500)]
        public string ACCIDENT_HURT_ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string ACCIDENT_HURT_ICD_TEXT { get; set; }

        [Required]
        [StringLength(10)]
        public string ACCIDENT_HURT_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string ACCIDENT_HURT_TYPE_NAME { get; set; }

        [StringLength(2)]
        public string BHYT_CODE { get; set; }

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

        [Required]
        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        public long? TDL_TREATMENT_TYPE_ID { get; set; }

        public long IN_TIME { get; set; }

        public long? OUT_TIME { get; set; }

        [StringLength(200)]
        public string HOSPITALIZATION_REASON { get; set; }

        [StringLength(10)]
        public string ICD_CODE { get; set; }

        [StringLength(500)]
        public string ICD_NAME { get; set; }

        [StringLength(500)]
        public string ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string ICD_TEXT { get; set; }

        [StringLength(2)]
        public string ACCIDENT_BODY_PART_CODE { get; set; }

        [StringLength(100)]
        public string ACCIDENT_BODY_PART_NAME { get; set; }

        [StringLength(2)]
        public string ACCIDENT_LOCATION_CODE { get; set; }

        [StringLength(100)]
        public string ACCIDENT_LOCATION_NAME { get; set; }

        [StringLength(2)]
        public string ACCIDENT_POISON_CODE { get; set; }

        [StringLength(100)]
        public string ACCIDENT_POISON_NAME { get; set; }

        [StringLength(2)]
        public string ACCIDENT_VEHICLE_CODE { get; set; }

        [StringLength(100)]
        public string ACCIDENT_VEHICLE_NAME { get; set; }

        [StringLength(2)]
        public string ACCIDENT_HELMET_CODE { get; set; }

        [StringLength(100)]
        public string ACCIDENT_HELMET_NAME { get; set; }

        [StringLength(2)]
        public string ACCIDENT_RESULT_CODE { get; set; }

        [StringLength(100)]
        public string ACCIDENT_RESULT_NAME { get; set; }

        [StringLength(2)]
        public string ACCIDENT_CARE_CODE { get; set; }

        [StringLength(100)]
        public string ACCIDENT_CARE_NAME { get; set; }

        [StringLength(20)]
        public string ROOM_CODE { get; set; }

        [StringLength(100)]
        public string ROOM_NAME { get; set; }

        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        [StringLength(2)]
        public string TREATMENT_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string TREATMENT_TYPE_NAME { get; set; }
    }
}

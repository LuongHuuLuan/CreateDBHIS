namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_KSK_DRIVER")]
    public partial class V_HIS_KSK_DRIVER
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
        [StringLength(30)]
        public string KSK_DRIVER_CODE { get; set; }

        public long SERVICE_REQ_ID { get; set; }

        public long TDL_TREATMENT_ID { get; set; }

        public long TDL_PATIENT_ID { get; set; }

        public long CONCLUSION_TIME { get; set; }

        [Required]
        [StringLength(20)]
        public string CONCLUSION { get; set; }

        [Required]
        [StringLength(20)]
        public string LICENSE_CLASS { get; set; }

        [StringLength(50)]
        public string CONCLUDER_LOGINNAME { get; set; }

        [StringLength(100)]
        public string CONCLUDER_USERNAME { get; set; }

        [StringLength(250)]
        public string REASON_BAD_HEATHLY { get; set; }

        [StringLength(250)]
        public string SICK_CONDITION { get; set; }

        public decimal? CONCENTRATION { get; set; }

        public long? CONCENTRATION_TYPE { get; set; }

        public long? DRUG_TYPE { get; set; }

        public long TDL_BRANCH_ID { get; set; }

        public long SYNC_RESULT_TYPE { get; set; }

        [StringLength(4000)]
        public string SYNC_FAILD_REASON { get; set; }

        public long? SYNC_TIME { get; set; }

        public decimal? VIR_CONCLUSION_DATE { get; set; }

        [Required]
        [StringLength(5)]
        public string TDL_MEDI_ORG_CODE { get; set; }

        public long? APPOINTMENT_TIME { get; set; }

        [Required]
        [StringLength(12)]
        public string SERVICE_REQ_CODE { get; set; }

        [Required]
        [StringLength(12)]
        public string TDL_TREATMENT_CODE { get; set; }

        [Required]
        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [Required]
        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        public long TDL_PATIENT_DOB { get; set; }

        public short? TDL_PATIENT_IS_HAS_NOT_DAY_DOB { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        public long? TDL_PATIENT_GENDER_ID { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        public long EXECUTE_ROOM_ID { get; set; }

        [StringLength(9)]
        public string CMND_NUMBER { get; set; }

        public long? CMND_DATE { get; set; }

        [StringLength(100)]
        public string CMND_PLACE { get; set; }

        [StringLength(12)]
        public string CCCD_NUMBER { get; set; }

        public long? CCCD_DATE { get; set; }

        [StringLength(100)]
        public string CCCD_PLACE { get; set; }

        [StringLength(3)]
        public string PROVINCE_CODE { get; set; }

        [StringLength(100)]
        public string PROVINCE_NAME { get; set; }

        [StringLength(4)]
        public string DISTRICT_CODE { get; set; }

        [StringLength(100)]
        public string DISTRICT_NAME { get; set; }

        [StringLength(6)]
        public string COMMUNE_CODE { get; set; }

        [StringLength(100)]
        public string COMMUNE_NAME { get; set; }

        [StringLength(9)]
        public string PASSPORT_NUMBER { get; set; }

        [StringLength(100)]
        public string PASSPORT_PLACE { get; set; }

        public long? PASSPORT_DATE { get; set; }

        [Required]
        [StringLength(20)]
        public string BRANCH_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string BRANCH_NAME { get; set; }

        [StringLength(20)]
        public string EXECUTE_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string EXECUTE_ROOM_NAME { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.L_HIS_SERVICE_REQ")]
    public partial class L_HIS_SERVICE_REQ
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [Required]
        [StringLength(12)]
        public string SERVICE_REQ_CODE { get; set; }

        [Required]
        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [Required]
        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        public long TDL_PATIENT_DOB { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        public long TREATMENT_ID { get; set; }

        [StringLength(500)]
        public string TDL_PATIENT_AVATAR_URL { get; set; }

        public long SERVICE_REQ_STT_ID { get; set; }

        public long? PARENT_ID { get; set; }

        public long EXECUTE_ROOM_ID { get; set; }

        public long? EXE_SERVICE_MODULE_ID { get; set; }

        [StringLength(200)]
        public string JSON_PRINT_ID { get; set; }

        public long REQUEST_DEPARTMENT_ID { get; set; }

        [Required]
        [StringLength(12)]
        public string TDL_TREATMENT_CODE { get; set; }

        public long? DHST_ID { get; set; }

        public long? PRIORITY { get; set; }

        public long REQUEST_ROOM_ID { get; set; }

        public long INTRUCTION_TIME { get; set; }

        public long? NUM_ORDER { get; set; }

        public long SERVICE_REQ_TYPE_ID { get; set; }

        public short? IS_WAIT_CHILD { get; set; }

        [StringLength(19)]
        public string TDL_HEIN_CARD_NUMBER { get; set; }

        public short? IS_NO_EXECUTE { get; set; }

        public long? TDL_TREATMENT_TYPE_ID { get; set; }

        public long? PTTT_APPROVAL_STT_ID { get; set; }

        public short? IS_EMERGENCY { get; set; }

        public long INTRUCTION_DATE { get; set; }

        [StringLength(50)]
        public string EXECUTE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string EXECUTE_USERNAME { get; set; }

        public long? EXE_DESK_ID { get; set; }

        public short? TDL_KSK_IS_REQUIRED_APPROVAL { get; set; }

        public short? TDL_IS_KSK_APPROVE { get; set; }

        public long? TDL_PATIENT_TYPE_ID { get; set; }

        public long? TDL_PATIENT_CLASSIFY_ID { get; set; }

        public short? IS_NOT_IN_DEBT { get; set; }

        public decimal? VIR_INTRUCTION_MONTH { get; set; }

        public short? IS_RESULTED { get; set; }

        public short? HAS_CHILD { get; set; }

        [StringLength(12)]
        public string TDL_PATIENT_PHONE { get; set; }

        [StringLength(12)]
        public string TDL_PATIENT_MOBILE { get; set; }

        public long? EXAM_END_TYPE { get; set; }

        public long? EXAM_TREATMENT_END_TYPE_ID { get; set; }

        public long? EXAM_TREATMENT_RESULT_ID { get; set; }

        public long? RESULTING_TIME { get; set; }

        public long? FINISH_TIME { get; set; }

        [StringLength(4000)]
        public string TDL_SERVICE_IDS { get; set; }

        [StringLength(10)]
        public string BLOCK { get; set; }

        public long? TDL_KSK_CONTRACT_ID { get; set; }

        public short? IS_ENOUGH_SUBCLINICAL_PRES { get; set; }

        public long? CALL_COUNT { get; set; }

        [StringLength(150)]
        public string TDL_PATIENT_UNSIGNED_NAME { get; set; }

        public long? PRIORITY_TYPE_ID { get; set; }

        public long? START_TIME { get; set; }

        public short? TDL_KSK_CONTRACT_IS_RESTRICTED { get; set; }

        [StringLength(2000)]
        public string NOTE { get; set; }

        public long TDL_PATIENT_ID { get; set; }

        [StringLength(2000)]
        public string MACHINE_NAMES { get; set; }

        public decimal? ORDER_TIME { get; set; }
    }
}

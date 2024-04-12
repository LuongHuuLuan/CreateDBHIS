namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_SERVICE_1")]
    public partial class V_HIS_SERVICE_1
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
        [StringLength(25)]
        public string SERVICE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string SERVICE_NAME { get; set; }

        public long SERVICE_TYPE_ID { get; set; }

        public long SERVICE_UNIT_ID { get; set; }

        public long? PARENT_ID { get; set; }

        public short? IS_LEAF { get; set; }

        public long? NUM_ORDER { get; set; }

        public long? HEIN_SERVICE_TYPE_ID { get; set; }

        [StringLength(100)]
        public string HEIN_SERVICE_BHYT_CODE { get; set; }

        [StringLength(500)]
        public string HEIN_SERVICE_BHYT_NAME { get; set; }

        [StringLength(20)]
        public string HEIN_ORDER { get; set; }

        public short? IS_USE_SERVICE_HEIN { get; set; }

        public decimal? HEIN_LIMIT_PRICE_OLD { get; set; }

        public decimal? HEIN_LIMIT_RATIO_OLD { get; set; }

        public decimal? HEIN_LIMIT_PRICE { get; set; }

        public decimal? HEIN_LIMIT_RATIO { get; set; }

        public long? HEIN_LIMIT_PRICE_IN_TIME { get; set; }

        public long? HEIN_LIMIT_PRICE_INTR_TIME { get; set; }

        [StringLength(3)]
        public string SPECIALITY_CODE { get; set; }

        public short? IS_MULTI_REQUEST { get; set; }

        public decimal? MAX_EXPEND { get; set; }

        public short? BILL_OPTION { get; set; }

        public long? BILL_PATIENT_TYPE_ID { get; set; }

        public short? IS_OUT_PARENT_FEE { get; set; }

        public long? PTTT_GROUP_ID { get; set; }

        public long? PTTT_METHOD_ID { get; set; }

        public long? ICD_CM_ID { get; set; }

        public decimal? COGS { get; set; }

        public decimal? ESTIMATE_DURATION { get; set; }

        public long? REVENUE_DEPARTMENT_ID { get; set; }

        public long? PACKAGE_ID { get; set; }

        public decimal? PACKAGE_PRICE { get; set; }

        public long? NUMBER_OF_FILM { get; set; }

        [StringLength(20)]
        public string PACS_TYPE_CODE { get; set; }

        public long? MIN_DURATION { get; set; }

        public long? EXE_SERVICE_MODULE_ID { get; set; }

        public long? GENDER_ID { get; set; }

        public long? AGE_FROM { get; set; }

        public long? AGE_TO { get; set; }

        public long? RATION_GROUP_ID { get; set; }

        [StringLength(10)]
        public string RATION_SYMBOL { get; set; }

        [StringLength(4000)]
        public string NOTICE { get; set; }

        public long? CAPACITY { get; set; }

        public short? IS_ALLOW_EXPEND { get; set; }

        public short? IS_NO_HEIN_LIMIT_FOR_SPECIAL { get; set; }

        public short? IS_KIDNEY { get; set; }

        public short? IS_SPECIFIC_HEIN_PRICE { get; set; }

        public short? IS_OTHER_SOURCE_PAID { get; set; }

        public short? IS_ANTIBIOTIC_RESISTANCE { get; set; }

        public long? DIIM_TYPE_ID { get; set; }

        public long? FUEX_TYPE_ID { get; set; }

        public long? TAX_RATE_TYPE { get; set; }

        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        public short? IS_SPLIT_SERVICE_REQ { get; set; }

        public short? IS_ENABLE_ASSIGN_PRICE { get; set; }

        public short? IS_AUTO_FINISH { get; set; }

        [StringLength(50)]
        public string PROCESS_CODE { get; set; }

        public long? TEST_TYPE_ID { get; set; }

        public short? IS_OUT_OF_DRG { get; set; }

        public short? IS_CONDITIONED { get; set; }

        public long? MIN_PROCESS_TIME { get; set; }

        public short? IS_NOT_CHANGE_BILL_PATY { get; set; }

        public short? IS_SPLIT_SERVICE { get; set; }

        public long? OTHER_PAY_SOURCE_ID { get; set; }

        [StringLength(200)]
        public string OTHER_PAY_SOURCE_ICDS { get; set; }

        [StringLength(200)]
        public string BODY_PART_IDS { get; set; }

        [StringLength(500)]
        public string TESTING_TECHNIQUE { get; set; }

        public short? IS_OUT_OF_MANAGEMENT { get; set; }

        public short? MUST_BE_CONSULTED { get; set; }

        public long? SUIM_INDEX_ID { get; set; }

        [StringLength(100)]
        public string ATTACH_ASSIGN_PRINT_TYPE_CODE { get; set; }

        public long? TEST_COVID_TYPE { get; set; }

        public long? MAX_PROCESS_TIME { get; set; }

        public short? IS_DISALLOWANCE_NO_EXECUTE { get; set; }

        public short? IS_NOT_SHOW_TRACKING { get; set; }

        public long? FILM_SIZE_ID { get; set; }

        public short? IS_AUTO_EXPEND { get; set; }

        public short? IS_BLOCK_DEPARTMENT_TRAN { get; set; }

        public long? WARNING_SAMPLING_TIME { get; set; }

        [StringLength(100)]
        public string APPLIED_PATIENT_TYPE_IDS { get; set; }

        public long? DEFAULT_PATIENT_TYPE_ID { get; set; }

        public long? MAX_TOTAL_PROCESS_TIME { get; set; }

        [Required]
        [StringLength(2)]
        public string SERVICE_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_TYPE_NAME { get; set; }

        public long? SETY_EXE_SERVICE_MODULE_ID { get; set; }

        public short? IS_AUTO_SPLIT_REQ { get; set; }

        [Required]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        [StringLength(2)]
        public string PTTT_GROUP_CODE { get; set; }

        [StringLength(100)]
        public string PTTT_GROUP_NAME { get; set; }

        [StringLength(6)]
        public string PTTT_METHOD_CODE { get; set; }

        [StringLength(1000)]
        public string PTTT_METHOD_NAME { get; set; }

        [StringLength(10)]
        public string ICD_CM_CODE { get; set; }

        [StringLength(1000)]
        public string ICD_CM_NAME { get; set; }
    }
}

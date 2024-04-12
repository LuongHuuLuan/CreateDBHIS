namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_SERE_SERV_1")]
    public partial class V_HIS_SERE_SERV_1
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

        public long SERVICE_ID { get; set; }

        public long? SERVICE_REQ_ID { get; set; }

        public long PATIENT_TYPE_ID { get; set; }

        public long? PRIMARY_PATIENT_TYPE_ID { get; set; }

        public decimal? PRIMARY_PRICE { get; set; }

        public decimal? LIMIT_PRICE { get; set; }

        public long? PARENT_ID { get; set; }

        public long? HEIN_APPROVAL_ID { get; set; }

        [StringLength(2000)]
        public string JSON_PATIENT_TYPE_ALTER { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal PRICE { get; set; }

        public decimal ORIGINAL_PRICE { get; set; }

        public decimal? HEIN_PRICE { get; set; }

        public decimal? HEIN_RATIO { get; set; }

        public decimal? HEIN_LIMIT_PRICE { get; set; }

        public decimal? HEIN_LIMIT_RATIO { get; set; }

        public decimal? HEIN_NORMAL_PRICE { get; set; }

        public decimal? ADD_PRICE { get; set; }

        public decimal? OVERTIME_PRICE { get; set; }

        public decimal? DISCOUNT { get; set; }

        public decimal VAT_RATIO { get; set; }

        public long? SHARE_COUNT { get; set; }

        public long? STENT_ORDER { get; set; }

        public short? IS_EXPEND { get; set; }

        public short? IS_NO_PAY { get; set; }

        public short? IS_NO_EXECUTE { get; set; }

        public short? IS_OUT_PARENT_FEE { get; set; }

        public short? IS_NO_HEIN_DIFFERENCE { get; set; }

        public short? IS_SPECIMEN { get; set; }

        public short? IS_ADDITION { get; set; }

        public short? IS_SENT_EXT { get; set; }

        public long? EXECUTE_TIME { get; set; }

        [StringLength(15)]
        public string HEIN_CARD_NUMBER { get; set; }

        public long? MEDICINE_ID { get; set; }

        public long? MATERIAL_ID { get; set; }

        public long? EXP_MEST_MEDICINE_ID { get; set; }

        public long? EXP_MEST_MATERIAL_ID { get; set; }

        public long? BLOOD_ID { get; set; }

        public long? EKIP_ID { get; set; }

        public long? PACKAGE_ID { get; set; }

        public long? EQUIPMENT_SET_ID { get; set; }

        public long? EQUIPMENT_SET_ORDER { get; set; }

        public long TDL_INTRUCTION_TIME { get; set; }

        public long TDL_INTRUCTION_DATE { get; set; }

        public long? TDL_PATIENT_ID { get; set; }

        public long? TDL_TREATMENT_ID { get; set; }

        [StringLength(12)]
        public string TDL_TREATMENT_CODE { get; set; }

        [Required]
        [StringLength(25)]
        public string TDL_SERVICE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string TDL_SERVICE_NAME { get; set; }

        [StringLength(100)]
        public string TDL_HEIN_SERVICE_BHYT_CODE { get; set; }

        [StringLength(500)]
        public string TDL_HEIN_SERVICE_BHYT_NAME { get; set; }

        [StringLength(20)]
        public string TDL_HEIN_ORDER { get; set; }

        public long TDL_SERVICE_TYPE_ID { get; set; }

        public long TDL_SERVICE_UNIT_ID { get; set; }

        public long? TDL_HEIN_SERVICE_TYPE_ID { get; set; }

        [StringLength(500)]
        public string TDL_ACTIVE_INGR_BHYT_CODE { get; set; }

        [StringLength(1000)]
        public string TDL_ACTIVE_INGR_BHYT_NAME { get; set; }

        [StringLength(1000)]
        public string TDL_MEDICINE_CONCENTRA { get; set; }

        [StringLength(50)]
        public string TDL_MEDICINE_BID_NUM_ORDER { get; set; }

        [StringLength(500)]
        public string TDL_MEDICINE_REGISTER_NUMBER { get; set; }

        [StringLength(100)]
        public string TDL_MEDICINE_PACKAGE_NUMBER { get; set; }

        [StringLength(12)]
        public string TDL_SERVICE_REQ_CODE { get; set; }

        public long TDL_REQUEST_ROOM_ID { get; set; }

        public long TDL_REQUEST_DEPARTMENT_ID { get; set; }

        [StringLength(50)]
        public string TDL_REQUEST_LOGINNAME { get; set; }

        [StringLength(100)]
        public string TDL_REQUEST_USERNAME { get; set; }

        public long TDL_EXECUTE_ROOM_ID { get; set; }

        public long TDL_EXECUTE_DEPARTMENT_ID { get; set; }

        public long TDL_EXECUTE_BRANCH_ID { get; set; }

        public long? TDL_EXECUTE_GROUP_ID { get; set; }

        [StringLength(3)]
        public string TDL_SPECIALITY_CODE { get; set; }

        public long TDL_SERVICE_REQ_TYPE_ID { get; set; }

        [StringLength(2)]
        public string TDL_HST_BHYT_CODE { get; set; }

        [StringLength(20)]
        public string TDL_PACS_TYPE_CODE { get; set; }

        public short? TDL_IS_MAIN_EXAM { get; set; }

        public short? TDL_BILL_OPTION { get; set; }

        [StringLength(500)]
        public string TDL_MATERIAL_GROUP_BHYT { get; set; }

        public short? TDL_IS_SPECIFIC_HEIN_PRICE { get; set; }

        public long? EXPEND_TYPE_ID { get; set; }

        public long? INVOICE_ID { get; set; }

        public short? USE_ORIGINAL_UNIT_FOR_PRES { get; set; }

        public decimal? AMOUNT_TEMP { get; set; }

        public short? IS_FUND_ACCEPTED { get; set; }

        public short? IS_OTHER_SOURCE_PAID { get; set; }

        public short? IS_NOT_PRES { get; set; }

        public short? IS_USER_PACKAGE_PRICE { get; set; }

        public decimal? PACKAGE_PRICE { get; set; }

        public decimal? USER_PRICE { get; set; }

        public decimal? PATIENT_PRICE_BHYT { get; set; }

        public decimal? OTHER_SOURCE_PRICE { get; set; }

        public decimal? VIR_PRICE { get; set; }

        public decimal? VIR_PRICE_NO_ADD_PRICE { get; set; }

        public decimal? VIR_PRICE_NO_EXPEND { get; set; }

        public decimal? VIR_HEIN_PRICE { get; set; }

        public decimal? VIR_PATIENT_PRICE { get; set; }

        public decimal? VIR_PATIENT_PRICE_BHYT { get; set; }

        public decimal? VIR_TOTAL_PRICE { get; set; }

        public decimal? VIR_TOTAL_PRICE_NO_ADD_PRICE { get; set; }

        public decimal? VIR_TOTAL_PRICE_NO_EXPEND { get; set; }

        public decimal? VIR_TOTAL_HEIN_PRICE { get; set; }

        public decimal? VIR_TOTAL_PATIENT_PRICE { get; set; }

        public decimal? VIR_TOTAL_PATIENT_PRICE_BHYT { get; set; }

        public decimal? VIR_TOTAL_PATIENT_PRICE_NO_DC { get; set; }

        public decimal? VIR_TOTAL_PATIENT_PRICE_TEMP { get; set; }

        public long? OTHER_PAY_SOURCE_ID { get; set; }

        public long? TDL_SERVICE_TAX_RATE_TYPE { get; set; }

        public decimal? CONFIG_HEIN_LIMIT_PRICE { get; set; }

        [StringLength(2000)]
        public string TDL_SERVICE_DESCRIPTION { get; set; }

        public short? TDL_IS_OUT_OF_DRG { get; set; }

        public long? SERVICE_CONDITION_ID { get; set; }

        public short? IS_ACCEPTING_NO_EXECUTE { get; set; }

        [StringLength(100)]
        public string TDL_REQUEST_USER_TITLE { get; set; }

        [StringLength(50)]
        public string DISCOUNT_LOGINNAME { get; set; }

        [StringLength(100)]
        public string DISCOUNT_USERNAME { get; set; }

        public long INTRUCTION_TIME { get; set; }

        public long? FINISH_TIME { get; set; }

        public long SERVICE_REQ_STT_ID { get; set; }

        [StringLength(500)]
        public string TREATMENT_INSTRUCTION { get; set; }

        [StringLength(2000)]
        public string NOTE { get; set; }

        [StringLength(19)]
        public string TDL_HEIN_CARD_NUMBER { get; set; }

        [Required]
        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [Required]
        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        [Required]
        [StringLength(30)]
        public string TDL_PATIENT_FIRST_NAME { get; set; }

        [StringLength(70)]
        public string TDL_PATIENT_LAST_NAME { get; set; }

        public long TDL_PATIENT_DOB { get; set; }

        public short? TDL_PATIENT_IS_HAS_NOT_DAY_DOB { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        public long? TDL_PATIENT_GENDER_ID { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_CAREER_NAME { get; set; }

        [StringLength(500)]
        public string TDL_PATIENT_WORK_PLACE { get; set; }

        [StringLength(500)]
        public string TDL_PATIENT_WORK_PLACE_NAME { get; set; }

        [StringLength(4)]
        public string TDL_PATIENT_DISTRICT_CODE { get; set; }

        [StringLength(3)]
        public string TDL_PATIENT_PROVINCE_CODE { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_MILITARY_RANK_NAME { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_NATIONAL_NAME { get; set; }

        [StringLength(6)]
        public string TDL_HEIN_MEDI_ORG_CODE { get; set; }

        [StringLength(500)]
        public string TDL_HEIN_MEDI_ORG_NAME { get; set; }

        [StringLength(500)]
        public string TDL_PATIENT_AVATAR_URL { get; set; }

        public long? PLAN_TIME_FROM { get; set; }

        public long? PLAN_TIME_TO { get; set; }

        public long? RATION_TIME_ID { get; set; }

        public long? RATION_SUM_ID { get; set; }

        public long EXECUTE_ROOM_ID { get; set; }

        public long SERVICE_REQ_TYPE_ID { get; set; }

        public short? IS_EMERGENCY { get; set; }

        public long? PTTT_APPROVAL_STT_ID { get; set; }

        public long? SERVICE_REQ_PARENT_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string EXECUTE_DEPARTMENT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string EXECUTE_DEPARTMENT_NAME { get; set; }

        public long EXECUTE_BRANCH_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string REQUEST_DEPARTMENT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string REQUEST_DEPARTMENT_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        [Required]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        public long? PATIENT_CLASSIFY_ID { get; set; }

        [StringLength(10)]
        public string PATIENT_CLASSIFY_CODE { get; set; }

        [StringLength(100)]
        public string PATIENT_CLASSIFY_NAME { get; set; }
    }
}

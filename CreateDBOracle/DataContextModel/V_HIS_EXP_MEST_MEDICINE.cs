namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_EXP_MEST_MEDICINE")]
    public partial class V_HIS_EXP_MEST_MEDICINE
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

        public decimal? BK_AMOUNT { get; set; }

        public long? EXP_MEST_ID { get; set; }

        public long? MEDICINE_ID { get; set; }

        public long? TDL_MEDI_STOCK_ID { get; set; }

        public long? MEDI_STOCK_PERIOD_ID { get; set; }

        public long? TDL_MEDICINE_TYPE_ID { get; set; }

        public long? TDL_AGGR_EXP_MEST_ID { get; set; }

        public long? EXP_MEST_METY_REQ_ID { get; set; }

        public long? CK_IMP_MEST_MEDICINE_ID { get; set; }

        public short? IS_EXPORT { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal? PRICE { get; set; }

        public decimal? VAT_RATIO { get; set; }

        public decimal? DISCOUNT { get; set; }

        public long? NUM_ORDER { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        [StringLength(50)]
        public string APPROVAL_LOGINNAME { get; set; }

        [StringLength(100)]
        public string APPROVAL_USERNAME { get; set; }

        public long? APPROVAL_TIME { get; set; }

        public long? APPROVAL_DATE { get; set; }

        [StringLength(50)]
        public string EXP_LOGINNAME { get; set; }

        [StringLength(100)]
        public string EXP_USERNAME { get; set; }

        public long? EXP_TIME { get; set; }

        public long? EXP_DATE { get; set; }

        public decimal? TH_AMOUNT { get; set; }

        public long? PATIENT_TYPE_ID { get; set; }

        public long? SERE_SERV_PARENT_ID { get; set; }

        public short? IS_EXPEND { get; set; }

        public short? IS_OUT_PARENT_FEE { get; set; }

        public long? USE_TIME_TO { get; set; }

        [StringLength(1000)]
        public string TUTORIAL { get; set; }

        public long? TDL_SERVICE_REQ_ID { get; set; }

        public long? TDL_TREATMENT_ID { get; set; }

        public short? IS_USE_CLIENT_PRICE { get; set; }

        public decimal? VIR_PRICE { get; set; }

        public long? VACCINATION_RESULT_ID { get; set; }

        public long? TDL_VACCINATION_ID { get; set; }

        public decimal? SPEED { get; set; }

        public long? EXPEND_TYPE_ID { get; set; }

        public short? IS_NOT_PRES { get; set; }

        public short? USE_ORIGINAL_UNIT_FOR_PRES { get; set; }

        public decimal? BCS_REQ_AMOUNT { get; set; }

        public long? DAY_COUNT { get; set; }

        [StringLength(10)]
        public string MORNING { get; set; }

        [StringLength(10)]
        public string NOON { get; set; }

        [StringLength(10)]
        public string AFTERNOON { get; set; }

        [StringLength(10)]
        public string EVENING { get; set; }

        public long? HTU_ID { get; set; }

        [StringLength(10)]
        public string BREATH_SPEED { get; set; }

        [StringLength(10)]
        public string BREATH_TIME { get; set; }

        public long? PREVIOUS_USING_COUNT { get; set; }

        public short? IS_USED { get; set; }

        public long? SERVICE_CONDITION_ID { get; set; }

        public short? IS_CREATED_BY_APPROVAL { get; set; }

        public long? OTHER_PAY_SOURCE_ID { get; set; }

        public long? MIXED_INFUSION { get; set; }

        [StringLength(500)]
        public string TUTORIAL_INFUSION { get; set; }

        public short? IS_MIXED_MAIN { get; set; }

        public long? VACCINE_TURN { get; set; }

        public decimal? PRES_AMOUNT { get; set; }

        [StringLength(2000)]
        public string EXCEED_LIMIT_IN_PRES_REASON { get; set; }

        [StringLength(2000)]
        public string EXCEED_LIMIT_IN_DAY_REASON { get; set; }

        [StringLength(2000)]
        public string ODD_PRES_REASON { get; set; }

        [StringLength(2000)]
        public string OVER_RESULT_TEST_REASON { get; set; }

        [StringLength(2000)]
        public string OVER_KIDNEY_REASON { get; set; }

        [Required]
        [StringLength(12)]
        public string EXP_MEST_CODE { get; set; }

        public long EXP_MEST_TYPE_ID { get; set; }

        public long? AGGR_EXP_MEST_ID { get; set; }

        public long MEDI_STOCK_ID { get; set; }

        public long EXP_MEST_STT_ID { get; set; }

        public long REQ_ROOM_ID { get; set; }

        public long REQ_DEPARTMENT_ID { get; set; }

        public long? TDL_INTRUCTION_TIME { get; set; }

        [StringLength(100)]
        public string REQ_USER_TITLE { get; set; }

        [StringLength(100)]
        public string TDL_PRES_REQ_USER_TITLE { get; set; }

        [StringLength(50)]
        public string REQ_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REQ_USERNAME { get; set; }

        public long? TDL_PATIENT_ID { get; set; }

        public decimal IMP_PRICE { get; set; }

        public decimal IMP_VAT_RATIO { get; set; }

        public long? BID_ID { get; set; }

        [StringLength(100)]
        public string PACKAGE_NUMBER { get; set; }

        public long? EXPIRED_DATE { get; set; }

        public long MEDICINE_TYPE_ID { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        public long? IMP_TIME { get; set; }

        public long? SUPPLIER_ID { get; set; }

        [StringLength(20)]
        public string MEDICINE_TCY_NUM_ORDER { get; set; }

        [StringLength(50)]
        public string MEDICINE_BYT_NUM_ORDER { get; set; }

        [StringLength(500)]
        public string MEDICINE_REGISTER_NUMBER { get; set; }

        [StringLength(500)]
        public string ACTIVE_INGR_BHYT_CODE { get; set; }

        [StringLength(1000)]
        public string ACTIVE_INGR_BHYT_NAME { get; set; }

        [StringLength(1000)]
        public string CONCENTRA { get; set; }

        public decimal? TAX_RATIO { get; set; }

        [Required]
        [StringLength(25)]
        public string MEDICINE_TYPE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string MEDICINE_TYPE_NAME { get; set; }

        public long SERVICE_ID { get; set; }

        [StringLength(1000)]
        public string NATIONAL_NAME { get; set; }

        public long? MANUFACTURER_ID { get; set; }

        public long? MEDICINE_TYPE_NUM_ORDER { get; set; }

        [StringLength(20)]
        public string TCY_NUM_ORDER { get; set; }

        [StringLength(50)]
        public string BYT_NUM_ORDER { get; set; }

        [StringLength(500)]
        public string REGISTER_NUMBER { get; set; }

        public short? IS_FUNCTIONAL_FOOD { get; set; }

        public long? MEMA_GROUP_ID { get; set; }

        public short? IS_ALLOW_ODD { get; set; }

        public long? MEDICINE_GROUP_ID { get; set; }

        public long SERVICE_UNIT_ID { get; set; }

        [StringLength(20)]
        public string RECORDING_TRANSACTION { get; set; }

        public long? MEDICINE_USE_FORM_ID { get; set; }

        public short? IS_OUT_HOSPITAL { get; set; }

        [Required]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        public long? MEDICINE_NUM_ORDER { get; set; }

        public long? MATERIAL_NUM_ORDER { get; set; }

        public decimal? CONVERT_RATIO { get; set; }

        [StringLength(6)]
        public string MANUFACTURER_CODE { get; set; }

        [StringLength(1000)]
        public string MANUFACTURER_NAME { get; set; }

        [StringLength(10)]
        public string SUPPLIER_CODE { get; set; }

        [StringLength(1000)]
        public string SUPPLIER_NAME { get; set; }

        [StringLength(30)]
        public string BID_NUMBER { get; set; }

        [StringLength(500)]
        public string BID_NAME { get; set; }

        [StringLength(6)]
        public string PATIENT_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string PATIENT_TYPE_NAME { get; set; }

        public short? IS_RATION { get; set; }

        [StringLength(3)]
        public string CONVERT_UNIT_CODE { get; set; }

        [StringLength(100)]
        public string CONVERT_UNIT_NAME { get; set; }

        [StringLength(100)]
        public string HTU_NAME { get; set; }

        [StringLength(4)]
        public string MEDICINE_GROUP_CODE { get; set; }

        [StringLength(100)]
        public string MEDICINE_GROUP_NAME { get; set; }

        public long? MEDICINE_GROUP_NUM_ORDER { get; set; }

        [StringLength(6)]
        public string MEDICINE_USE_FORM_CODE { get; set; }

        [StringLength(100)]
        public string MEDICINE_USE_FORM_NAME { get; set; }

        public long? MEDICINE_USE_FORM_NUM_ORDER { get; set; }

        [StringLength(20)]
        public string MEDI_STOCK_CODE { get; set; }

        [StringLength(100)]
        public string MEDI_STOCK_NAME { get; set; }

        [StringLength(20)]
        public string OTHER_PAY_SOURCE_CODE { get; set; }

        [StringLength(200)]
        public string OTHER_PAY_SOURCE_NAME { get; set; }
    }
}

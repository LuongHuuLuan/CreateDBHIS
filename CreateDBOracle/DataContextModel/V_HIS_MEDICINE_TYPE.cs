namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_MEDICINE_TYPE")]
    public partial class V_HIS_MEDICINE_TYPE
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
        public string MEDICINE_TYPE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string MEDICINE_TYPE_NAME { get; set; }

        public long SERVICE_ID { get; set; }

        public long? PARENT_ID { get; set; }

        public short? IS_LEAF { get; set; }

        public long? NUM_ORDER { get; set; }

        [StringLength(1000)]
        public string CONCENTRA { get; set; }

        [StringLength(500)]
        public string ACTIVE_INGR_BHYT_CODE { get; set; }

        [StringLength(1000)]
        public string ACTIVE_INGR_BHYT_NAME { get; set; }

        [StringLength(500)]
        public string REGISTER_NUMBER { get; set; }

        public long? PACKING_TYPE_ID__DELETE { get; set; }

        public long? MANUFACTURER_ID { get; set; }

        public long? MEDICINE_USE_FORM_ID { get; set; }

        public long? MEDICINE_LINE_ID { get; set; }

        public long? MEDICINE_GROUP_ID { get; set; }

        public long TDL_SERVICE_UNIT_ID { get; set; }

        public long? TDL_GENDER_ID { get; set; }

        [StringLength(1000)]
        public string NATIONAL_NAME { get; set; }

        [StringLength(2000)]
        public string TUTORIAL { get; set; }

        public decimal? IMP_PRICE { get; set; }

        public decimal? IMP_VAT_RATIO { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        public decimal? ALERT_MAX_IN_TREATMENT { get; set; }

        public long? ALERT_EXPIRED_DATE { get; set; }

        public decimal? ALERT_MIN_IN_STOCK { get; set; }

        public decimal? ALERT_MAX_IN_PRESCRIPTION { get; set; }

        public short? IS_STOP_IMP { get; set; }

        public short? IS_STAR_MARK { get; set; }

        public short? IS_ALLOW_ODD { get; set; }

        public short? IS_ALLOW_EXPORT_ODD { get; set; }

        public short? IS_FUNCTIONAL_FOOD { get; set; }

        public short? IS_REQUIRE_HSD { get; set; }

        public short? IS_SALE_EQUAL_IMP_PRICE { get; set; }

        public short? IS_BUSINESS { get; set; }

        public short? IS_RAW_MEDICINE { get; set; }

        public short? IS_AUTO_EXPEND { get; set; }

        public short? IS_VITAMIN_A { get; set; }

        public short? IS_VACCINE { get; set; }

        public short? IS_TCMR { get; set; }

        public short? IS_MUST_PREPARE { get; set; }

        public decimal? USE_ON_DAY { get; set; }

        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        public long? MEMA_GROUP_ID { get; set; }

        [StringLength(50)]
        public string BYT_NUM_ORDER { get; set; }

        [StringLength(20)]
        public string TCY_NUM_ORDER { get; set; }

        [StringLength(200)]
        public string MEDICINE_TYPE_PROPRIETARY_NAME { get; set; }

        [StringLength(300)]
        public string PACKING_TYPE_NAME { get; set; }

        public long? RANK { get; set; }

        [StringLength(30)]
        public string MEDICINE_NATIONAL_CODE { get; set; }

        public short? IS_KIDNEY { get; set; }

        public short? IS_CHEMICAL_SUBSTANCE { get; set; }

        public decimal? LAST_EXP_PRICE { get; set; }

        public decimal? LAST_EXP_VAT_RATIO { get; set; }

        [StringLength(4000)]
        public string CONTRAINDICATION { get; set; }

        public decimal? LAST_IMP_PRICE { get; set; }

        public decimal? LAST_IMP_VAT_RATIO { get; set; }

        [StringLength(500)]
        public string ATC_CODES { get; set; }

        public long? LAST_EXPIRED_DATE { get; set; }

        [StringLength(20)]
        public string RECORDING_TRANSACTION { get; set; }

        public short? IS_TREATMENT_DAY_COUNT { get; set; }

        public short? ALLOW_MISSING_PKG_INFO { get; set; }

        public short? IS_BLOCK_MAX_IN_PRESCRIPTION { get; set; }

        public short? IS_OXYGEN { get; set; }

        public short? IS_SPLIT_COMPENSATION { get; set; }

        public long? STORAGE_CONDITION_ID { get; set; }

        [StringLength(500)]
        public string CONTRAINDICATION_IDS { get; set; }

        public short? IS_OUT_HOSPITAL { get; set; }

        public long? IMP_UNIT_ID { get; set; }

        public decimal? IMP_UNIT_CONVERT_RATIO { get; set; }

        [StringLength(500)]
        public string SCIENTIFIC_NAME { get; set; }

        [StringLength(1000)]
        public string PREPROCESSING { get; set; }

        [StringLength(1000)]
        public string PROCESSING { get; set; }

        [StringLength(500)]
        public string USED_PART { get; set; }

        [StringLength(2000)]
        public string DOSAGE_FORM { get; set; }

        [StringLength(500)]
        public string DISTRIBUTED_AMOUNT { get; set; }

        public short? IS_NOT_TREATMENT_DAY_COUNT { get; set; }

        public short? IS_ANAESTHESIA { get; set; }

        public long? VACCINE_TYPE_ID { get; set; }

        [StringLength(1000)]
        public string QUALITY_STANDARDS { get; set; }

        public short? SOURCE_MEDICINE { get; set; }

        public short? IS_DRUG_STORE { get; set; }

        [StringLength(4000)]
        public string LOCKING_REASON { get; set; }

        [StringLength(255)]
        public string PREPROCESSING_CODE { get; set; }

        [StringLength(255)]
        public string PROCESSING_CODE { get; set; }

        [StringLength(50)]
        public string NUM_ORDER_CIRCULARS20 { get; set; }

        public short? IS_BLOCK_MAX_IN_DAY { get; set; }

        public decimal? ALERT_MAX_IN_DAY { get; set; }

        public long? HTU_ID { get; set; }

        [StringLength(2000)]
        public string ODD_WARNING_CONTENT { get; set; }

        public short? IS_ORIGINAL_BRAND_NAME { get; set; }

        public short? IS_GENERIC { get; set; }

        public short? IS_BIOLOGIC { get; set; }

        public long SERVICE_UNIT_ID { get; set; }

        public long SERVICE_TYPE_ID { get; set; }

        public long? HEIN_SERVICE_TYPE_ID { get; set; }

        public short? BILL_OPTION { get; set; }

        public short? IS_OUT_PARENT_FEE { get; set; }

        [StringLength(100)]
        public string HEIN_SERVICE_BHYT_CODE { get; set; }

        [StringLength(500)]
        public string HEIN_SERVICE_BHYT_NAME { get; set; }

        [StringLength(20)]
        public string HEIN_ORDER { get; set; }

        public decimal? HEIN_LIMIT_PRICE_OLD { get; set; }

        public decimal? HEIN_LIMIT_PRICE { get; set; }

        public decimal? HEIN_LIMIT_RATIO_OLD { get; set; }

        public decimal? HEIN_LIMIT_RATIO { get; set; }

        public long? HEIN_LIMIT_PRICE_IN_TIME { get; set; }

        public long? HEIN_LIMIT_PRICE_INTR_TIME { get; set; }

        public short? IS_NO_HEIN_LIMIT_FOR_SPECIAL { get; set; }

        public short? IS_OTHER_SOURCE_PAID { get; set; }

        [Required]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        public decimal? CONVERT_RATIO { get; set; }

        [StringLength(6)]
        public string MANUFACTURER_CODE { get; set; }

        [StringLength(1000)]
        public string MANUFACTURER_NAME { get; set; }

        [StringLength(10)]
        public string HEIN_SERVICE_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string HEIN_SERVICE_TYPE_NAME { get; set; }

        [StringLength(2)]
        public string MEDICINE_LINE_CODE { get; set; }

        [StringLength(100)]
        public string MEDICINE_LINE_NAME { get; set; }

        public long? MEDICINE_LINE_NUM_ORDER { get; set; }

        public short? DO_NOT_REQUIRED_USE_FORM { get; set; }

        [StringLength(6)]
        public string MEDICINE_USE_FORM_CODE { get; set; }

        [StringLength(100)]
        public string MEDICINE_USE_FORM_NAME { get; set; }

        public long? MEDICINE_USE_FORM_NUM_ORDER { get; set; }

        [StringLength(4)]
        public string MEDICINE_GROUP_CODE { get; set; }

        [StringLength(100)]
        public string MEDICINE_GROUP_NAME { get; set; }

        public long? MEDICINE_GROUP_NUM_ORDER { get; set; }

        [StringLength(3)]
        public string CONVERT_UNIT_CODE { get; set; }

        [StringLength(100)]
        public string CONVERT_UNIT_NAME { get; set; }

        [StringLength(3)]
        public string IMP_UNIT_CODE { get; set; }

        [StringLength(100)]
        public string IMP_UNIT_NAME { get; set; }

        [StringLength(25)]
        public string PARENT_CODE { get; set; }

        [StringLength(500)]
        public string PARENT_NAME { get; set; }
    }
}

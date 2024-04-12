namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_MEDICINE_TYPE_1")]
    public partial class V_HIS_MEDICINE_TYPE_1
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

        [Required]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        [StringLength(204)]
        public string MEDICINE_INFO { get; set; }
    }
}

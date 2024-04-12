namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_MATERIAL_TYPE")]
    public partial class V_HIS_MATERIAL_TYPE
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
        public string MATERIAL_TYPE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string MATERIAL_TYPE_NAME { get; set; }

        public long SERVICE_ID { get; set; }

        public long? PARENT_ID { get; set; }

        public short? IS_LEAF { get; set; }

        public long? NUM_ORDER { get; set; }

        [StringLength(1000)]
        public string CONCENTRA { get; set; }

        public long? PACKING_TYPE_ID__DELETE { get; set; }

        public long? MANUFACTURER_ID { get; set; }

        public long TDL_SERVICE_UNIT_ID { get; set; }

        public long? TDL_GENDER_ID { get; set; }

        [StringLength(100)]
        public string NATIONAL_NAME { get; set; }

        public decimal? IMP_PRICE { get; set; }

        public decimal? IMP_VAT_RATIO { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        public long? ALERT_EXPIRED_DATE { get; set; }

        public decimal? ALERT_MIN_IN_STOCK { get; set; }

        public decimal? ALERT_MAX_IN_PRESCRIPTION { get; set; }

        public short? IS_CHEMICAL_SUBSTANCE { get; set; }

        public short? IS_AUTO_EXPEND { get; set; }

        public short? IS_STENT { get; set; }

        public short? IS_IN_KTC_FEE { get; set; }

        public short? IS_ALLOW_ODD { get; set; }

        public short? IS_ALLOW_EXPORT_ODD { get; set; }

        public short? IS_STOP_IMP { get; set; }

        public short? IS_REQUIRE_HSD { get; set; }

        public short? IS_SALE_EQUAL_IMP_PRICE { get; set; }

        public short? IS_BUSINESS { get; set; }

        public short? IS_RAW_MATERIAL { get; set; }

        public short? IS_MUST_PREPARE { get; set; }

        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        public long? MEMA_GROUP_ID { get; set; }

        [StringLength(300)]
        public string PACKING_TYPE_NAME { get; set; }

        public short? IS_REUSABLE { get; set; }

        public long? MAX_REUSE_COUNT { get; set; }

        [StringLength(500)]
        public string MATERIAL_GROUP_BHYT { get; set; }

        public long? MATERIAL_TYPE_MAP_ID { get; set; }

        public decimal? LAST_EXP_PRICE { get; set; }

        public decimal? LAST_EXP_VAT_RATIO { get; set; }

        public decimal? LAST_IMP_PRICE { get; set; }

        public decimal? LAST_IMP_VAT_RATIO { get; set; }

        public long? FILM_SIZE_ID { get; set; }

        public short? IS_FILM { get; set; }

        public long? LAST_EXPIRED_DATE { get; set; }

        [StringLength(20)]
        public string RECORDING_TRANSACTION { get; set; }

        [StringLength(500)]
        public string REGISTER_NUMBER { get; set; }

        public short? IS_CONSUMABLE { get; set; }

        public short? IS_OUT_HOSPITAL { get; set; }

        public long? IMP_UNIT_ID { get; set; }

        public decimal? IMP_UNIT_CONVERT_RATIO { get; set; }

        public short? IS_DRUG_STORE { get; set; }

        public short? IS_NOT_SHOW_TRACKING { get; set; }

        [StringLength(4000)]
        public string LOCKING_REASON { get; set; }

        public decimal? ALERT_MAX_IN_DAY { get; set; }

        [StringLength(250)]
        public string MODEL_CODE { get; set; }

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

        [StringLength(3)]
        public string CONVERT_UNIT_CODE { get; set; }

        [StringLength(100)]
        public string CONVERT_UNIT_NAME { get; set; }

        [StringLength(25)]
        public string MATERIAL_TYPE_MAP_CODE { get; set; }

        [StringLength(500)]
        public string MATERIAL_TYPE_MAP_NAME { get; set; }

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

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_MEDICINE_1")]
    public partial class V_HIS_MEDICINE_1
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

        public long MEDICINE_TYPE_ID { get; set; }

        public long? SUPPLIER_ID { get; set; }

        [StringLength(100)]
        public string PACKAGE_NUMBER { get; set; }

        public long? EXPIRED_DATE { get; set; }

        public decimal AMOUNT { get; set; }

        public long? IMP_SOURCE_ID { get; set; }

        public long? IMP_TIME { get; set; }

        public decimal IMP_PRICE { get; set; }

        public decimal IMP_VAT_RATIO { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        public long? BID_ID { get; set; }

        [StringLength(30)]
        public string TDL_BID_NUMBER { get; set; }

        [StringLength(50)]
        public string TDL_BID_NUM_ORDER { get; set; }

        [StringLength(4)]
        public string TDL_BID_GROUP_CODE { get; set; }

        [StringLength(4)]
        public string TDL_BID_PACKAGE_CODE { get; set; }

        [StringLength(20)]
        public string TDL_BID_YEAR { get; set; }

        [StringLength(500)]
        public string MEDICINE_REGISTER_NUMBER { get; set; }

        [StringLength(50)]
        public string MEDICINE_BYT_NUM_ORDER { get; set; }

        [StringLength(20)]
        public string MEDICINE_TCY_NUM_ORDER { get; set; }

        public short? MEDICINE_IS_STAR_MARK { get; set; }

        public short? IS_PREGNANT { get; set; }

        public short? IS_SALE_EQUAL_IMP_PRICE { get; set; }

        public long TDL_SERVICE_ID { get; set; }

        public decimal? VIR_IMP_PRICE { get; set; }

        [StringLength(500)]
        public string ACTIVE_INGR_BHYT_CODE { get; set; }

        [StringLength(1000)]
        public string ACTIVE_INGR_BHYT_NAME { get; set; }

        public long? DOCUMENT_PRICE { get; set; }

        [StringLength(1000)]
        public string NATIONAL_NAME { get; set; }

        public long? MANUFACTURER_ID { get; set; }

        [StringLength(1000)]
        public string CONCENTRA { get; set; }

        [StringLength(12)]
        public string TDL_IMP_MEST_CODE { get; set; }

        [StringLength(25)]
        public string TDL_IMP_MEST_SUB_CODE { get; set; }

        public decimal? IMP_UNIT_AMOUNT { get; set; }

        public decimal? IMP_UNIT_PRICE { get; set; }

        public long? TDL_IMP_UNIT_ID { get; set; }

        public decimal? TDL_IMP_UNIT_CONVERT_RATIO { get; set; }

        public long? MEDICAL_CONTRACT_ID { get; set; }

        public decimal? CONTRACT_PRICE { get; set; }

        public decimal? PROFIT_RATIO { get; set; }

        [StringLength(300)]
        public string PACKING_TYPE_NAME { get; set; }

        [StringLength(500)]
        public string HEIN_SERVICE_BHYT_NAME { get; set; }

        [StringLength(1000)]
        public string ACTIVE_INGR_BHYT_NAME1 { get; set; }

        public long? MEDICINE_USE_FORM_ID { get; set; }

        [StringLength(100)]
        public string DOSAGE_FORM { get; set; }

        public decimal? TAX_RATIO { get; set; }

        [StringLength(50)]
        public string TDL_BID_EXTRA_CODE { get; set; }

        [StringLength(4000)]
        public string LOCKING_REASON { get; set; }

        [Required]
        [StringLength(25)]
        public string MEDICINE_TYPE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string MEDICINE_TYPE_NAME { get; set; }

        public short? IS_BUSINESS { get; set; }

        [StringLength(10)]
        public string SUPPLIER_CODE { get; set; }

        [StringLength(1000)]
        public string SUPPLIER_NAME { get; set; }

        [StringLength(6)]
        public string MANUFACTURER_CODE { get; set; }

        [StringLength(1000)]
        public string MANUFACTURER_NAME { get; set; }

        [StringLength(6)]
        public string MEDICINE_USE_FORM_CODE { get; set; }

        [StringLength(100)]
        public string MEDICINE_USE_FORM_NAME { get; set; }

        [StringLength(50)]
        public string MEDICAL_CONTRACT_CODE { get; set; }

        [StringLength(200)]
        public string MEDICAL_CONTRACT_NAME { get; set; }

        [StringLength(2)]
        public string IMP_SOURCE_CODE { get; set; }

        [StringLength(100)]
        public string IMP_SOURCE_NAME { get; set; }

        public long? BID_FORM_ID { get; set; }

        [StringLength(100)]
        public string BID_TYPE_NAME { get; set; }
    }
}

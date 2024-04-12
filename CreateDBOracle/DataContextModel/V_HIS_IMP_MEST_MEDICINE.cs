namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_IMP_MEST_MEDICINE")]
    public partial class V_HIS_IMP_MEST_MEDICINE
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

        public long IMP_MEST_ID { get; set; }

        public long MEDICINE_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal? PRICE { get; set; }

        public decimal? VAT_RATIO { get; set; }

        public long? TH_EXP_MEST_MEDICINE_ID { get; set; }

        public decimal? VIR_PRICE { get; set; }

        public long? DOCUMENT_PRICE { get; set; }

        public decimal? IMP_UNIT_AMOUNT { get; set; }

        public decimal? IMP_UNIT_PRICE { get; set; }

        public long? TDL_IMP_UNIT_ID { get; set; }

        public decimal? TDL_IMP_UNIT_CONVERT_RATIO { get; set; }

        public decimal? CONTRACT_PRICE { get; set; }

        public decimal? REQ_AMOUNT { get; set; }

        [StringLength(1000)]
        public string NOTE { get; set; }

        public decimal? TEMPERATURE { get; set; }

        [Required]
        [StringLength(12)]
        public string IMP_MEST_CODE { get; set; }

        public long IMP_MEST_TYPE_ID { get; set; }

        public long MEDI_STOCK_ID { get; set; }

        public long? IMP_TIME { get; set; }

        public long? MEDI_STOCK_PERIOD_ID { get; set; }

        public long IMP_MEST_STT_ID { get; set; }

        public long? AGGR_IMP_MEST_ID { get; set; }

        public long? REQ_ROOM_ID { get; set; }

        public long? REQ_DEPARTMENT_ID { get; set; }

        [StringLength(50)]
        public string DOCUMENT_NUMBER { get; set; }

        public long? SPECIAL_MEDICINE_TYPE { get; set; }

        public long? CHMS_TYPE_ID { get; set; }

        [StringLength(50)]
        public string REQ_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REQ_USERNAME { get; set; }

        public decimal IMP_PRICE { get; set; }

        public decimal IMP_VAT_RATIO { get; set; }

        public long? BID_ID { get; set; }

        [StringLength(100)]
        public string PACKAGE_NUMBER { get; set; }

        public long? EXPIRED_DATE { get; set; }

        public long MEDICINE_TYPE_ID { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        public long? SUPPLIER_ID { get; set; }

        [StringLength(50)]
        public string MEDICINE_BYT_NUM_ORDER { get; set; }

        [StringLength(500)]
        public string MEDICINE_REGISTER_NUMBER { get; set; }

        [StringLength(20)]
        public string MEDICINE_TCY_NUM_ORDER { get; set; }

        public short? MEDICINE_IS_STAR_MARK { get; set; }

        [StringLength(500)]
        public string ACTIVE_INGR_BHYT_CODE { get; set; }

        [StringLength(1000)]
        public string ACTIVE_INGR_BHYT_NAME { get; set; }

        public decimal? PROFIT_RATIO { get; set; }

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

        public long? NUM_ORDER { get; set; }

        [StringLength(500)]
        public string REGISTER_NUMBER { get; set; }

        [StringLength(50)]
        public string BYT_NUM_ORDER { get; set; }

        [StringLength(20)]
        public string TCY_NUM_ORDER { get; set; }

        public short? IS_STAR_MARK { get; set; }

        [StringLength(1000)]
        public string CONCENTRA { get; set; }

        [StringLength(300)]
        public string PACKING_TYPE_NAME { get; set; }

        public long? MEDICINE_GROUP_ID { get; set; }

        public long SERVICE_UNIT_ID { get; set; }

        [StringLength(20)]
        public string RECORDING_TRANSACTION { get; set; }

        [StringLength(6)]
        public string MANUFACTURER_CODE { get; set; }

        [StringLength(1000)]
        public string MANUFACTURER_NAME { get; set; }

        [Required]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        public long? MEDICINE_NUM_ORDER { get; set; }

        public long? MATERIAL_NUM_ORDER { get; set; }

        public decimal? CONVERT_RATIO { get; set; }

        [StringLength(10)]
        public string SUPPLIER_CODE { get; set; }

        [StringLength(1000)]
        public string SUPPLIER_NAME { get; set; }

        [StringLength(30)]
        public string BID_NUMBER { get; set; }

        [StringLength(500)]
        public string BID_NAME { get; set; }

        [StringLength(3)]
        public string CONVERT_UNIT_CODE { get; set; }

        [StringLength(100)]
        public string CONVERT_UNIT_NAME { get; set; }

        [StringLength(3)]
        public string IMP_UNIT_CODE { get; set; }

        [StringLength(100)]
        public string IMP_UNIT_NAME { get; set; }

        [StringLength(6)]
        public string MEDICINE_USE_FORM_CODE { get; set; }

        [StringLength(100)]
        public string MEDICINE_USE_FORM_NAME { get; set; }

        public long? MEDICINE_USE_FORM_NUM_ORDER { get; set; }
    }
}

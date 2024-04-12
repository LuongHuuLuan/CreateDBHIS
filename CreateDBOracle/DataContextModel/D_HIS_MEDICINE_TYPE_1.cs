namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.D_HIS_MEDICINE_TYPE_1")]
    public partial class D_HIS_MEDICINE_TYPE_1
    {
        [Key]
        [Column(Order = 0)]
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

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string MEDICINE_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(500)]
        public string MEDICINE_TYPE_NAME { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_SERVICE_UNIT_ID { get; set; }

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

        public short? IS_STOP_IMP { get; set; }

        public short? IS_STAR_MARK { get; set; }

        public short? IS_ALLOW_ODD { get; set; }

        public short? IS_ALLOW_EXPORT_ODD { get; set; }

        public short? IS_FUNCTIONAL_FOOD { get; set; }

        public short? IS_REQUIRE_HSD { get; set; }

        public short? IS_SALE_EQUAL_IMP_PRICE { get; set; }

        public short? IS_BUSINESS { get; set; }

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

        public short? IS_RAW_MEDICINE { get; set; }

        public short? IS_AUTO_EXPEND { get; set; }

        [StringLength(6)]
        public string MANUFACTURER_CODE { get; set; }

        [StringLength(1000)]
        public string MANUFACTURER_NAME { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string MEDI_STOCK_CODE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string MEDI_STOCK_NAME { get; set; }

        public decimal? AMOUNT { get; set; }

        public long? MEDI_STOCK_ID { get; set; }

        [StringLength(500)]
        public string MEDICINE_REGISTER_NUMBER { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_UNIT_ID { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }
    }
}

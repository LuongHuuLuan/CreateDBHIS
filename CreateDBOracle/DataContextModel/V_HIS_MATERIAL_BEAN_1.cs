namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_MATERIAL_BEAN_1")]
    public partial class V_HIS_MATERIAL_BEAN_1
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MATERIAL_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal AMOUNT { get; set; }

        public long? MEDI_STOCK_ID { get; set; }

        public long? SOURCE_ID { get; set; }

        public decimal? BK_DECREASE_AMOUNT { get; set; }

        public long? BK_MEDI_STOCK_ID { get; set; }

        public long? EXP_MEST_MATERIAL_ID { get; set; }

        public decimal? DETACH_AMOUNT { get; set; }

        [StringLength(50)]
        public string DETACH_KEY { get; set; }

        public short? IS_TH { get; set; }

        public short? IS_CK { get; set; }

        public short? IS_USE { get; set; }

        [StringLength(4000)]
        public string SESSION_KEY { get; set; }

        public long? SESSION_TIME { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_MATERIAL_TYPE_ID { get; set; }

        public short? TDL_MATERIAL_IS_ACTIVE { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal TDL_MATERIAL_IMP_PRICE { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal TDL_MATERIAL_IMP_VAT_RATIO { get; set; }

        public long? TDL_MATERIAL_IMP_TIME { get; set; }

        public long? TDL_MATERIAL_EXPIRED_DATE { get; set; }

        public short? TDL_IS_SALE_EQUAL_IMP_PRICE { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_SERVICE_ID { get; set; }

        [StringLength(50)]
        public string SERIAL_NUMBER { get; set; }

        public long? REMAIN_REUSE_COUNT { get; set; }

        public long? TDL_MATERIAL_MAX_REUSE_COUNT { get; set; }

        [StringLength(100)]
        public string TDL_PACKAGE_NUMBER { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MATERIAL_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal IMP_PRICE { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal IMP_VAT_RATIO { get; set; }

        public long? BID_ID { get; set; }

        public long? IMP_TIME { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        public long? SUPPLIER_ID { get; set; }

        [StringLength(100)]
        public string PACKAGE_NUMBER { get; set; }

        public short? MATERIAL_IS_ACTIVE { get; set; }

        public long? EXPIRED_DATE { get; set; }

        [StringLength(500)]
        public string MATERIAL_REGISTER_NUMBER { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(25)]
        public string MATERIAL_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(500)]
        public string MATERIAL_TYPE_NAME { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_ID { get; set; }

        public long? ALERT_EXPIRED_DATE { get; set; }

        public decimal? ALERT_MIN_IN_STOCK { get; set; }

        public long? PARENT_ID { get; set; }

        [StringLength(100)]
        public string NATIONAL_NAME { get; set; }

        public long? NUM_ORDER { get; set; }

        public short? MATERIAL_TYPE_IS_ACTIVE { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_UNIT_ID { get; set; }

        public short? IS_REUSABLE { get; set; }

        [StringLength(500)]
        public string MATERIAL_GROUP_BHYT { get; set; }

        public long? MATERIAL_TYPE_MAP_ID { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        [StringLength(10)]
        public string SERVICE_UNIT_SYMBOL { get; set; }
    }
}

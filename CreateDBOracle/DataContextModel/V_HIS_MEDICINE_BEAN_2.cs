namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_MEDICINE_BEAN_2")]
    public partial class V_HIS_MEDICINE_BEAN_2
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
        public long MEDICINE_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal AMOUNT { get; set; }

        public long? MEDI_STOCK_ID { get; set; }

        public long? SOURCE_ID { get; set; }

        public decimal? DETACH_AMOUNT { get; set; }

        [StringLength(50)]
        public string DETACH_KEY { get; set; }

        public decimal? BK_DECREASE_AMOUNT { get; set; }

        public long? BK_MEDI_STOCK_ID { get; set; }

        public short? IS_TH { get; set; }

        public short? IS_CK { get; set; }

        public short? IS_USE { get; set; }

        [StringLength(4000)]
        public string SESSION_KEY { get; set; }

        public long? SESSION_TIME { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_MEDICINE_TYPE_ID { get; set; }

        public short? TDL_MEDICINE_IS_ACTIVE { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal TDL_MEDICINE_IMP_PRICE { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal TDL_MEDICINE_IMP_VAT_RATIO { get; set; }

        public long? TDL_MEDICINE_IMP_TIME { get; set; }

        public long? TDL_MEDICINE_EXPIRED_DATE { get; set; }

        public short? TDL_IS_SALE_EQUAL_IMP_PRICE { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_SERVICE_ID { get; set; }

        public long? EXP_MEST_MEDICINE_ID { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MEDICINE_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal IMP_PRICE { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal IMP_VAT_RATIO { get; set; }

        public long? BID_ID { get; set; }

        public long? IMP_TIME { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        [StringLength(100)]
        public string PACKAGE_NUMBER { get; set; }

        public long? SUPPLIER_ID { get; set; }

        public short? MEDICINE_IS_ACTIVE { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_MEST_PERIOD_MATY")]
    public partial class V_HIS_MEST_PERIOD_MATY
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
        public long MEDI_STOCK_PERIOD_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MATERIAL_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal BEGIN_AMOUNT { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal IN_AMOUNT { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal OUT_AMOUNT { get; set; }

        public decimal? VIR_END_AMOUNT { get; set; }

        public decimal? INVENTORY_AMOUNT { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string MEDI_STOCK_PERIOD_NAME { get; set; }

        public long? MEDI_STOCK_PERIOD_TIME { get; set; }

        public long? TO_TIME { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(25)]
        public string MATERIAL_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(500)]
        public string MATERIAL_TYPE_NAME { get; set; }

        public decimal? IMP_PRICE { get; set; }

        public decimal? IMP_VAT_RATIO { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        public long? ALERT_EXPIRED_DATE { get; set; }

        public decimal? ALERT_MIN_IN_STOCK { get; set; }

        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        [StringLength(100)]
        public string NATIONAL_NAME { get; set; }

        [StringLength(1000)]
        public string CONCENTRA { get; set; }

        [StringLength(300)]
        public string PACKING_TYPE_NAME { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        [StringLength(1000)]
        public string MANUFACTURER_NAME { get; set; }
    }
}

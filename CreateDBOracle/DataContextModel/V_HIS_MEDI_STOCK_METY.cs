namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_MEDI_STOCK_METY")]
    public partial class V_HIS_MEDI_STOCK_METY
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
        public long MEDI_STOCK_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MEDICINE_TYPE_ID { get; set; }

        public decimal? ALERT_MIN_IN_STOCK { get; set; }

        public decimal? ALERT_MAX_IN_STOCK { get; set; }

        public short? IS_PREVENT_MAX { get; set; }

        public short? IS_GOODS_RESTRICT { get; set; }

        public short? IS_PREVENT_EXP { get; set; }

        public long? EXP_MEDI_STOCK_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string MEDI_STOCK_CODE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string MEDI_STOCK_NAME { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(25)]
        public string MEDICINE_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(500)]
        public string MEDICINE_TYPE_NAME { get; set; }

        [StringLength(20)]
        public string EXP_MEDI_STOCK_CODE { get; set; }

        [StringLength(100)]
        public string EXP_MEDI_STOCK_NAME { get; set; }
    }
}

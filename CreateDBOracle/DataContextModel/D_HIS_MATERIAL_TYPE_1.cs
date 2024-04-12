namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.D_HIS_MATERIAL_TYPE_1")]
    public partial class D_HIS_MATERIAL_TYPE_1
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public short? IS_ACTIVE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string MATERIAL_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(500)]
        public string MATERIAL_TYPE_NAME { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_ID { get; set; }

        public long? MANUFACTURER_ID { get; set; }

        public decimal? ALERT_MIN_IN_STOCK { get; set; }

        [StringLength(100)]
        public string NATIONAL_NAME { get; set; }

        [StringLength(1000)]
        public string CONCENTRA { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_UNIT_ID { get; set; }

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

        [Key]
        [Column(Order = 7)]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.L_HIS_MEDICINE_BEAN")]
    public partial class L_HIS_MEDICINE_BEAN
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public short? IS_ACTIVE { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal AMOUNT { get; set; }

        public long? MEDI_STOCK_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_MEDICINE_TYPE_ID { get; set; }

        public short? TDL_MEDICINE_IS_ACTIVE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(25)]
        public string MEDICINE_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(500)]
        public string MEDICINE_TYPE_NAME { get; set; }

        public short? MEDICINE_TYPE_IS_ACTIVE { get; set; }

        [StringLength(1000)]
        public string CONCENTRA { get; set; }

        public short? IS_BUSINESS { get; set; }

        [StringLength(500)]
        public string ACTIVE_INGR_BHYT_CODE { get; set; }

        [StringLength(1000)]
        public string ACTIVE_INGR_BHYT_NAME { get; set; }

        [StringLength(500)]
        public string REGISTER_NUMBER { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string MEDI_STOCK_CODE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string MEDI_STOCK_NAME { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }
    }
}

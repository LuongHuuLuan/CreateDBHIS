namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.D_HIS_EXP_MEST_DETAIL_1")]
    public partial class D_HIS_EXP_MEST_DETAIL_1
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EXP_MEST_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MEDI_STOCK_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(12)]
        public string EXP_MEST_CODE { get; set; }

        public long? BILL_ID { get; set; }

        public long? DEBT_ID { get; set; }

        [StringLength(12)]
        public string TDL_TREATMENT_CODE { get; set; }

        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        public long? TDL_PATIENT_DOB { get; set; }

        public short? TDL_PATIENT_IS_HAS_NOT_DAY_DOB { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        public long? EXP_MEST_ID { get; set; }

        public decimal? AMOUNT { get; set; }

        public decimal? VIR_PRICE { get; set; }

        public decimal? DISCOUNT { get; set; }

        public decimal? PRICE { get; set; }

        public decimal? VAT_RATIO { get; set; }

        public long? TYPE_ID { get; set; }

        [StringLength(500)]
        public string ITEM_NAME { get; set; }

        public long? TDL_SERVICE_UNIT_ID { get; set; }

        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        public decimal? IS_MEDICINE { get; set; }
    }
}

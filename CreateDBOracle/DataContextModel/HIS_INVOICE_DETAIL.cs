namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_INVOICE_DETAIL")]
    public partial class HIS_INVOICE_DETAIL
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

        public long INVOICE_ID { get; set; }

        [StringLength(100)]
        public string GOODS_UNIT { get; set; }

        [Required]
        [StringLength(500)]
        public string GOODS_NAME { get; set; }

        public decimal PRICE { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal? DISCOUNT { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        public decimal? VIR_TOTAL_PRICE { get; set; }

        public virtual HIS_INVOICE HIS_INVOICE { get; set; }
    }
}

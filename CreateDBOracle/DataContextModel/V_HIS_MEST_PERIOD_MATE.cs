namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_MEST_PERIOD_MATE")]
    public partial class V_HIS_MEST_PERIOD_MATE
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

        public long MEDI_STOCK_PERIOD_ID { get; set; }

        public long MATERIAL_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public long? TDL_MATERIAL_TYPE_ID { get; set; }

        public decimal? BEGIN_AMOUNT { get; set; }

        public decimal? IN_AMOUNT { get; set; }

        public decimal? OUT_AMOUNT { get; set; }

        public decimal? INVENTORY_AMOUNT { get; set; }

        public decimal? VIR_END_AMOUNT { get; set; }

        public long? MEDI_STOCK_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string MEDI_STOCK_PERIOD_NAME { get; set; }

        public long? TO_TIME { get; set; }

        public long MATERIAL_TYPE_ID { get; set; }

        public decimal IMP_PRICE { get; set; }

        public decimal IMP_VAT_RATIO { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        public long? BID_ID { get; set; }

        [StringLength(100)]
        public string PACKAGE_NUMBER { get; set; }

        public long? EXPIRED_DATE { get; set; }

        public long? SUPPLIER_ID { get; set; }

        [Required]
        [StringLength(25)]
        public string MATERIAL_TYPE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string MATERIAL_TYPE_NAME { get; set; }

        [StringLength(100)]
        public string NATIONAL_NAME { get; set; }

        public long SERVICE_ID { get; set; }

        public long? NUM_ORDER { get; set; }

        public long SERVICE_UNIT_ID { get; set; }

        public long? PARENT_ID { get; set; }

        [StringLength(500)]
        public string REGISTER_NUMBER { get; set; }

        [Required]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        [StringLength(10)]
        public string SUPPLIER_CODE { get; set; }

        [StringLength(1000)]
        public string SUPPLIER_NAME { get; set; }
    }
}

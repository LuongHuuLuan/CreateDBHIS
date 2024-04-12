namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.D_HIS_EXP_MEST_DETAIL")]
    public partial class D_HIS_EXP_MEST_DETAIL
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public long? EXP_MEST_ID { get; set; }

        public decimal? AMOUNT { get; set; }

        public decimal? PRICE { get; set; }

        public decimal? VAT_RATIO { get; set; }

        public decimal? DISCOUNT { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        public long? NUM_ORDER { get; set; }

        public decimal? IMP_PRICE { get; set; }

        public decimal? IMP_VAT_RATIO { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        [StringLength(100)]
        public string PACKAGE_NUMBER { get; set; }

        public decimal? EXPIRED_DATE { get; set; }

        public decimal? IS_MEDICINE { get; set; }

        [StringLength(500)]
        public string ACTIVE_INGR_BHYT_CODE { get; set; }

        [StringLength(1000)]
        public string ACTIVE_INGR_BHYT_NAME { get; set; }

        [StringLength(25)]
        public string DETAIL_CODE { get; set; }

        [StringLength(500)]
        public string DETAIL_NAME { get; set; }

        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }
    }
}

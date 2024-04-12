namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_BID_BLOOD_TYPE")]
    public partial class V_HIS_BID_BLOOD_TYPE
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

        public long BID_ID { get; set; }

        public long BLOOD_TYPE_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal? IMP_PRICE { get; set; }

        public decimal? IMP_VAT_RATIO { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        [Required]
        [StringLength(50)]
        public string BID_NUM_ORDER { get; set; }

        public long SUPPLIER_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string BID_NUMBER { get; set; }

        [Required]
        [StringLength(500)]
        public string BID_NAME { get; set; }

        public long? BID_TYPE_ID { get; set; }

        [StringLength(20)]
        public string BID_YEAR { get; set; }

        public long? VALID_FROM_TIME { get; set; }

        public long? VALID_TO_TIME { get; set; }

        [StringLength(50)]
        public string BID_EXTRA_CODE { get; set; }

        [Required]
        [StringLength(25)]
        public string BLOOD_TYPE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string BLOOD_TYPE_NAME { get; set; }

        public long SERVICE_ID { get; set; }

        public long? NUM_ORDER { get; set; }

        public long BLOOD_VOLUME_ID { get; set; }

        [StringLength(100)]
        public string ELEMENT { get; set; }

        public long? PACKING_TYPE_ID { get; set; }

        public long SERVICE_UNIT_ID { get; set; }

        public decimal VOLUME { get; set; }

        [Required]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        [StringLength(10)]
        public string SERVICE_UNIT_SYMBOL { get; set; }

        [Required]
        [StringLength(10)]
        public string SUPPLIER_CODE { get; set; }

        [Required]
        [StringLength(1000)]
        public string SUPPLIER_NAME { get; set; }

        [StringLength(6)]
        public string PACKING_TYPE_CODE { get; set; }

        [StringLength(300)]
        public string PACKING_TYPE_NAME { get; set; }

        public decimal? IN_AMOUNT { get; set; }

        public decimal? OUT_AMOUNT { get; set; }
    }
}

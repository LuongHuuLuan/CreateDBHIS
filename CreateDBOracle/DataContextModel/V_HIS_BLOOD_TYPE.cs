namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_BLOOD_TYPE")]
    public partial class V_HIS_BLOOD_TYPE
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

        [Required]
        [StringLength(25)]
        public string BLOOD_TYPE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string BLOOD_TYPE_NAME { get; set; }

        public long SERVICE_ID { get; set; }

        public long? PARENT_ID { get; set; }

        public short? IS_LEAF { get; set; }

        public long? NUM_ORDER { get; set; }

        public long TDL_SERVICE_UNIT_ID { get; set; }

        public long BLOOD_VOLUME_ID { get; set; }

        public long? BLOOD_GROUP_ID { get; set; }

        public long? PACKING_TYPE_ID { get; set; }

        public decimal? IMP_PRICE { get; set; }

        public decimal? IMP_VAT_RATIO { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        public long? ALERT_EXPIRED_DATE { get; set; }

        [StringLength(100)]
        public string ELEMENT { get; set; }

        public short? IS_RED_BLOOD_CELLS { get; set; }

        public long? WARNING_DAY { get; set; }

        public decimal VOLUME { get; set; }

        public long SERVICE_UNIT_ID { get; set; }

        public long SERVICE_TYPE_ID { get; set; }

        public long? HEIN_SERVICE_TYPE_ID { get; set; }

        public decimal? COGS { get; set; }

        public decimal? ESTIMATE_DURATION { get; set; }

        public short? BILL_OPTION { get; set; }

        public short? IS_OUT_PARENT_FEE { get; set; }

        [StringLength(100)]
        public string HEIN_SERVICE_BHYT_CODE { get; set; }

        [StringLength(500)]
        public string HEIN_SERVICE_BHYT_NAME { get; set; }

        [StringLength(20)]
        public string HEIN_ORDER { get; set; }

        [Required]
        [StringLength(2)]
        public string SERVICE_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_TYPE_NAME { get; set; }

        [Required]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        [StringLength(10)]
        public string SERVICE_UNIT_SYMBOL { get; set; }

        [StringLength(6)]
        public string PACKING_TYPE_CODE { get; set; }

        [StringLength(300)]
        public string PACKING_TYPE_NAME { get; set; }

        [StringLength(10)]
        public string HEIN_SERVICE_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string HEIN_SERVICE_TYPE_NAME { get; set; }
    }
}

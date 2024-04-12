namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_BLOOD_TYPE_1")]
    public partial class V_HIS_BLOOD_TYPE_1
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
        [StringLength(25)]
        public string BLOOD_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(500)]
        public string BLOOD_TYPE_NAME { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_ID { get; set; }

        public long? PARENT_ID { get; set; }

        public short? IS_LEAF { get; set; }

        public long? NUM_ORDER { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_SERVICE_UNIT_ID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BLOOD_VOLUME_ID { get; set; }

        public long? BLOOD_GROUP_ID { get; set; }

        public long? PACKING_TYPE_ID { get; set; }

        public decimal? IMP_PRICE { get; set; }

        public decimal? IMP_VAT_RATIO { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        public long? ALERT_EXPIRED_DATE { get; set; }

        [StringLength(100)]
        public string ELEMENT { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_UNIT_ID { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_TYPE_ID { get; set; }

        public long? HEIN_SERVICE_TYPE_ID { get; set; }

        [StringLength(100)]
        public string HEIN_SERVICE_BHYT_CODE { get; set; }

        [StringLength(500)]
        public string HEIN_SERVICE_BHYT_NAME { get; set; }

        [StringLength(20)]
        public string HEIN_ORDER { get; set; }

        public decimal? HEIN_LIMIT_PRICE_OLD { get; set; }

        public decimal? HEIN_LIMIT_RATIO_OLD { get; set; }

        public decimal? HEIN_LIMIT_PRICE { get; set; }

        public decimal? HEIN_LIMIT_RATIO { get; set; }

        public long? HEIN_LIMIT_PRICE_IN_TIME { get; set; }

        public long? HEIN_LIMIT_PRICE_INTR_TIME { get; set; }

        public short? IS_OUT_PARENT_FEE { get; set; }
    }
}

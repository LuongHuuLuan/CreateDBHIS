namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_BLOOD")]
    public partial class V_HIS_BLOOD
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
        [StringLength(20)]
        public string BLOOD_CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BLOOD_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BLOOD_ABO_ID { get; set; }

        public long? BLOOD_RH_ID { get; set; }

        public long? MEDI_STOCK_ID { get; set; }

        public long? SUPPLIER_ID { get; set; }

        public long? IMP_SOURCE_ID { get; set; }

        public long? BID_ID { get; set; }

        [StringLength(50)]
        public string BID_NUM_ORDER { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal IMP_PRICE { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal IMP_VAT_RATIO { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        public long? IMP_TIME { get; set; }

        public long? PACKING_TIME { get; set; }

        [StringLength(100)]
        public string PACKAGE_NUMBER { get; set; }

        public long? EXPIRED_DATE { get; set; }

        public short? IS_INFECT { get; set; }

        [StringLength(100)]
        public string GIVE_NAME { get; set; }

        [StringLength(20)]
        public string GIVE_CODE { get; set; }

        public short? IS_PREGNANT { get; set; }

        public decimal? VIR_IMP_PRICE { get; set; }

        public long? BLOOD_GIVE_ID { get; set; }

        public long? LAST_EXP_MEST_BLOOD_ID { get; set; }

        public short? BLOOD_TYPE_IS_ACTIVE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(25)]
        public string BLOOD_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(500)]
        public string BLOOD_TYPE_NAME { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_ID { get; set; }

        public long? PARENT_ID { get; set; }

        public short? IS_LEAF { get; set; }

        public long? NUM_ORDER { get; set; }

        public long? PACKING_TYPE_ID { get; set; }

        public long? BLOOD_GROUP_ID { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BLOOD_VOLUME_ID { get; set; }

        [StringLength(100)]
        public string ELEMENT { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(2)]
        public string BLOOD_ABO_CODE { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal VOLUME { get; set; }

        [StringLength(3)]
        public string BLOOD_RH_CODE { get; set; }

        [StringLength(20)]
        public string MEDI_STOCK_CODE { get; set; }

        [StringLength(100)]
        public string MEDI_STOCK_NAME { get; set; }

        public long? ROOM_ID { get; set; }

        public short? IS_CABINET { get; set; }

        [StringLength(10)]
        public string SUPPLIER_CODE { get; set; }

        [StringLength(1000)]
        public string SUPPLIER_NAME { get; set; }

        [StringLength(2)]
        public string IMP_SOURCE_CODE { get; set; }

        [StringLength(100)]
        public string IMP_SOURCE_NAME { get; set; }

        public short? IS_EXPORT { get; set; }

        [StringLength(12)]
        public string EXP_MEST_CODE { get; set; }

        public long? EXP_MEST_TYPE_ID { get; set; }

        public long? EXP_MEST_STT_ID { get; set; }

        [StringLength(2)]
        public string EXP_MEST_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string EXP_MEST_TYPE_NAME { get; set; }
    }
}

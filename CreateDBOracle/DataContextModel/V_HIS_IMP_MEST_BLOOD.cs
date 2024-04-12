namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_IMP_MEST_BLOOD")]
    public partial class V_HIS_IMP_MEST_BLOOD
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IMP_MEST_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BLOOD_ID { get; set; }

        public decimal? PRICE { get; set; }

        public decimal? VAT_RATIO { get; set; }

        public decimal? VIR_PRICE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(12)]
        public string IMP_MEST_CODE { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IMP_MEST_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MEDI_STOCK_ID { get; set; }

        public long? IMP_TIME { get; set; }

        public long? MEDI_STOCK_PERIOD_ID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IMP_MEST_STT_ID { get; set; }

        public long? AGGR_IMP_MEST_ID { get; set; }

        public long? REQ_ROOM_ID { get; set; }

        public long? REQ_DEPARTMENT_ID { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(20)]
        public string BLOOD_CODE { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal IMP_PRICE { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal IMP_VAT_RATIO { get; set; }

        public long? BID_ID { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BLOOD_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BLOOD_ABO_ID { get; set; }

        public long? BLOOD_RH_ID { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        public long? EXPIRED_DATE { get; set; }

        [StringLength(100)]
        public string PACKAGE_NUMBER { get; set; }

        public long? IMP_SOURCE_ID { get; set; }

        public long? SUPPLIER_ID { get; set; }

        public short? IS_INFECT { get; set; }

        [StringLength(100)]
        public string GIVE_NAME { get; set; }

        [StringLength(20)]
        public string GIVE_CODE { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(25)]
        public string BLOOD_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(500)]
        public string BLOOD_TYPE_NAME { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_ID { get; set; }

        public long? NUM_ORDER { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BLOOD_VOLUME_ID { get; set; }

        [StringLength(100)]
        public string ELEMENT { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_UNIT_ID { get; set; }

        [Key]
        [Column(Order = 17)]
        public decimal VOLUME { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(2)]
        public string BLOOD_ABO_CODE { get; set; }

        [StringLength(3)]
        public string BLOOD_RH_CODE { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        [StringLength(30)]
        public string BID_NUMBER { get; set; }

        [StringLength(500)]
        public string BID_NAME { get; set; }

        [StringLength(2)]
        public string IMP_SOURCE_CODE { get; set; }

        [StringLength(100)]
        public string IMP_SOURCE_NAME { get; set; }

        [StringLength(10)]
        public string SUPPLIER_CODE { get; set; }

        [StringLength(1000)]
        public string SUPPLIER_NAME { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_KSK_SERVICE")]
    public partial class V_HIS_KSK_SERVICE
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
        public long KSK_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ROOM_ID { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal AMOUNT { get; set; }

        public decimal? PRICE { get; set; }

        public decimal? VAT_RATIO { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(6)]
        public string KSK_CODE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string KSK_NAME { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(25)]
        public string SERVICE_CODE { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(500)]
        public string SERVICE_NAME { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(2)]
        public string SERVICE_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(100)]
        public string SERVICE_TYPE_NAME { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }
    }
}

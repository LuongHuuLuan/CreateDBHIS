namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_SERVICE_PACKAGE")]
    public partial class V_HIS_SERVICE_PACKAGE
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
        public long SERVICE_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_ATTACH_ID { get; set; }

        public short? IS_EXPEND { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal AMOUNT { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(25)]
        public string SERVICE_CODE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(500)]
        public string SERVICE_NAME { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(2)]
        public string SERVICE_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(100)]
        public string SERVICE_TYPE_NAME { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(25)]
        public string ATTACH_SERVICE_CODE { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(500)]
        public string ATTACH_SERVICE_NAME { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ATTACH_SERVICE_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(2)]
        public string ATTACH_SERVICE_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(100)]
        public string ATTACH_SERVICE_TYPE_NAME { get; set; }
    }
}

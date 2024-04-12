namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_SURG_REMU_DETAIL_1")]
    public partial class V_HIS_SURG_REMU_DETAIL_1
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
        public long EXECUTE_ROLE_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal PRICE { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SURG_REMUNERATION_ID { get; set; }

        [StringLength(50)]
        public string SURG_REMUNERATION_CODE { get; set; }

        [StringLength(200)]
        public string SURG_REMUNERATION_NAME { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string PTTT_GROUP_CODE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string PTTT_GROUP_NAME { get; set; }

        [StringLength(6)]
        public string EMOTIONLESS_METHOD_CODE { get; set; }

        [StringLength(100)]
        public string EMOTIONLESS_METHOD_NAME { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(2)]
        public string SERVICE_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string SERVICE_TYPE_NAME { get; set; }
    }
}

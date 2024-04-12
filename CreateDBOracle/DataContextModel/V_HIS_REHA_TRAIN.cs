namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_REHA_TRAIN")]
    public partial class V_HIS_REHA_TRAIN
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
        public long SERE_SERV_REHA_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TRAIN_TIME { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal AMOUNT { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERE_SERV_ID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long REHA_TRAIN_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(6)]
        public string REHA_TRAIN_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string REHA_TRAIN_TYPE_NAME { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long REHA_TRAIN_UNIT_ID { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(2)]
        public string REHA_TRAIN_UNIT_CODE { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(100)]
        public string REHA_TRAIN_UNIT_NAME { get; set; }
    }
}

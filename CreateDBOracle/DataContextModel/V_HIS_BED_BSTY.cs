namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_BED_BSTY")]
    public partial class V_HIS_BED_BSTY
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
        public long BED_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BED_SERVICE_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(25)]
        public string SERVICE_CODE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(500)]
        public string SERVICE_NAME { get; set; }

        public short? IS_LEAF { get; set; }

        public long? NUM_ORDER { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(200)]
        public string BED_NAME { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BED_ROOM_ID { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BED_TYPE_ID { get; set; }

        public long? MAX_CAPACITY { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(20)]
        public string BED_ROOM_CODE { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(100)]
        public string BED_ROOM_NAME { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ROOM_ID { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(10)]
        public string BED_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(100)]
        public string BED_TYPE_NAME { get; set; }
    }
}

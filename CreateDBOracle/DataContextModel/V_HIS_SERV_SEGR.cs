namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_SERV_SEGR")]
    public partial class V_HIS_SERV_SEGR
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
        public long SERVICE_GROUP_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal AMOUNT { get; set; }

        public long? IS_EXPEND { get; set; }

        [StringLength(1000)]
        public string NOTE { get; set; }

        public long? ROOM_ID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(6)]
        public string SERVICE_GROUP_CODE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string SERVICE_GROUP_NAME { get; set; }

        public short? NUM_ORDER { get; set; }

        public long? PARENT_SERVICE_ID { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(25)]
        public string SERVICE_CODE { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(500)]
        public string SERVICE_NAME { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_TYPE_ID { get; set; }

        public short? IS_LEAF { get; set; }

        [StringLength(3)]
        public string SPECIALITY_CODE { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(2)]
        public string SERVICE_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(100)]
        public string SERVICE_TYPE_NAME { get; set; }

        [StringLength(25)]
        public string PARENT_SERVICE_CODE { get; set; }

        [StringLength(500)]
        public string PARENT_SERVICE_NAME { get; set; }

        [StringLength(20)]
        public string EXECUTE_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string EXECUTE_ROOM_NAME { get; set; }
    }
}

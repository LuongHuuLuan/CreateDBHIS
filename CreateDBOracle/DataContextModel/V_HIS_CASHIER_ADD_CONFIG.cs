namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_CASHIER_ADD_CONFIG")]
    public partial class V_HIS_CASHIER_ADD_CONFIG
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
        public long CASHIER_ROOM_ID { get; set; }

        public long? EXECUTE_ROOM_ID { get; set; }

        public long? REQUEST_ROOM_ID { get; set; }

        public long? INSTR_DAY_FROM { get; set; }

        public long? INSTR_DAY_TO { get; set; }

        [StringLength(4)]
        public string INSTR_TIME_FROM { get; set; }

        [StringLength(4)]
        public string INSTR_TIME_TO { get; set; }

        public short? IS_NOT_PRIORITY { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string CASHIER_ROOM_CODE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string CASHIER_ROOM_NAME { get; set; }

        [StringLength(20)]
        public string EXECUTE_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string EXECUTE_ROOM_NAME { get; set; }

        [StringLength(20)]
        public string REQUEST_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string REQUEST_ROOM_NAME { get; set; }
    }
}

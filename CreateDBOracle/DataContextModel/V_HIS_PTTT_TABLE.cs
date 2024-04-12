namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_PTTT_TABLE")]
    public partial class V_HIS_PTTT_TABLE
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
        [StringLength(4)]
        public string PTTT_TABLE_CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string PTTT_TABLE_NAME { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EXECUTE_ROOM_ID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string EXECUTE_ROOM_CODE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string EXECUTE_ROOM_NAME { get; set; }
    }
}

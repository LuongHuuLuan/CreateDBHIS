namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_MACHINE")]
    public partial class V_HIS_MACHINE
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
        [StringLength(100)]
        public string MACHINE_CODE { get; set; }

        [StringLength(200)]
        public string MACHINE_NAME { get; set; }

        [StringLength(200)]
        public string SERIAL_NUMBER { get; set; }

        [StringLength(2)]
        public string SOURCE_CODE { get; set; }

        [StringLength(10)]
        public string MACHINE_GROUP_CODE { get; set; }

        [StringLength(500)]
        public string INTEGRATE_ADDRESS { get; set; }

        public long? ROOM_ID { get; set; }

        public short? IS_KIDNEY { get; set; }

        [StringLength(2000)]
        public string ROOM_IDS { get; set; }

        [StringLength(4000)]
        public string ROOM_NAME { get; set; }
    }
}

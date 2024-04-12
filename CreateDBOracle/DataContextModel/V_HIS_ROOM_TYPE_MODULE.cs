namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_ROOM_TYPE_MODULE")]
    public partial class V_HIS_ROOM_TYPE_MODULE
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
        public long ROOM_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string MODULE_LINK { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string ROOM_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string ROOM_TYPE_NAME { get; set; }
    }
}

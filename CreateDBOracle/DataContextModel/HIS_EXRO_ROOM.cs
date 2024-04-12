namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_EXRO_ROOM")]
    public partial class HIS_EXRO_ROOM
    {
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

        public long EXECUTE_ROOM_ID { get; set; }

        public long ROOM_ID { get; set; }

        public short? IS_HOLD_ORDER { get; set; }

        public short? IS_ALLOW_REQUEST { get; set; }

        public short? IS_PRIORITY_REQUIRE { get; set; }

        public virtual HIS_EXECUTE_ROOM HIS_EXECUTE_ROOM { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }
    }
}

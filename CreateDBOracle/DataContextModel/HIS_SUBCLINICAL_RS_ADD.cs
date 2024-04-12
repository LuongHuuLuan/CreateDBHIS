namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SUBCLINICAL_RS_ADD")]
    public partial class HIS_SUBCLINICAL_RS_ADD
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

        public long? REQUEST_ROOM_ID { get; set; }

        public long? EXECUTE_ROOM_ID { get; set; }

        public long? INSTR_DAY_FROM { get; set; }

        public long? INSTR_DAY_TO { get; set; }

        [StringLength(4)]
        public string INSTR_TIME_FROM { get; set; }

        [StringLength(4)]
        public string INSTR_TIME_TO { get; set; }

        public long? RESULT_ROOM_ID { get; set; }

        public long? RESULT_DESK_ID { get; set; }

        public virtual HIS_DESK HIS_DESK { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        public virtual HIS_ROOM HIS_ROOM1 { get; set; }

        public virtual HIS_ROOM HIS_ROOM2 { get; set; }
    }
}

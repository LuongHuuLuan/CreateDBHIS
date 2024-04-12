namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_HORE_HANDOVER")]
    public partial class HIS_HORE_HANDOVER
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

        [Required]
        [StringLength(8)]
        public string HORE_HANDOVER_CODE { get; set; }

        public long HORE_HANDOVER_STT_ID { get; set; }

        [StringLength(50)]
        public string SEND_LOGINNAME { get; set; }

        [StringLength(100)]
        public string SEND_USERNAME { get; set; }

        public long SEND_ROOM_ID { get; set; }

        [StringLength(50)]
        public string RECEIVE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string RECEIVE_USERNAME { get; set; }

        public long RECEIVE_ROOM_ID { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        public virtual HIS_ROOM HIS_ROOM1 { get; set; }

        public virtual HIS_HORE_HANDOVER_STT HIS_HORE_HANDOVER_STT { get; set; }
    }
}

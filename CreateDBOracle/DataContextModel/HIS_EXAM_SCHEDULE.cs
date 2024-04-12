namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_EXAM_SCHEDULE")]
    public partial class HIS_EXAM_SCHEDULE
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

        public long ROOM_ID { get; set; }

        [Required]
        [StringLength(1000)]
        public string LOGINNAME { get; set; }

        [StringLength(4000)]
        public string USERNAME { get; set; }

        public long DAY_OF_WEEK { get; set; }

        [Required]
        [StringLength(4)]
        public string TIME_FROM { get; set; }

        [StringLength(4)]
        public string TIME_TO { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }
    }
}

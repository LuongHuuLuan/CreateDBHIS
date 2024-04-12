namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_RECEPTION_ROOM")]
    public partial class HIS_RECEPTION_ROOM
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
        [StringLength(20)]
        public string RECEPTION_ROOM_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string RECEPTION_ROOM_NAME { get; set; }

        public long ROOM_ID { get; set; }

        [StringLength(50)]
        public string PATIENT_TYPE_IDS { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }
    }
}

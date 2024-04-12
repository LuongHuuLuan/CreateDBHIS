namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_HOLD_RETURN")]
    public partial class HIS_HOLD_RETURN
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

        public long PATIENT_ID { get; set; }

        [StringLength(15)]
        public string HEIN_CARD_NUMBER { get; set; }

        public long HOLD_TIME { get; set; }

        [Required]
        [StringLength(50)]
        public string HOLD_LOGINNAME { get; set; }

        [StringLength(100)]
        public string HOLD_USERNAME { get; set; }

        public long HOLD_ROOM_ID { get; set; }

        public long RESPONSIBLE_ROOM_ID { get; set; }

        public short? IS_HANDOVERING { get; set; }

        public long? RETURN_TIME { get; set; }

        [StringLength(50)]
        public string RETURN_LOGINNAME { get; set; }

        [StringLength(100)]
        public string RETURN_USERNAME { get; set; }

        public long? RETURN_ROOM_ID { get; set; }

        [StringLength(81)]
        public string VIR_UNIQUE { get; set; }

        public long? TREATMENT_ID { get; set; }

        public virtual HIS_PATIENT HIS_PATIENT { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        public virtual HIS_ROOM HIS_ROOM1 { get; set; }

        public virtual HIS_ROOM HIS_ROOM2 { get; set; }
    }
}

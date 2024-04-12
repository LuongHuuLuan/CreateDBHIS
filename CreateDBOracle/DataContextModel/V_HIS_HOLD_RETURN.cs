namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_HOLD_RETURN")]
    public partial class V_HIS_HOLD_RETURN
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

        [Required]
        [StringLength(12)]
        public string TREATMENT_CODE { get; set; }

        [Required]
        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [Required]
        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        public long TDL_PATIENT_DOB { get; set; }

        public short? TDL_PATIENT_IS_HAS_NOT_DAY_DOB { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        [Required]
        [StringLength(30)]
        public string TDL_PATIENT_FIRST_NAME { get; set; }

        [StringLength(70)]
        public string TDL_PATIENT_LAST_NAME { get; set; }

        public short? TREATMENT_IS_ACTIVE { get; set; }

        public short? TREATMENT_IS_PAUSE { get; set; }

        [StringLength(20)]
        public string RESPONSIBLE_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string RESPONSIBLE_ROOM_NAME { get; set; }

        [StringLength(4000)]
        public string DOC_HOLD_TYPE_NAMES { get; set; }

        [StringLength(4000)]
        public string DOC_HOLD_TYPE_IDS { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_HORE_HOHA")]
    public partial class V_HIS_HORE_HOHA
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
        public long HOLD_RETURN_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long HORE_HANDOVER_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PATIENT_ID { get; set; }

        [StringLength(15)]
        public string HEIN_CARD_NUMBER { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long HOLD_TIME { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string HOLD_LOGINNAME { get; set; }

        [StringLength(100)]
        public string HOLD_USERNAME { get; set; }

        public long? RETURN_TIME { get; set; }

        [StringLength(50)]
        public string RETURN_LOGINNAME { get; set; }

        [StringLength(100)]
        public string RETURN_USERNAME { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(10)]
        public string PATIENT_CODE { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(30)]
        public string FIRST_NAME { get; set; }

        [StringLength(70)]
        public string LAST_NAME { get; set; }

        [StringLength(101)]
        public string VIR_PATIENT_NAME { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long GENDER_ID { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long DOB { get; set; }

        public short? IS_HAS_NOT_DAY_DOB { get; set; }

        [StringLength(506)]
        public string VIR_ADDRESS { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(2)]
        public string GENDER_CODE { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(100)]
        public string GENDER_NAME { get; set; }

        [StringLength(4000)]
        public string DOC_HOLD_TYPE_NAMES { get; set; }
    }
}

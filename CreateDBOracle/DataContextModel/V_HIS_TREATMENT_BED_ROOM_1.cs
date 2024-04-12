namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_TREATMENT_BED_ROOM_1")]
    public partial class V_HIS_TREATMENT_BED_ROOM_1
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
        public long TREATMENT_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BED_ROOM_ID { get; set; }

        [StringLength(50)]
        public string ADD_LOGINNAME { get; set; }

        [StringLength(100)]
        public string ADD_USERNAME { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ADD_TIME { get; set; }

        [StringLength(50)]
        public string REMOVE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REMOVE_USERNAME { get; set; }

        public long? REMOVE_TIME { get; set; }

        public long? BED_ID { get; set; }

        public long? CO_TREATMENT_ID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(12)]
        public string TREATMENT_CODE { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PATIENT_ID { get; set; }

        [StringLength(200)]
        public string JSON_PRINT_ID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IN_TIME { get; set; }

        public long? OUT_TIME { get; set; }

        [StringLength(20)]
        public string TDL_HEIN_CARD_NUMBER { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(30)]
        public string TDL_PATIENT_FIRST_NAME { get; set; }

        [StringLength(70)]
        public string TDL_PATIENT_LAST_NAME { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_PATIENT_DOB { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_PATIENT_GENDER_ID { get; set; }

        [StringLength(6)]
        public string TDL_HEIN_MEDI_ORG_CODE { get; set; }

        [StringLength(500)]
        public string TDL_HEIN_MEDI_ORG_NAME { get; set; }

        [StringLength(500)]
        public string TDL_PATIENT_AVATAR_URL { get; set; }

        public long? TDL_TREATMENT_TYPE_ID { get; set; }

        public short? TDL_PATIENT_IS_HAS_NOT_DAY_DOB { get; set; }

        public short? IS_APPROVE_FINISH { get; set; }

        [StringLength(500)]
        public string APPROVE_FINISH_NOTE { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(20)]
        public string BED_ROOM_CODE { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(100)]
        public string BED_ROOM_NAME { get; set; }

        [StringLength(200)]
        public string BED_NAME { get; set; }

        [StringLength(10)]
        public string BED_CODE { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long DEPARTMENT_ID { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }
    }
}

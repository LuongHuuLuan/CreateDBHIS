namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_TRANSFUSION_SUM")]
    public partial class V_HIS_TRANSFUSION_SUM
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

        public long? DEPARTMENT_ID { get; set; }

        public long? ROOM_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EXP_MEST_BLOOD_ID { get; set; }

        public long? START_TIME { get; set; }

        public long? FINISH_TIME { get; set; }

        public long? NUM_ORDER { get; set; }

        [StringLength(50)]
        public string EXECUTE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string EXECUTE_USERNAME { get; set; }

        [StringLength(10)]
        public string ICD_CODE { get; set; }

        [StringLength(500)]
        public string ICD_NAME { get; set; }

        [StringLength(500)]
        public string ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string ICD_TEXT { get; set; }

        public decimal? TRANSFUSION_VOLUME { get; set; }

        [StringLength(100)]
        public string NOTE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(12)]
        public string TREATMENT_CODE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_PATIENT_DOB { get; set; }

        public short? TDL_PATIENT_IS_HAS_NOT_DAY_DOB { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BLOOD_ID { get; set; }

        [StringLength(3)]
        public string PATIENT_BLOOD_ABO_CODE { get; set; }

        [StringLength(3)]
        public string PATIENT_BLOOD_RH_CODE { get; set; }

        [StringLength(100)]
        public string PUC { get; set; }

        [StringLength(100)]
        public string TEST_TUBE { get; set; }

        [StringLength(100)]
        public string SCANGEL_GELCARD { get; set; }

        [StringLength(100)]
        public string COOMBS { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(20)]
        public string BLOOD_CODE { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BLOOD_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BLOOD_ABO_ID { get; set; }

        public long? BLOOD_RH_ID { get; set; }

        public long? EXPIRED_DATE { get; set; }

        public short? IS_INFECT { get; set; }

        [StringLength(100)]
        public string GIVE_NAME { get; set; }

        [StringLength(20)]
        public string GIVE_CODE { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(25)]
        public string BLOOD_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(500)]
        public string BLOOD_TYPE_NAME { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BLOOD_VOLUME_ID { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal VOLUME { get; set; }
    }
}

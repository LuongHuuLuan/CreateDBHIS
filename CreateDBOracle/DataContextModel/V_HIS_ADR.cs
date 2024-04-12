namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_ADR")]
    public partial class V_HIS_ADR
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
        [StringLength(10)]
        public string ADR_CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TREATMENT_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ADR_TIME { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string REPORT_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REPORT_USERNAME { get; set; }

        [StringLength(2000)]
        public string RELATED_TEST { get; set; }

        [StringLength(2000)]
        public string PATHOLOGICAL_HISTORY { get; set; }

        [StringLength(2000)]
        public string REACTION_METHOD { get; set; }

        [StringLength(4000)]
        public string DESCRIPTION { get; set; }

        [StringLength(100)]
        public string APPEAR_AFTER_TIME { get; set; }

        public short? SERIOUS_LEVEL { get; set; }

        public long? ADR_RESULT_ID { get; set; }

        public long? RELATIONSHIP_ID { get; set; }

        [StringLength(100)]
        public string RELATIONSHIP_ORTHER { get; set; }

        public long? EXPERTISE_STANDER_ID { get; set; }

        [StringLength(20)]
        public string EXPERTISE_STANDER_OTHER { get; set; }

        [StringLength(500)]
        public string BYT_COMMENT { get; set; }

        public decimal? WEIGHT { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(12)]
        public string TREATMENT_CODE { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IN_TIME { get; set; }

        public long? CLINICAL_IN_TIME { get; set; }

        public long? OUT_TIME { get; set; }

        [StringLength(10)]
        public string ICD_CODE { get; set; }

        [StringLength(500)]
        public string ICD_NAME { get; set; }

        [StringLength(500)]
        public string ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string ICD_TEXT { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(30)]
        public string TDL_PATIENT_FIRST_NAME { get; set; }

        [StringLength(70)]
        public string TDL_PATIENT_LAST_NAME { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_PATIENT_DOB { get; set; }

        public short? TDL_PATIENT_IS_HAS_NOT_DAY_DOB { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_PATIENT_GENDER_ID { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_CAREER_NAME { get; set; }
    }
}

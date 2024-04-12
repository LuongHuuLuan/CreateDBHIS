namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_MEDI_RECORD_2")]
    public partial class V_HIS_MEDI_RECORD_2
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

        [StringLength(20)]
        public string STORE_CODE { get; set; }

        public long? STORE_TIME { get; set; }

        public long? DATA_STORE_ID { get; set; }

        public long PATIENT_ID { get; set; }

        public long? MEDI_RECORD_TYPE_ID { get; set; }

        public decimal? VIR_STORE_YEAR { get; set; }

        public long? PROGRAM_ID { get; set; }

        public short? IS_NOT_STORED { get; set; }

        [StringLength(10)]
        public string ICD_CODE { get; set; }

        [StringLength(500)]
        public string ICD_NAME { get; set; }

        [StringLength(500)]
        public string ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string ICD_TEXT { get; set; }

        public long? END_ROOM_ID { get; set; }

        public long? END_DEPARTMENT_ID { get; set; }

        public long? SEED_CODE_TIME { get; set; }

        public decimal? VIR_SEED_CODE_YEAR { get; set; }

        public long? EMR_COVER_TYPE_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string FIRST_NAME { get; set; }

        [StringLength(70)]
        public string LAST_NAME { get; set; }

        [StringLength(101)]
        public string VIR_PATIENT_NAME { get; set; }

        [Required]
        [StringLength(10)]
        public string PATIENT_CODE { get; set; }

        public long DOB { get; set; }

        public long GENDER_ID { get; set; }

        [StringLength(506)]
        public string VIR_ADDRESS { get; set; }

        [StringLength(100)]
        public string MEDI_RECORD_TYPE_NAME { get; set; }

        [StringLength(10)]
        public string MEDI_RECORD_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string PROGRAM_NAME { get; set; }

        [StringLength(6)]
        public string PROGRAM_CODE { get; set; }

        [Required]
        [StringLength(2)]
        public string GENDER_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string GENDER_NAME { get; set; }

        [StringLength(4000)]
        public string TREATMENT_CODE { get; set; }

        [StringLength(4000)]
        public string IN_TIME { get; set; }

        [StringLength(4000)]
        public string OUT_TIME { get; set; }

        public decimal? GIVE_DATE { get; set; }

        public decimal? RECEIVE_DATE { get; set; }

        [StringLength(100)]
        public string END_ROOM_NAME { get; set; }

        [StringLength(100)]
        public string END_DEPARTMENT_NAME { get; set; }
    }
}

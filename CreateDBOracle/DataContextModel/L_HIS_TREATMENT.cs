namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.L_HIS_TREATMENT")]
    public partial class L_HIS_TREATMENT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public long? CREATE_TIME { get; set; }

        [Required]
        [StringLength(12)]
        public string TREATMENT_CODE { get; set; }

        [Required]
        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [Required]
        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        public long TDL_PATIENT_DOB { get; set; }

        [Required]
        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        [StringLength(10)]
        public string ICD_CODE { get; set; }

        [StringLength(500)]
        public string ICD_NAME { get; set; }

        [StringLength(500)]
        public string ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string ICD_TEXT { get; set; }

        public long IN_TIME { get; set; }

        public long? OUT_TIME { get; set; }

        public short? IS_ACTIVE { get; set; }

        public short? IS_PAUSE { get; set; }

        public short? IS_LOCK_HEIN { get; set; }

        public long IN_DATE { get; set; }

        public long? TREATMENT_END_TYPE_ID { get; set; }

        public short? TDL_KSK_CONTRACT_IS_RESTRICTED { get; set; }

        public long? TDL_KSK_CONTRACT_ID { get; set; }

        public long? DATA_STORE_ID { get; set; }

        public long? APPOINTMENT_TIME { get; set; }

        [StringLength(100)]
        public string TREATMENT_END_TYPE_NAME { get; set; }
    }
}

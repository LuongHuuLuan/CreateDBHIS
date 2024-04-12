namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.L_HIS_TREATMENT_3")]
    public partial class L_HIS_TREATMENT_3
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

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

        public long TDL_PATIENT_GENDER_ID { get; set; }

        public long IN_DATE { get; set; }

        public long? OUT_DATE { get; set; }

        public long IN_TIME { get; set; }

        public long? OUT_TIME { get; set; }

        public long? END_DEPARTMENT_ID { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        public short? IS_ACTIVE { get; set; }

        public short? IS_LOCK_HEIN { get; set; }

        public short? IS_PAUSE { get; set; }

        public long? TDL_PATIENT_TYPE_ID { get; set; }

        public long? MEDI_RECORD_ID { get; set; }

        public long? TDL_TREATMENT_TYPE_ID { get; set; }

        public long? FEE_LOCK_TIME { get; set; }

        [StringLength(20)]
        public string TDL_HEIN_CARD_NUMBER { get; set; }

        [StringLength(10)]
        public string ICD_CODE { get; set; }

        [StringLength(500)]
        public string ICD_NAME { get; set; }

        public long? END_ROOM_ID { get; set; }

        public long? TREATMENT_END_TYPE_ID { get; set; }

        public long? MEDI_RECORD_TYPE_ID { get; set; }

        [StringLength(500)]
        public string REJECT_STORE_REASON { get; set; }

        public long? APPROVAL_STORE_STT_ID { get; set; }

        public short? TDL_PATIENT_IS_HAS_NOT_DAY_DOB { get; set; }

        public long? LAST_DEPARTMENT_ID { get; set; }

        [StringLength(4000)]
        public string RECORD_INSPECTION_REJECT_NOTE { get; set; }

        public long? CLINICAL_IN_TIME { get; set; }

        public long? TDL_KSK_CONTRACT_ID { get; set; }

        public short? TDL_KSK_CONTRACT_IS_RESTRICTED { get; set; }

        [StringLength(50)]
        public string APPROVAL_LOGINNAME { get; set; }

        [StringLength(100)]
        public string APPROVAL_USERNAME { get; set; }

        public long? APPROVAL_TIME { get; set; }

        [StringLength(50)]
        public string UNAPPROVAL_LOGINNAME { get; set; }

        [StringLength(100)]
        public string UNAPPROVAL_USERNAME { get; set; }

        public long? UNAPPROVAL_TIME { get; set; }

        [Required]
        [StringLength(100)]
        public string GENDER_NAME { get; set; }

        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        [StringLength(100)]
        public string TREATMENT_END_TYPE_NAME { get; set; }

        [StringLength(100)]
        public string ROOM_NAME { get; set; }

        [StringLength(100)]
        public string LAST_DEPARTMENT_NAME { get; set; }
    }
}

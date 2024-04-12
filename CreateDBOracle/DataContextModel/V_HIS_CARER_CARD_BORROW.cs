namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_CARER_CARD_BORROW")]
    public partial class V_HIS_CARER_CARD_BORROW
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

        public long BORROW_TIME { get; set; }

        public long? GIVE_BACK_TIME { get; set; }

        public long CARER_CARD_ID { get; set; }

        public long TREATMENT_ID { get; set; }

        [StringLength(50)]
        public string GIVING_LOGINNAME { get; set; }

        [StringLength(100)]
        public string GIVING_USERNAME { get; set; }

        public short? IS_LOST { get; set; }

        [StringLength(50)]
        public string RECEIVING_LOGINNAME { get; set; }

        [StringLength(100)]
        public string RECEIVING_USERNAME { get; set; }

        [StringLength(500)]
        public string TDL_SERVICE_NAME { get; set; }

        [StringLength(25)]
        public string TDL_SERVICE_CODE { get; set; }

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

        [StringLength(20)]
        public string IN_CODE { get; set; }

        public long TDL_PATIENT_DOB { get; set; }

        public short? TDL_PATIENT_IS_HAS_NOT_DAY_DOB { get; set; }

        [StringLength(12)]
        public string TDL_PATIENT_MOBILE { get; set; }

        [StringLength(20)]
        public string TDL_PATIENT_PHONE { get; set; }

        [StringLength(9)]
        public string TDL_PATIENT_CMND_NUMBER { get; set; }

        [StringLength(12)]
        public string TDL_PATIENT_CCCD_NUMBER { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_CAREER_NAME { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_ETHNIC_NAME { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_MILITARY_RANK_NAME { get; set; }

        [StringLength(500)]
        public string TDL_PATIENT_WORK_PLACE { get; set; }

        [StringLength(500)]
        public string TDL_PATIENT_WORK_PLACE_NAME { get; set; }

        public long? TDL_PATIENT_POSITION_ID { get; set; }

        public long IN_TIME { get; set; }

        [StringLength(20)]
        public string TDL_HEIN_CARD_NUMBER { get; set; }

        public long? TDL_PATIENT_TYPE_ID { get; set; }

        public long? TDL_PATIENT_CLASSIFY_ID { get; set; }

        public short? TREATMENT_IS_ACTIVE { get; set; }

        [StringLength(100)]
        public string PATIENT_CLASSIFY_NAME { get; set; }

        [StringLength(100)]
        public string POSITION_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string CARER_CARD_NUMBER { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_HEIN_APPROVAL")]
    public partial class V_HIS_HEIN_APPROVAL
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

        [Required]
        [StringLength(12)]
        public string HEIN_APPROVAL_CODE { get; set; }

        public long TREATMENT_ID { get; set; }

        public long TREATMENT_TYPE_ID { get; set; }

        public long CASHIER_ROOM_ID { get; set; }

        [StringLength(50)]
        public string EXECUTE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string EXECUTE_USERNAME { get; set; }

        public long? EXECUTE_TIME { get; set; }

        [StringLength(1000)]
        public string XML_URL { get; set; }

        [Required]
        [StringLength(2)]
        public string LEVEL_CODE { get; set; }

        [Required]
        [StringLength(2)]
        public string RIGHT_ROUTE_CODE { get; set; }

        [StringLength(2)]
        public string RIGHT_ROUTE_TYPE_CODE { get; set; }

        [StringLength(2)]
        public string LIVE_AREA_CODE { get; set; }

        [Required]
        [StringLength(6)]
        public string HEIN_MEDI_ORG_CODE { get; set; }

        [StringLength(500)]
        public string HEIN_MEDI_ORG_NAME { get; set; }

        [StringLength(2)]
        public string HAS_BIRTH_CERTIFICATE { get; set; }

        [Required]
        [StringLength(15)]
        public string HEIN_CARD_NUMBER { get; set; }

        public long HEIN_CARD_FROM_TIME { get; set; }

        public long HEIN_CARD_TO_TIME { get; set; }

        [Required]
        [StringLength(500)]
        public string ADDRESS { get; set; }

        [StringLength(2)]
        public string JOIN_5_YEAR { get; set; }

        [StringLength(2)]
        public string PAID_6_MONTH { get; set; }

        public long? FREE_CO_PAID_TIME { get; set; }

        public long? JOIN_5_YEAR_TIME { get; set; }

        [Required]
        [StringLength(2)]
        public string TREATMENT_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string TREATMENT_TYPE_NAME { get; set; }

        [Required]
        [StringLength(2)]
        public string HEIN_TREATMENT_TYPE_CODE { get; set; }

        [Required]
        [StringLength(12)]
        public string TREATMENT_CODE { get; set; }

        public long PATIENT_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [Required]
        [StringLength(30)]
        public string TDL_PATIENT_FIRST_NAME { get; set; }

        [StringLength(70)]
        public string TDL_PATIENT_LAST_NAME { get; set; }

        [Required]
        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        public long TDL_PATIENT_DOB { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        public short? TDL_PATIENT_IS_HAS_NOT_DAY_DOB { get; set; }

        [Required]
        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        public long TDL_PATIENT_GENDER_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string CASHIER_ROOM_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string CASHIER_ROOM_NAME { get; set; }

        public long ROOM_ID { get; set; }

        public long DEPARTMENT_ID { get; set; }

        public long BRANCH_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }
    }
}

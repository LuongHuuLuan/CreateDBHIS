namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_DEPOSIT_REQ")]
    public partial class V_HIS_DEPOSIT_REQ
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
        [StringLength(8)]
        public string DEPOSIT_REQ_CODE { get; set; }

        public long TREATMENT_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public long REQUEST_ROOM_ID { get; set; }

        public long REQUEST_DEPARTMENT_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string REQUEST_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REQUEST_USERNAME { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        public long? DEPOSIT_ID { get; set; }

        public long? TRANS_REQ_ID { get; set; }

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

        public long TDL_PATIENT_DOB { get; set; }

        [Required]
        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        [Required]
        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        [StringLength(20)]
        public string TDL_HEIN_CARD_NUMBER { get; set; }

        public long? TDL_PATIENT_TYPE_ID { get; set; }

        [StringLength(6)]
        public string TDL_HEIN_MEDI_ORG_CODE { get; set; }

        public long? TDL_TREATMENT_TYPE_ID { get; set; }

        [StringLength(500)]
        public string TDL_HEIN_MEDI_ORG_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        public long BRANCH_ID { get; set; }

        [StringLength(20)]
        public string ROOM_CODE { get; set; }

        [StringLength(100)]
        public string ROOM_NAME { get; set; }

        [Required]
        [StringLength(2)]
        public string ROOM_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string ROOM_TYPE_NAME { get; set; }

        [StringLength(12)]
        public string BANK_TRANSACTION_CODE { get; set; }

        public long? BANK_TRANSACTION_TIME { get; set; }

        public long? TRANSACTION_TIME { get; set; }

        public decimal? TRANSACTION_AMOUNT { get; set; }

        public long? TRANSACTION_NUM_ORDER { get; set; }

        public short? TRANSACTION_IS_CANCEL { get; set; }

        [StringLength(100)]
        public string ACCOUNT_BOOK_NAME { get; set; }

        [StringLength(8)]
        public string SYMBOL_CODE { get; set; }

        [StringLength(11)]
        public string TEMPLATE_CODE { get; set; }

        [StringLength(2000)]
        public string BANK_MESSAGE { get; set; }
    }
}

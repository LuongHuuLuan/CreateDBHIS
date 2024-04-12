namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_ROOM")]
    public partial class V_HIS_ROOM
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

        public long ROOM_TYPE_ID { get; set; }

        public long DEPARTMENT_ID { get; set; }

        public long? ROOM_GROUP_ID { get; set; }

        [StringLength(10)]
        public string ORDER_ISSUE_CODE { get; set; }

        [StringLength(10)]
        public string G_CODE { get; set; }

        public long? HOLD_ORDER { get; set; }

        public short? IS_PAUSE { get; set; }

        public short? IS_AUTO_SHOW_REQUEST { get; set; }

        public short? IS_USE_KIOSK { get; set; }

        public short? IS_RESTRICT_MEDICINE_TYPE { get; set; }

        public short? IS_RESTRICT_EXECUTE_ROOM { get; set; }

        public short? IS_RESTRICT_TIME { get; set; }

        public short? IS_RESTRICT_PATIENT_TYPE { get; set; }

        public long? SPECIALITY_ID { get; set; }

        [StringLength(200)]
        public string ADDRESS { get; set; }

        [StringLength(50)]
        public string RESPONSIBLE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string RESPONSIBLE_USERNAME { get; set; }

        public short? IS_RESTRICT_REQ_SERVICE { get; set; }

        public short? IS_ALLOW_NO_ICD { get; set; }

        public long? AREA_ID { get; set; }

        [StringLength(200)]
        public string SCREEN_SAVER_MODULE_LINK { get; set; }

        public long? DEPOSIT_ACCOUNT_BOOK_ID { get; set; }

        public long? DEFAULT_CASHIER_ROOM_ID { get; set; }

        public long? RESPONSIBLE_TIME { get; set; }

        [StringLength(1000)]
        public string WORKING_LOGINNAME { get; set; }

        [StringLength(4000)]
        public string WORKING_USERNAME { get; set; }

        [StringLength(50)]
        public string BHYT_CODE { get; set; }

        public short? IS_BLOCK_NUM_ORDER { get; set; }

        [StringLength(100)]
        public string DEFAULT_DRUG_STORE_IDS { get; set; }

        public long? DEFAULT_SERVICE_ID { get; set; }

        [StringLength(500)]
        public string JSON_PRINT_ID { get; set; }

        public long? BILL_ACCOUNT_BOOK_ID { get; set; }

        [Required]
        [StringLength(2)]
        public string ROOM_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string ROOM_TYPE_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        public long BRANCH_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string BRANCH_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string BRANCH_NAME { get; set; }

        [StringLength(6)]
        public string HEIN_MEDI_ORG_CODE { get; set; }

        [StringLength(20)]
        public string ROOM_CODE { get; set; }

        [StringLength(100)]
        public string ROOM_NAME { get; set; }

        public decimal? IS_EXAM { get; set; }
    }
}

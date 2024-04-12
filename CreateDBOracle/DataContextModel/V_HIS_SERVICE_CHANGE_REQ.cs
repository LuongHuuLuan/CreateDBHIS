namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_SERVICE_CHANGE_REQ")]
    public partial class V_HIS_SERVICE_CHANGE_REQ
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

        public long TDL_SERVICE_REQ_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string REQUEST_LOGINNAME { get; set; }

        [Required]
        [StringLength(100)]
        public string REQUEST_USERNAME { get; set; }

        [StringLength(50)]
        public string APPROVAL_LOGINNAME { get; set; }

        [StringLength(100)]
        public string APPROVAL_USERNAME { get; set; }

        [StringLength(50)]
        public string APPROVAL_CASHIER_LOGINNAME { get; set; }

        [StringLength(100)]
        public string APPROVAL_CASHIER_USERNAME { get; set; }

        public long ALTER_SERVICE_ID { get; set; }

        public long SERE_SERV_ID { get; set; }

        public long PATIENT_TYPE_ID { get; set; }

        public long? PRIMARY_PATIENT_TYPE_ID { get; set; }

        public long? ALTER_SERE_SERV_ID { get; set; }

        [Required]
        [StringLength(12)]
        public string SERVICE_REQ_CODE { get; set; }

        [Required]
        [StringLength(12)]
        public string TDL_TREATMENT_CODE { get; set; }

        [Required]
        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        public long EXECUTE_ROOM_ID { get; set; }

        public long REQUEST_ROOM_ID { get; set; }

        [Required]
        [StringLength(25)]
        public string TDL_SERVICE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string TDL_SERVICE_NAME { get; set; }

        public decimal AMOUNT { get; set; }

        [Required]
        [StringLength(20)]
        public string EXECUTE_ROOM_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string EXECUTE_ROOM_NAME { get; set; }

        [StringLength(20)]
        public string REQUEST_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string REQUEST_ROOM_NAME { get; set; }

        public long BRANCH_ID { get; set; }

        [Required]
        [StringLength(25)]
        public string ALTER_SERVICE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string ALTER_SERVICE_NAME { get; set; }
    }
}

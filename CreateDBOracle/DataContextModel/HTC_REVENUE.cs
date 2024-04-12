namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HTC_REVENUE")]
    public partial class HTC_REVENUE
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
        [StringLength(14)]
        public string REVENUE_CODE { get; set; }

        public long REVENUE_TIME { get; set; }

        public long PERIOD_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal PRICE { get; set; }

        [Required]
        [StringLength(25)]
        public string SERVICE_CODE { get; set; }

        [StringLength(500)]
        public string SERVICE_NAME { get; set; }

        [Required]
        [StringLength(2)]
        public string PATIENT_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string PATIENT_TYPE_NAME { get; set; }

        [Required]
        [StringLength(2)]
        public string SERVICE_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string SERVICE_TYPE_NAME { get; set; }

        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        [Required]
        [StringLength(10)]
        public string REQUEST_DEPARTMENT_CODE { get; set; }

        [StringLength(100)]
        public string REQUEST_DEPARTMENT_NAME { get; set; }

        [StringLength(10)]
        public string REQUEST_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string REQUEST_ROOM_NAME { get; set; }

        [StringLength(2)]
        public string REQUEST_ROOM_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string REQUEST_ROOM_TYPE_NAME { get; set; }

        [StringLength(50)]
        public string REQUEST_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REQUEST_USERNAME { get; set; }

        [Required]
        [StringLength(10)]
        public string EXECUTE_DEPARTMENT_CODE { get; set; }

        [StringLength(100)]
        public string EXECUTE_DEPARTMENT_NAME { get; set; }

        [StringLength(10)]
        public string EXECUTE_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string EXECUTE_ROOM_NAME { get; set; }

        [StringLength(2)]
        public string EXECUTE_ROOM_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string EXECUTE_ROOM_TYPE_NAME { get; set; }

        [StringLength(50)]
        public string EXECUTE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string EXECUTE_USERNAME { get; set; }

        public long? SERE_SERV_ID { get; set; }

        public decimal? HEIN_PRICE { get; set; }

        public decimal? VIR_PATIENT_PRICE { get; set; }

        public decimal? VIR_TOTAL_PRICE { get; set; }

        public decimal? VIR_TOTAL_HEIN_PRICE { get; set; }

        public decimal? VIR_TOTAL_PATIENT_PRICE { get; set; }

        [StringLength(10)]
        public string PATIENT_CODE { get; set; }

        [StringLength(100)]
        public string PATIENT_NAME { get; set; }

        public long? DOB { get; set; }

        public long? IN_TIME { get; set; }

        public long? OUT_TIME { get; set; }

        [StringLength(20)]
        public string XANHPON_SYMBOL { get; set; }

        public long? BILL_NUMBER { get; set; }

        public virtual HTC_PERIOD HTC_PERIOD { get; set; }
    }
}

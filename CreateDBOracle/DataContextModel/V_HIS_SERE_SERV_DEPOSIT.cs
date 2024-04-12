namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_SERE_SERV_DEPOSIT")]
    public partial class V_HIS_SERE_SERV_DEPOSIT
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

        public long SERE_SERV_ID { get; set; }

        public long DEPOSIT_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public short? IS_CANCEL { get; set; }

        public long TDL_TREATMENT_ID { get; set; }

        public long? TDL_SERVICE_REQ_ID { get; set; }

        public long TDL_SERVICE_ID { get; set; }

        [Required]
        [StringLength(25)]
        public string TDL_SERVICE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string TDL_SERVICE_NAME { get; set; }

        public long TDL_SERVICE_TYPE_ID { get; set; }

        public long TDL_SERVICE_UNIT_ID { get; set; }

        public long TDL_PATIENT_TYPE_ID { get; set; }

        public long? TDL_HEIN_SERVICE_TYPE_ID { get; set; }

        public long TDL_REQUEST_DEPARTMENT_ID { get; set; }

        public long TDL_EXECUTE_DEPARTMENT_ID { get; set; }

        public long? TDL_SERE_SERV_PARENT_ID { get; set; }

        public short? TDL_IS_OUT_PARENT_FEE { get; set; }

        public decimal TDL_AMOUNT { get; set; }

        public short? TDL_IS_EXPEND { get; set; }

        public decimal? TDL_HEIN_PRICE { get; set; }

        public decimal? TDL_HEIN_LIMIT_PRICE { get; set; }

        public decimal TDL_VIR_PRICE { get; set; }

        public decimal TDL_VIR_PRICE_NO_ADD_PRICE { get; set; }

        public decimal TDL_VIR_HEIN_PRICE { get; set; }

        public decimal TDL_VIR_TOTAL_PRICE { get; set; }

        public decimal TDL_VIR_TOTAL_HEIN_PRICE { get; set; }

        public decimal TDL_VIR_TOTAL_PATIENT_PRICE { get; set; }

        public long? SERVICE_REQ_STT_ID { get; set; }

        public long? SERVICE_REQ_TYPE_ID { get; set; }

        [StringLength(12)]
        public string SERVICE_REQ_CODE { get; set; }

        public long? INTRUCTION_TIME { get; set; }

        [Required]
        [StringLength(2)]
        public string SERVICE_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_TYPE_NAME { get; set; }

        [Required]
        [StringLength(12)]
        public string TRANSACTION_CODE { get; set; }

        public long PAY_FORM_ID { get; set; }

        [Required]
        [StringLength(2)]
        public string PAY_FORM_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string PAY_FORM_NAME { get; set; }
    }
}

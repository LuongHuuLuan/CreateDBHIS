namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SERE_SERV_BILL")]
    public partial class HIS_SERE_SERV_BILL
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

        public long BILL_ID { get; set; }

        public decimal PRICE { get; set; }

        public decimal VAT_RATIO { get; set; }

        public short? IS_CANCEL { get; set; }

        public long TDL_TREATMENT_ID { get; set; }

        public long? TDL_BILL_TYPE_ID { get; set; }

        public long? TDL_SERVICE_REQ_ID { get; set; }

        public decimal? PATIENT_BHYT_PRICE { get; set; }

        public decimal? PATIENT_PAY_PRICE { get; set; }

        public decimal? TDL_PRIMARY_PRICE { get; set; }

        public decimal? TDL_LIMIT_PRICE { get; set; }

        public decimal? TDL_AMOUNT { get; set; }

        public decimal? TDL_PRICE { get; set; }

        public decimal? TDL_ORIGINAL_PRICE { get; set; }

        public decimal? TDL_HEIN_PRICE { get; set; }

        public decimal? TDL_HEIN_RATIO { get; set; }

        public decimal? TDL_HEIN_LIMIT_PRICE { get; set; }

        public decimal? TDL_HEIN_LIMIT_RATIO { get; set; }

        public decimal? TDL_HEIN_NORMAL_PRICE { get; set; }

        public decimal? TDL_ADD_PRICE { get; set; }

        public decimal? TDL_OVERTIME_PRICE { get; set; }

        public decimal? TDL_DISCOUNT { get; set; }

        public decimal? TDL_VAT_RATIO { get; set; }

        public long? TDL_SERVICE_TYPE_ID { get; set; }

        public long? TDL_HEIN_SERVICE_TYPE_ID { get; set; }

        public decimal? TDL_USER_PRICE { get; set; }

        public decimal? TDL_OTHER_SOURCE_PRICE { get; set; }

        public decimal? TDL_TOTAL_HEIN_PRICE { get; set; }

        public decimal? TDL_TOTAL_PATIENT_PRICE { get; set; }

        public decimal? TDL_TOTAL_PATIENT_PRICE_BHYT { get; set; }

        public long? TDL_SERVICE_ID { get; set; }

        [StringLength(25)]
        public string TDL_SERVICE_CODE { get; set; }

        [StringLength(500)]
        public string TDL_SERVICE_NAME { get; set; }

        public long? TDL_SERVICE_UNIT_ID { get; set; }

        public long? TDL_PATIENT_TYPE_ID { get; set; }

        public long? TDL_REQUEST_DEPARTMENT_ID { get; set; }

        public long? TDL_EXECUTE_DEPARTMENT_ID { get; set; }

        public long? TDL_SERE_SERV_PARENT_ID { get; set; }

        public short? TDL_IS_OUT_PARENT_FEE { get; set; }

        public decimal? TDL_REAL_PRICE { get; set; }

        public decimal? TDL_REAL_PATIENT_PRICE { get; set; }

        public decimal? TDL_REAL_HEIN_PRICE { get; set; }

        public long? TDL_PRIMARY_PATIENT_TYPE_ID { get; set; }

        public virtual HIS_SERE_SERV HIS_SERE_SERV { get; set; }

        public virtual HIS_TRANSACTION HIS_TRANSACTION { get; set; }
    }
}

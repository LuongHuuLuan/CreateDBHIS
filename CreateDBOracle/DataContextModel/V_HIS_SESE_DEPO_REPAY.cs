namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_SESE_DEPO_REPAY")]
    public partial class V_HIS_SESE_DEPO_REPAY
    {
        [Key]
        [Column(Order = 0)]
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

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERE_SERV_DEPOSIT_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long REPAY_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal AMOUNT { get; set; }

        public short? IS_CANCEL { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_TREATMENT_ID { get; set; }

        public long? TDL_SERVICE_REQ_ID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_SERVICE_ID { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(25)]
        public string TDL_SERVICE_CODE { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(500)]
        public string TDL_SERVICE_NAME { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_SERVICE_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_SERVICE_UNIT_ID { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_PATIENT_TYPE_ID { get; set; }

        public long? TDL_HEIN_SERVICE_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_REQUEST_DEPARTMENT_ID { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_EXECUTE_DEPARTMENT_ID { get; set; }

        public long? TDL_SERE_SERV_PARENT_ID { get; set; }

        public short? TDL_IS_OUT_PARENT_FEE { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal TDL_AMOUNT { get; set; }

        public short? TDL_IS_EXPEND { get; set; }

        public decimal? TDL_HEIN_PRICE { get; set; }

        public decimal? TDL_HEIN_LIMIT_PRICE { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal TDL_VIR_PRICE { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal TDL_VIR_PRICE_NO_ADD_PRICE { get; set; }

        [Key]
        [Column(Order = 16)]
        public decimal TDL_VIR_HEIN_PRICE { get; set; }

        [Key]
        [Column(Order = 17)]
        public decimal TDL_VIR_TOTAL_PRICE { get; set; }

        [Key]
        [Column(Order = 18)]
        public decimal TDL_VIR_TOTAL_HEIN_PRICE { get; set; }

        [Key]
        [Column(Order = 19)]
        public decimal TDL_VIR_TOTAL_PATIENT_PRICE { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERE_SERV_ID { get; set; }
    }
}

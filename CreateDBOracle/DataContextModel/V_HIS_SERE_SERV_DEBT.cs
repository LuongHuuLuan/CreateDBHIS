namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_SERE_SERV_DEBT")]
    public partial class V_HIS_SERE_SERV_DEBT
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
        public long SERE_SERV_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long DEBT_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_TREATMENT_ID { get; set; }

        public long? TDL_SERVICE_REQ_ID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_SERVICE_ID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(25)]
        public string TDL_SERVICE_CODE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(500)]
        public string TDL_SERVICE_NAME { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_SERVICE_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_SERVICE_UNIT_ID { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_PATIENT_TYPE_ID { get; set; }

        public long? TDL_HEIN_SERVICE_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_REQUEST_DEPARTMENT_ID { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_EXECUTE_DEPARTMENT_ID { get; set; }

        public long? TDL_SERE_SERV_PARENT_ID { get; set; }

        public short? TDL_IS_OUT_PARENT_FEE { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal TDL_AMOUNT { get; set; }

        public short? TDL_IS_EXPEND { get; set; }

        public decimal? TDL_HEIN_LIMIT_PRICE { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal DEBT_PRICE { get; set; }

        public decimal? TOTAL_PREVIOUS_DEBT_PRICE { get; set; }

        public short? IS_CANCEL { get; set; }

        public long? SERVICE_REQ_STT_ID { get; set; }

        public long? SERVICE_REQ_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(2)]
        public string SERVICE_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(100)]
        public string SERVICE_TYPE_NAME { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }
    }
}

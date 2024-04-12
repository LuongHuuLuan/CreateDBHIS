namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_EXP_MEST_CHMS_1")]
    public partial class V_HIS_EXP_MEST_CHMS_1
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
        [StringLength(12)]
        public string EXP_MEST_CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EXP_MEST_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EXP_MEST_STT_ID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MEDI_STOCK_ID { get; set; }

        [StringLength(50)]
        public string REQ_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REQ_USERNAME { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long REQ_ROOM_ID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long REQ_DEPARTMENT_ID { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CREATE_DATE { get; set; }

        [StringLength(50)]
        public string LAST_EXP_LOGINNAME { get; set; }

        [StringLength(100)]
        public string LAST_EXP_USERNAME { get; set; }

        public long? LAST_EXP_TIME { get; set; }

        public long? FINISH_TIME { get; set; }

        public long? FINISH_DATE { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        public long? EXP_MEST_REASON_ID { get; set; }

        public long? SERVICE_REQ_ID { get; set; }

        public decimal? TDL_TOTAL_PRICE { get; set; }

        [StringLength(12)]
        public string TDL_SERVICE_REQ_CODE { get; set; }

        public long? TDL_INTRUCTION_TIME { get; set; }

        public long? TDL_INTRUCTION_DATE { get; set; }

        public long? TDL_TREATMENT_ID { get; set; }

        [StringLength(12)]
        public string TDL_TREATMENT_CODE { get; set; }

        public long? IMP_MEDI_STOCK_ID { get; set; }

        public long? AGGR_EXP_MEST_ID { get; set; }

        public long? AGGR_USE_TIME { get; set; }

        [StringLength(12)]
        public string TDL_AGGR_EXP_MEST_CODE { get; set; }

        public long? XBTT_EXP_MEST_ID { get; set; }

        [StringLength(12)]
        public string TDL_XBTT_EXP_MEST_CODE { get; set; }

        public long? MANU_IMP_MEST_ID { get; set; }

        [StringLength(12)]
        public string TDL_MANU_IMP_MEST_CODE { get; set; }

        public long? PRESCRIPTION_ID { get; set; }

        [StringLength(12)]
        public string TDL_PRESCRIPTION_CODE { get; set; }

        public long? SUPPLIER_ID { get; set; }

        public short? IS_NOT_TAKEN { get; set; }

        public short? IS_EXPORT_EQUAL_APPROVE { get; set; }

        public short? IS_EXPORT_EQUAL_REQUEST { get; set; }

        public short? IS_HTX { get; set; }

        public long? BILL_ID { get; set; }

        public long? SALE_PATIENT_TYPE_ID { get; set; }

        public decimal? DISCOUNT { get; set; }

        public long? TDL_PATIENT_ID { get; set; }

        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        [StringLength(30)]
        public string TDL_PATIENT_FIRST_NAME { get; set; }

        [StringLength(70)]
        public string TDL_PATIENT_LAST_NAME { get; set; }

        public long? TDL_PATIENT_DOB { get; set; }

        public short? TDL_PATIENT_IS_HAS_NOT_DAY_DOB { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        public long? TDL_PATIENT_GENDER_ID { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        [StringLength(50)]
        public string TDL_PRESCRIPTION_REQ_LOGINNAME { get; set; }

        [StringLength(100)]
        public string TDL_PRESCRIPTION_REQ_USERNAME { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(2)]
        public string EXP_MEST_STT_CODE { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(100)]
        public string EXP_MEST_STT_NAME { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(20)]
        public string MEDI_STOCK_CODE { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(100)]
        public string MEDI_STOCK_NAME { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ROOM_ID { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(20)]
        public string IMP_MEDI_STOCK_CODE { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(100)]
        public string IMP_MEDI_STOCK_NAME { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IMP_ROOM_ID { get; set; }

        public short? IS_AUTO_CREATE_CHMS_IMP { get; set; }

        public decimal? EXISTS_IMP { get; set; }
    }
}

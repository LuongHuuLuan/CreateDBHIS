namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_EXP_MEST_MATERIAL_3")]
    public partial class V_HIS_EXP_MEST_MATERIAL_3
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

        public decimal? BK_AMOUNT { get; set; }

        public long? EXP_MEST_ID { get; set; }

        public long? MATERIAL_ID { get; set; }

        public long? TDL_MEDI_STOCK_ID { get; set; }

        public long? MEDI_STOCK_PERIOD_ID { get; set; }

        public long? TDL_MATERIAL_TYPE_ID { get; set; }

        public long? TDL_AGGR_EXP_MEST_ID { get; set; }

        public long? EXP_MEST_MATY_REQ_ID { get; set; }

        public long? CK_IMP_MEST_MATERIAL_ID { get; set; }

        public short? IS_EXPORT { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal AMOUNT { get; set; }

        public decimal? PRICE { get; set; }

        public decimal? VAT_RATIO { get; set; }

        public decimal? DISCOUNT { get; set; }

        public long? NUM_ORDER { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        [StringLength(50)]
        public string APPROVAL_LOGINNAME { get; set; }

        [StringLength(100)]
        public string APPROVAL_USERNAME { get; set; }

        public long? APPROVAL_TIME { get; set; }

        public long? APPROVAL_DATE { get; set; }

        [StringLength(50)]
        public string EXP_LOGINNAME { get; set; }

        [StringLength(100)]
        public string EXP_USERNAME { get; set; }

        public long? EXP_TIME { get; set; }

        public long? EXP_DATE { get; set; }

        public decimal? TH_AMOUNT { get; set; }

        public long? PATIENT_TYPE_ID { get; set; }

        public long? SERE_SERV_PARENT_ID { get; set; }

        public short? IS_EXPEND { get; set; }

        public short? IS_OUT_PARENT_FEE { get; set; }

        public long? TDL_SERVICE_REQ_ID { get; set; }

        public long? STENT_ORDER { get; set; }

        public long? TDL_TREATMENT_ID { get; set; }

        public long? EQUIPMENT_SET_ID { get; set; }

        public long? EQUIPMENT_SET_ORDER { get; set; }

        public short? IS_USE_CLIENT_PRICE { get; set; }

        public decimal? VIR_PRICE { get; set; }

        public long? EXPEND_TYPE_ID { get; set; }

        [StringLength(50)]
        public string SERIAL_NUMBER { get; set; }

        public long? REMAIN_REUSE_COUNT { get; set; }

        public short? IS_NOT_PRES { get; set; }

        public short? USE_ORIGINAL_UNIT_FOR_PRES { get; set; }

        public decimal? BCS_REQ_AMOUNT { get; set; }

        public decimal? FAILED_AMOUNT { get; set; }

        [StringLength(1000)]
        public string TUTORIAL { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(12)]
        public string EXP_MEST_CODE { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EXP_MEST_TYPE_ID { get; set; }

        public long? AGGR_EXP_MEST_ID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MEDI_STOCK_ID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EXP_MEST_STT_ID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long REQ_ROOM_ID { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long REQ_DEPARTMENT_ID { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal IMP_PRICE { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal IMP_VAT_RATIO { get; set; }

        public long? BID_ID { get; set; }

        [StringLength(100)]
        public string PACKAGE_NUMBER { get; set; }

        public long? EXPIRED_DATE { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MATERIAL_TYPE_ID { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        public long? IMP_TIME { get; set; }

        public long? SUPPLIER_ID { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(25)]
        public string MATERIAL_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(500)]
        public string MATERIAL_TYPE_NAME { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_ID { get; set; }

        [StringLength(100)]
        public string NATIONAL_NAME { get; set; }

        public long? MANUFACTURER_ID { get; set; }

        public long? MATERIAL_TYPE_NUM_ORDER { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_UNIT_ID { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        public long? MEDICINE_NUM_ORDER { get; set; }

        public long? MATERIAL_NUM_ORDER { get; set; }

        public decimal? CONVERT_RATIO { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(20)]
        public string MEDI_STOCK_CODE { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(100)]
        public string MEDI_STOCK_NAME { get; set; }

        [StringLength(6)]
        public string PATIENT_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string PATIENT_TYPE_NAME { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(100)]
        public string EXP_MEST_TYPE_NAME { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(2)]
        public string EXP_MEST_TYPE_CODE { get; set; }

        [StringLength(3)]
        public string CONVERT_UNIT_CODE { get; set; }

        [StringLength(100)]
        public string CONVERT_UNIT_NAME { get; set; }
    }
}

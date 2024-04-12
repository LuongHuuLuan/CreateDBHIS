namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_SERE_SERV_3")]
    public partial class V_HIS_SERE_SERV_3
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
        public long SERVICE_ID { get; set; }

        public long? SERVICE_REQ_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PATIENT_TYPE_ID { get; set; }

        public long? PRIMARY_PATIENT_TYPE_ID { get; set; }

        public decimal? PRIMARY_PRICE { get; set; }

        public decimal? LIMIT_PRICE { get; set; }

        public long? PARENT_ID { get; set; }

        public long? HEIN_APPROVAL_ID { get; set; }

        [StringLength(2000)]
        public string JSON_PATIENT_TYPE_ALTER { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal AMOUNT { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal PRICE { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal ORIGINAL_PRICE { get; set; }

        public decimal? HEIN_PRICE { get; set; }

        public decimal? HEIN_RATIO { get; set; }

        public decimal? HEIN_LIMIT_PRICE { get; set; }

        public decimal? HEIN_LIMIT_RATIO { get; set; }

        public decimal? HEIN_NORMAL_PRICE { get; set; }

        public decimal? ADD_PRICE { get; set; }

        public decimal? OVERTIME_PRICE { get; set; }

        public decimal? DISCOUNT { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal VAT_RATIO { get; set; }

        public long? SHARE_COUNT { get; set; }

        public long? STENT_ORDER { get; set; }

        public short? IS_EXPEND { get; set; }

        public short? IS_NO_PAY { get; set; }

        public short? IS_NO_EXECUTE { get; set; }

        public short? IS_OUT_PARENT_FEE { get; set; }

        public short? IS_NO_HEIN_DIFFERENCE { get; set; }

        public short? IS_SPECIMEN { get; set; }

        public short? IS_ADDITION { get; set; }

        public short? IS_SENT_EXT { get; set; }

        public long? EXECUTE_TIME { get; set; }

        [StringLength(15)]
        public string HEIN_CARD_NUMBER { get; set; }

        public long? MEDICINE_ID { get; set; }

        public long? MATERIAL_ID { get; set; }

        public long? EXP_MEST_MEDICINE_ID { get; set; }

        public long? EXP_MEST_MATERIAL_ID { get; set; }

        public long? BLOOD_ID { get; set; }

        public long? EKIP_ID { get; set; }

        public long? PACKAGE_ID { get; set; }

        public long? EQUIPMENT_SET_ID { get; set; }

        public long? EQUIPMENT_SET_ORDER { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_INTRUCTION_TIME { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_INTRUCTION_DATE { get; set; }

        public long? TDL_PATIENT_ID { get; set; }

        public long? TDL_TREATMENT_ID { get; set; }

        [StringLength(12)]
        public string TDL_TREATMENT_CODE { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(25)]
        public string TDL_SERVICE_CODE { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(500)]
        public string TDL_SERVICE_NAME { get; set; }

        [StringLength(100)]
        public string TDL_HEIN_SERVICE_BHYT_CODE { get; set; }

        [StringLength(500)]
        public string TDL_HEIN_SERVICE_BHYT_NAME { get; set; }

        [StringLength(20)]
        public string TDL_HEIN_ORDER { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_SERVICE_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_SERVICE_UNIT_ID { get; set; }

        public long? TDL_HEIN_SERVICE_TYPE_ID { get; set; }

        [StringLength(500)]
        public string TDL_ACTIVE_INGR_BHYT_CODE { get; set; }

        [StringLength(1000)]
        public string TDL_ACTIVE_INGR_BHYT_NAME { get; set; }

        [StringLength(1000)]
        public string TDL_MEDICINE_CONCENTRA { get; set; }

        [StringLength(50)]
        public string TDL_MEDICINE_BID_NUM_ORDER { get; set; }

        [StringLength(500)]
        public string TDL_MEDICINE_REGISTER_NUMBER { get; set; }

        [StringLength(100)]
        public string TDL_MEDICINE_PACKAGE_NUMBER { get; set; }

        [StringLength(12)]
        public string TDL_SERVICE_REQ_CODE { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_REQUEST_ROOM_ID { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_REQUEST_DEPARTMENT_ID { get; set; }

        [StringLength(50)]
        public string TDL_REQUEST_LOGINNAME { get; set; }

        [StringLength(100)]
        public string TDL_REQUEST_USERNAME { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_EXECUTE_ROOM_ID { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_EXECUTE_DEPARTMENT_ID { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_EXECUTE_BRANCH_ID { get; set; }

        public long? TDL_EXECUTE_GROUP_ID { get; set; }

        [StringLength(3)]
        public string TDL_SPECIALITY_CODE { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_SERVICE_REQ_TYPE_ID { get; set; }

        [StringLength(2)]
        public string TDL_HST_BHYT_CODE { get; set; }

        [StringLength(20)]
        public string TDL_PACS_TYPE_CODE { get; set; }

        public short? TDL_IS_MAIN_EXAM { get; set; }

        public short? TDL_BILL_OPTION { get; set; }

        [StringLength(500)]
        public string TDL_MATERIAL_GROUP_BHYT { get; set; }

        public short? TDL_IS_SPECIFIC_HEIN_PRICE { get; set; }

        public long? EXPEND_TYPE_ID { get; set; }

        public long? INVOICE_ID { get; set; }

        public short? USE_ORIGINAL_UNIT_FOR_PRES { get; set; }

        public decimal? AMOUNT_TEMP { get; set; }

        public short? IS_FUND_ACCEPTED { get; set; }

        public short? IS_OTHER_SOURCE_PAID { get; set; }

        public short? IS_NOT_PRES { get; set; }

        public short? IS_USER_PACKAGE_PRICE { get; set; }

        public decimal? PACKAGE_PRICE { get; set; }

        public decimal? USER_PRICE { get; set; }

        public decimal? PATIENT_PRICE_BHYT { get; set; }

        public decimal? OTHER_SOURCE_PRICE { get; set; }

        public decimal? VIR_PRICE { get; set; }

        public decimal? VIR_PRICE_NO_ADD_PRICE { get; set; }

        public decimal? VIR_PRICE_NO_EXPEND { get; set; }

        public decimal? VIR_HEIN_PRICE { get; set; }

        public decimal? VIR_PATIENT_PRICE { get; set; }

        public decimal? VIR_PATIENT_PRICE_BHYT { get; set; }

        public decimal? VIR_TOTAL_PRICE { get; set; }

        public decimal? VIR_TOTAL_PRICE_NO_ADD_PRICE { get; set; }

        public decimal? VIR_TOTAL_PRICE_NO_EXPEND { get; set; }

        public decimal? VIR_TOTAL_HEIN_PRICE { get; set; }

        public decimal? VIR_TOTAL_PATIENT_PRICE { get; set; }

        public decimal? VIR_TOTAL_PATIENT_PRICE_BHYT { get; set; }

        public decimal? VIR_TOTAL_PATIENT_PRICE_NO_DC { get; set; }

        public decimal? VIR_TOTAL_PATIENT_PRICE_TEMP { get; set; }

        public long? OTHER_PAY_SOURCE_ID { get; set; }

        public long? TDL_SERVICE_TAX_RATE_TYPE { get; set; }

        public decimal? CONFIG_HEIN_LIMIT_PRICE { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(6)]
        public string PATIENT_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(100)]
        public string PATIENT_TYPE_NAME { get; set; }

        public short? IS_COPAYMENT { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(2)]
        public string SERVICE_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(100)]
        public string SERVICE_TYPE_NAME { get; set; }

        [Key]
        [Column(Order = 23)]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Key]
        [Column(Order = 24)]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        [StringLength(10)]
        public string HEIN_SERVICE_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string HEIN_SERVICE_TYPE_NAME { get; set; }

        public long? HEIN_SERVICE_TYPE_NUM_ORDER { get; set; }

        public decimal? MEDICINE_IMP_PRICE { get; set; }

        public decimal? MEDICINE_IMP_VAT_RATIO { get; set; }

        public long? MEDICINE_IMP_TIME { get; set; }

        public long? MEDICINE_BID_ID { get; set; }

        [StringLength(100)]
        public string MEDICINE_PACKAGE_NUMBER { get; set; }

        [StringLength(500)]
        public string MEDICINE_REGISTER_NUMBER { get; set; }

        [StringLength(4)]
        public string MEDICINE_BID_GROUP_CODE { get; set; }

        [StringLength(4)]
        public string MEDICINE_BID_PACKAGE_CODE { get; set; }

        [StringLength(50)]
        public string MEDICINE_BID_NUM_ORDER { get; set; }

        [StringLength(1000)]
        public string MEDICINE_TYPE_CONCENTRA { get; set; }

        public long? MEDICINE_TYPE_ID { get; set; }

        [StringLength(500)]
        public string REGISTER_NUMBER { get; set; }

        [StringLength(300)]
        public string MEDICINE_PACKING_TYPE_NAME { get; set; }

        public decimal? MATERIAL_IMP_PRICE { get; set; }

        public decimal? MATERIAL_IMP_VAT_RATIO { get; set; }

        public long? MATERIAL_IMP_TIME { get; set; }

        public long? MATERIAL_BID_ID { get; set; }

        [StringLength(100)]
        public string MATERIAL_PACKAGE_NUMBER { get; set; }

        [StringLength(4)]
        public string MATERIAL_BID_GROUP_CODE { get; set; }

        [StringLength(4)]
        public string MATERIAL_BID_PACKAGE_CODE { get; set; }

        [StringLength(50)]
        public string MATERIAL_BID_NUM_ORDER { get; set; }

        [StringLength(1000)]
        public string MATERIAL_TYPE_CONCENTRA { get; set; }

        public long? MATERIAL_TYPE_ID { get; set; }

        [StringLength(300)]
        public string MATERIAL_PACKING_TYPE_NAME { get; set; }
    }
}

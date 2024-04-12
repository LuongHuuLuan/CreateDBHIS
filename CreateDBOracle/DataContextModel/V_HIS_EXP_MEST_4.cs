namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_EXP_MEST_4")]
    public partial class V_HIS_EXP_MEST_4
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
        [StringLength(12)]
        public string EXP_MEST_CODE { get; set; }

        public long EXP_MEST_TYPE_ID { get; set; }

        public long EXP_MEST_STT_ID { get; set; }

        public long MEDI_STOCK_ID { get; set; }

        [StringLength(50)]
        public string REQ_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REQ_USERNAME { get; set; }

        public long REQ_ROOM_ID { get; set; }

        public long REQ_DEPARTMENT_ID { get; set; }

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

        public long? DISPENSE_ID { get; set; }

        [StringLength(8)]
        public string TDL_DISPENSE_CODE { get; set; }

        public long? SUPPLIER_ID { get; set; }

        public short? IS_NOT_TAKEN { get; set; }

        public short? IS_EXPORT_EQUAL_APPROVE { get; set; }

        public short? IS_EXPORT_EQUAL_REQUEST { get; set; }

        public short? IS_HTX { get; set; }

        public long? BILL_ID { get; set; }

        [StringLength(50)]
        public string CASHIER_LOGINNAME { get; set; }

        [StringLength(100)]
        public string CASHIER_USERNAME { get; set; }

        public long? SALE_PATIENT_TYPE_ID { get; set; }

        public decimal? DISCOUNT { get; set; }

        public long? VACCINATION_ID { get; set; }

        [StringLength(50)]
        public string NATIONAL_EXP_MEST_CODE { get; set; }

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

        public short? IS_EXECUTE_KIDNEY_PRES { get; set; }

        public short? IS_REQUEST_BY_PACKAGE { get; set; }

        public long? TDL_PATIENT_TYPE_ID { get; set; }

        [StringLength(19)]
        public string TDL_HEIN_CARD_NUMBER { get; set; }

        public long? CHMS_TYPE_ID { get; set; }

        public short? IS_OLD_BCS { get; set; }

        [StringLength(20)]
        public string EXP_MEST_SUB_CODE { get; set; }

        public short? IS_NOT_IN_WORKING_TIME { get; set; }

        public long? BCS_TYPE_ID { get; set; }

        [StringLength(50)]
        public string LAST_APPROVAL_LOGINNAME { get; set; }

        [StringLength(100)]
        public string LAST_APPROVAL_USERNAME { get; set; }

        public long? LAST_APPROVAL_TIME { get; set; }

        public long? LAST_APPROVAL_DATE { get; set; }

        [StringLength(500)]
        public string TDL_PATIENT_WORK_PLACE { get; set; }

        [StringLength(20)]
        public string TDL_PATIENT_TAX_CODE { get; set; }

        [StringLength(50)]
        public string TDL_PATIENT_ACCOUNT_NUMBER { get; set; }

        public long? SOURCE_MEST_PERIOD_ID { get; set; }

        public long? PRES_GROUP { get; set; }

        [StringLength(12)]
        public string TDL_PATIENT_MOBILE { get; set; }

        [StringLength(12)]
        public string TDL_PATIENT_PHONE { get; set; }

        public decimal? TOTAL_SERVICE_ATTACH_PRICE { get; set; }

        public long? CASHIER_ROOM_ID { get; set; }

        public long? PAY_FORM_ID { get; set; }

        public decimal? TRANSFER_AMOUNT { get; set; }

        [StringLength(4)]
        public string TDL_PATIENT_DISTRICT_CODE { get; set; }

        [StringLength(3)]
        public string TDL_PATIENT_PROVINCE_CODE { get; set; }

        [StringLength(6)]
        public string TDL_PATIENT_COMMUNE_CODE { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_NATIONAL_NAME { get; set; }

        public short? IS_STAR_MARK { get; set; }

        public long? NOT_TAKEN_TIME { get; set; }

        public long? DEBT_ID { get; set; }

        [StringLength(20)]
        public string ERX_PRESCRIPTION_CODE { get; set; }

        public short? IS_SENT_ERX { get; set; }

        public short? IS_CONFIRM { get; set; }

        public long? CONFIRM_TIME { get; set; }

        [StringLength(50)]
        public string CONFIRM_LOGINNAME { get; set; }

        [StringLength(100)]
        public string CONFIRM_USERNAME { get; set; }

        public decimal? VIR_CREATE_MONTH { get; set; }

        public long? PRES_NUMBER { get; set; }

        public short? IS_NOT_TAKEN_FAIL { get; set; }

        [StringLength(4000)]
        public string NOT_TAKEN_DESC { get; set; }

        public short? IS_BEING_APPROVED { get; set; }

        public long? MACHINE_ID { get; set; }

        public long? EXP_MEST_TEST_TYPE_ID { get; set; }

        public long? QC_TYPE_ID { get; set; }

        public short? IS_HOME_PRES { get; set; }

        public short? IS_KIDNEY { get; set; }

        [StringLength(10)]
        public string ICD_CODE { get; set; }

        [StringLength(500)]
        public string ICD_NAME { get; set; }

        [StringLength(500)]
        public string ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string ICD_TEXT { get; set; }

        public short? HAS_NOT_PRES { get; set; }

        [StringLength(100)]
        public string REQ_USER_TITLE { get; set; }

        [StringLength(100)]
        public string TDL_PRES_REQ_USER_TITLE { get; set; }

        public long? SUB_CODE_TYPE { get; set; }

        [StringLength(50)]
        public string EXP_MEST_SUB_CODE_2 { get; set; }

        [StringLength(500)]
        public string RECIPIENT { get; set; }

        [StringLength(500)]
        public string RECEIVING_PLACE { get; set; }

        public long? SPECIAL_MEDICINE_NUM_ORDER { get; set; }

        public long? SPECIAL_MEDICINE_TYPE { get; set; }

        public decimal? VIR_CREATE_YEAR { get; set; }

        [StringLength(180)]
        public string VIR_SPECIAL_MEDICINE_NUM_ORDER { get; set; }

        [StringLength(8)]
        public string VIR_HEIN_CARD_PREFIX { get; set; }

        public long? NUM_ORDER { get; set; }

        [Required]
        [StringLength(2)]
        public string EXP_MEST_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string EXP_MEST_TYPE_NAME { get; set; }

        [Required]
        [StringLength(2)]
        public string EXP_MEST_STT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string EXP_MEST_STT_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string MEDI_STOCK_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string MEDI_STOCK_NAME { get; set; }

        public short? IS_CABINET { get; set; }

        [StringLength(12)]
        public string IMP_MEST_CODE { get; set; }

        [StringLength(100)]
        public string IMP_MEST_STT_NAME { get; set; }

        [StringLength(100)]
        public string IMP_MEDI_STOCK_NAME { get; set; }

        public short? IMP_IS_CABINET { get; set; }

        [StringLength(20)]
        public string IMP_MEDI_STOCK_CODE { get; set; }
    }
}

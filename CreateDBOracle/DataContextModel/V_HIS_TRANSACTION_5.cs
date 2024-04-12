namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_TRANSACTION_5")]
    public partial class V_HIS_TRANSACTION_5
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
        public string TRANSACTION_CODE { get; set; }

        public long TRANSACTION_TYPE_ID { get; set; }

        public long TRANSACTION_TIME { get; set; }

        public long TRANSACTION_DATE { get; set; }

        public decimal AMOUNT { get; set; }

        public long NUM_ORDER { get; set; }

        public long ACCOUNT_BOOK_ID { get; set; }

        public long PAY_FORM_ID { get; set; }

        public long? REPAY_REASON_ID { get; set; }

        public long CASHIER_ROOM_ID { get; set; }

        [StringLength(50)]
        public string CASHIER_LOGINNAME { get; set; }

        [StringLength(100)]
        public string CASHIER_USERNAME { get; set; }

        public decimal? KC_AMOUNT { get; set; }

        public decimal? TDL_BILL_FUND_AMOUNT { get; set; }

        public long? TDL_SERE_SERV_DEPOSIT_COUNT { get; set; }

        public long? TDL_SESE_DEPO_REPAY_COUNT { get; set; }

        public decimal? EXEMPTION { get; set; }

        [StringLength(2000)]
        public string EXEMPTION_REASON { get; set; }

        [StringLength(200)]
        public string SELLER_NAME { get; set; }

        [StringLength(500)]
        public string SELLER_ADDRESS { get; set; }

        [StringLength(50)]
        public string SELLER_ACCOUNT_NUMBER { get; set; }

        [StringLength(20)]
        public string SELLER_TAX_CODE { get; set; }

        [StringLength(20)]
        public string SELLER_PHONE { get; set; }

        [StringLength(200)]
        public string BUYER_NAME { get; set; }

        [StringLength(500)]
        public string BUYER_ADDRESS { get; set; }

        [StringLength(500)]
        public string BUYER_ACCOUNT_NUMBER { get; set; }

        [StringLength(20)]
        public string BUYER_TAX_CODE { get; set; }

        [StringLength(1000)]
        public string FILE_URL { get; set; }

        [StringLength(50)]
        public string FILE_NAME { get; set; }

        public long? BILL_TYPE_ID { get; set; }

        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        public short? IS_CANCEL { get; set; }

        [StringLength(2000)]
        public string CANCEL_REASON { get; set; }

        public long? CANCEL_TIME { get; set; }

        [StringLength(50)]
        public string CANCEL_LOGINNAME { get; set; }

        [StringLength(100)]
        public string CANCEL_USERNAME { get; set; }

        public long? CASHOUT_ID { get; set; }

        [StringLength(12)]
        public string TIG_TRANSACTION_CODE { get; set; }

        public long? TIG_TRANSACTION_TIME { get; set; }

        [StringLength(12)]
        public string TIG_VOID_CODE { get; set; }

        [StringLength(100)]
        public string INVOICE_SYS { get; set; }

        [StringLength(100)]
        public string INVOICE_CODE { get; set; }

        public long? TREATMENT_ID { get; set; }

        public long? TREATMENT_TYPE_ID { get; set; }

        [StringLength(12)]
        public string TDL_TREATMENT_CODE { get; set; }

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

        [StringLength(100)]
        public string TDL_PATIENT_CAREER_NAME { get; set; }

        [StringLength(500)]
        public string TDL_PATIENT_WORK_PLACE { get; set; }

        [StringLength(500)]
        public string TDL_PATIENT_WORK_PLACE_NAME { get; set; }

        [StringLength(4)]
        public string TDL_PATIENT_DISTRICT_CODE { get; set; }

        [StringLength(3)]
        public string TDL_PATIENT_PROVINCE_CODE { get; set; }

        [StringLength(6)]
        public string TDL_PATIENT_COMMUNE_CODE { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_MILITARY_RANK_NAME { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_NATIONAL_NAME { get; set; }

        [StringLength(50)]
        public string NATIONAL_TRANSACTION_CODE { get; set; }

        [StringLength(500)]
        public string BUYER_ORGANIZATION { get; set; }

        public long? SALE_TYPE_ID { get; set; }

        public decimal? TREATMENT_TOTAL_PRICE { get; set; }

        public decimal? TREATMENT_MEDICINE_PRICE { get; set; }

        public decimal? TREATMENT_MATERIAL_PRICE { get; set; }

        public decimal? TREATMENT_SUBCLINICAL_PRICE { get; set; }

        public decimal? TREATMENT_SURG_PRICE { get; set; }

        public decimal? TREATMENT_EXAM_PRICE { get; set; }

        public decimal? TREATMENT_BED_PRICE { get; set; }

        public decimal? TREATMENT_DEPOSIT_AMOUNT { get; set; }

        public decimal? TREATMENT_REPAY_AMOUNT { get; set; }

        public decimal? TREATMENT_HEIN_PRICE { get; set; }

        public decimal? TREATMENT_PATIENT_PRICE { get; set; }

        public decimal? TREATMENT_BILL_AMOUNT { get; set; }

        public decimal? TREATMENT_BLOOD_PRICE { get; set; }

        [StringLength(50)]
        public string SESSION_CODE { get; set; }

        [StringLength(2000)]
        public string TRANSACTION_INFO { get; set; }

        public long? CANCEL_CASHIER_ROOM_ID { get; set; }

        [StringLength(20)]
        public string BUYER_PHONE { get; set; }

        public short? IS_NOT_IN_WORKING_TIME { get; set; }

        public decimal? TDL_PREVIOUS_AMOUNT { get; set; }

        public long? PREVIOUS_ID { get; set; }

        public decimal? TDL_BILL_AMOUNT { get; set; }

        public decimal? TDL_PREVIOUS_BILL_AMOUNT { get; set; }

        public long? BILL_ID { get; set; }

        public decimal? SERE_SERV_AMOUNT { get; set; }

        public decimal? TRANSFER_AMOUNT { get; set; }

        public long? WORKING_SHIFT_ID { get; set; }

        public long? DEBT_BILL_ID { get; set; }

        public short? IS_DEBT_COLLECTION { get; set; }

        [StringLength(100)]
        public string EINVOICE_NUM_ORDER { get; set; }

        public long? TIG_VOID_TIME { get; set; }

        public short? IS_DIRECTLY_BILLING { get; set; }

        public long? DEBT_TYPE { get; set; }

        public decimal? TREATMENT_DEBT_AMOUNT { get; set; }

        public decimal? TREATMENT_TRANSFER_AMOUNT { get; set; }

        public decimal? SWIPE_AMOUNT { get; set; }

        [StringLength(4000)]
        public string ALL_TRANS_CODES_IN_INVOICE { get; set; }

        public long? EINVOICE_TIME { get; set; }

        public long? TRANS_REQ_ID { get; set; }

        public long? BANK_ID { get; set; }

        public long? CANCEL_REASON_ID { get; set; }

        public decimal? ROUNDED_TOTAL_PRICE { get; set; }

        public decimal? ROUND_PRICE_BASE { get; set; }

        [Required]
        [StringLength(2)]
        public string PAY_FORM_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string PAY_FORM_NAME { get; set; }

        [Required]
        [StringLength(6)]
        public string ACCOUNT_BOOK_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string ACCOUNT_BOOK_NAME { get; set; }

        [Required]
        [StringLength(10)]
        public string CASHIER_ROOM_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string CASHIER_ROOM_NAME { get; set; }

        [StringLength(10)]
        public string CANCEL_CASHIER_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string CANCEL_CASHIER_ROOM_NAME { get; set; }

        [StringLength(8)]
        public string DEPOSIT_REQ_CODE { get; set; }
    }
}

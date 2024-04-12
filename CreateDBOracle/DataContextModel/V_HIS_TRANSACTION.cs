namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_TRANSACTION")]
    public partial class V_HIS_TRANSACTION
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
        public string TRANSACTION_CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TRANSACTION_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TRANSACTION_TIME { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TRANSACTION_DATE { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal AMOUNT { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NUM_ORDER { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ACCOUNT_BOOK_ID { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PAY_FORM_ID { get; set; }

        public long? REPAY_REASON_ID { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

        [StringLength(20)]
        public string POS_INVOICE { get; set; }

        [StringLength(20)]
        public string POS_PAN { get; set; }

        [StringLength(100)]
        public string POS_CARD_HOLDER { get; set; }

        [StringLength(4000)]
        public string POS_RESULT_JSON { get; set; }

        public short? BUYER_TYPE { get; set; }

        public short? IS_CANCEL_EINVOICE { get; set; }

        public long? EINVOICE_CANCEL_TIME { get; set; }

        public long? BUYER_WORK_PLACE_ID { get; set; }

        [StringLength(200)]
        public string EINVOICE_URL { get; set; }

        public long? TDL_PATIENT_CLASSIFY_ID { get; set; }

        [StringLength(1000)]
        public string REPLACE_REASON { get; set; }

        public long? REPLACE_TIME { get; set; }

        public long? ORIGINAL_TRANSACTION_ID { get; set; }

        [StringLength(100)]
        public string TDL_ORIGINAL_EI_NUM_ORDER { get; set; }

        public long? TDL_ORIGINAL_EI_TIME { get; set; }

        [StringLength(100)]
        public string TDL_ORIGINAL_EI_CODE { get; set; }

        [StringLength(100)]
        public string EINVOICE_LOGINNAME { get; set; }

        public long? CARD_ID { get; set; }

        [StringLength(50)]
        public string TDL_CARD_CODE { get; set; }

        [StringLength(20)]
        public string TDL_BANK_CARD_CODE { get; set; }

        public short? CANCEL_REQ_STT { get; set; }

        [StringLength(1000)]
        public string CANCEL_REQ_REASON { get; set; }

        public long? CANCEL_REQ_ROOM_ID { get; set; }

        [StringLength(50)]
        public string CANCEL_REQ_LOGINNAME { get; set; }

        [StringLength(100)]
        public string CANCEL_REQ_USERNAME { get; set; }

        [StringLength(50)]
        public string CANCEL_REQ_REJECT_LOGINNAME { get; set; }

        [StringLength(100)]
        public string CANCEL_REQ_REJECT_USERNAME { get; set; }

        [StringLength(1000)]
        public string CANCEL_REQ_REJECT_REASON { get; set; }

        public long? CANCEL_REQ_REJECT_TIME { get; set; }

        [StringLength(12)]
        public string BANK_TRANSACTION_CODE { get; set; }

        public long? BANK_TRANSACTION_TIME { get; set; }

        public long? UNLOCK_TIME { get; set; }

        public long? BEFORE_UL_CASHIER_ROOM_ID { get; set; }

        [StringLength(50)]
        public string BEFORE_UL_CASHIER_LOGINNAME { get; set; }

        [StringLength(100)]
        public string BEFORE_UL_CASHIER_USERNAME { get; set; }

        [StringLength(12)]
        public string TREATMENT_CODE { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(2)]
        public string TRANSACTION_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(100)]
        public string TRANSACTION_TYPE_NAME { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(2)]
        public string PAY_FORM_CODE { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(100)]
        public string PAY_FORM_NAME { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(6)]
        public string ACCOUNT_BOOK_CODE { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(100)]
        public string ACCOUNT_BOOK_NAME { get; set; }

        [StringLength(8)]
        public string SYMBOL_CODE { get; set; }

        [StringLength(11)]
        public string TEMPLATE_CODE { get; set; }

        public short? IS_NOT_GEN_TRANSACTION_ORDER { get; set; }

        public long? EINVOICE_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(10)]
        public string CASHIER_ROOM_CODE { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(100)]
        public string CASHIER_ROOM_NAME { get; set; }

        [StringLength(2)]
        public string TREATMENT_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string TREATMENT_TYPE_NAME { get; set; }

        [StringLength(2)]
        public string REPAY_REASON_CODE { get; set; }

        [StringLength(100)]
        public string REPAY_REASON_NAME { get; set; }

        [StringLength(10)]
        public string CANCEL_CASHIER_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string CANCEL_CASHIER_ROOM_NAME { get; set; }

        [StringLength(10)]
        public string BANK_CODE { get; set; }

        [StringLength(100)]
        public string BANK_NAME { get; set; }

        [StringLength(10)]
        public string TDL_PATIENT_CLASSIFY_CODE { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_CLASSIFY_NAME { get; set; }

        [StringLength(20)]
        public string CANCEL_REQ_DEPARTMENT_CODE { get; set; }

        [StringLength(100)]
        public string CANCEL_REQ_DEPARTMENT_NAME { get; set; }

        [StringLength(20)]
        public string CANCEL_REQ_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string CANCEL_REQ_ROOM_NAME { get; set; }

        [StringLength(12)]
        public string TRANS_REQ_CODE { get; set; }
    }
}

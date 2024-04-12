namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SERE_SERV")]
    public partial class HIS_SERE_SERV
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_SERE_SERV()
        {
            HIS_EXP_MEST_BLOOD = new HashSet<HIS_EXP_MEST_BLOOD>();
            HIS_EXP_MEST_MATERIAL = new HashSet<HIS_EXP_MEST_MATERIAL>();
            HIS_EXP_MEST_MEDICINE = new HashSet<HIS_EXP_MEST_MEDICINE>();
            HIS_SERE_SERV_BILL = new HashSet<HIS_SERE_SERV_BILL>();
            HIS_SERE_SERV_DEBT = new HashSet<HIS_SERE_SERV_DEBT>();
            HIS_SERE_SERV_DEPOSIT = new HashSet<HIS_SERE_SERV_DEPOSIT>();
            HIS_SERE_SERV_FILE = new HashSet<HIS_SERE_SERV_FILE>();
            HIS_SERE_SERV1 = new HashSet<HIS_SERE_SERV>();
            HIS_SERE_SERV_MATY = new HashSet<HIS_SERE_SERV_MATY>();
            HIS_SERE_SERV_PTTT = new HashSet<HIS_SERE_SERV_PTTT>();
            HIS_SERE_SERV_REHA = new HashSet<HIS_SERE_SERV_REHA>();
            HIS_SERE_SERV_SUIN = new HashSet<HIS_SERE_SERV_SUIN>();
            HIS_SERE_SERV_TEIN = new HashSet<HIS_SERE_SERV_TEIN>();
            HIS_SERVICE_CHANGE_REQ = new HashSet<HIS_SERVICE_CHANGE_REQ>();
            HIS_SERVICE_CHANGE_REQ1 = new HashSet<HIS_SERVICE_CHANGE_REQ>();
            HIS_SESE_TRANS_REQ = new HashSet<HIS_SESE_TRANS_REQ>();
        }

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

        public long SERVICE_ID { get; set; }

        public long? SERVICE_REQ_ID { get; set; }

        public long PATIENT_TYPE_ID { get; set; }

        public long? PRIMARY_PATIENT_TYPE_ID { get; set; }

        public decimal? PRIMARY_PRICE { get; set; }

        public decimal? LIMIT_PRICE { get; set; }

        public long? PARENT_ID { get; set; }

        public long? HEIN_APPROVAL_ID { get; set; }

        [StringLength(2000)]
        public string JSON_PATIENT_TYPE_ALTER { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal PRICE { get; set; }

        public decimal ORIGINAL_PRICE { get; set; }

        public decimal? HEIN_PRICE { get; set; }

        public decimal? HEIN_RATIO { get; set; }

        public decimal? HEIN_LIMIT_PRICE { get; set; }

        public decimal? HEIN_LIMIT_RATIO { get; set; }

        public decimal? HEIN_NORMAL_PRICE { get; set; }

        public decimal? ADD_PRICE { get; set; }

        public decimal? OVERTIME_PRICE { get; set; }

        public decimal? DISCOUNT { get; set; }

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

        public long TDL_INTRUCTION_TIME { get; set; }

        public long TDL_INTRUCTION_DATE { get; set; }

        public long? TDL_PATIENT_ID { get; set; }

        public long? TDL_TREATMENT_ID { get; set; }

        [StringLength(12)]
        public string TDL_TREATMENT_CODE { get; set; }

        [Required]
        [StringLength(25)]
        public string TDL_SERVICE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string TDL_SERVICE_NAME { get; set; }

        [StringLength(100)]
        public string TDL_HEIN_SERVICE_BHYT_CODE { get; set; }

        [StringLength(500)]
        public string TDL_HEIN_SERVICE_BHYT_NAME { get; set; }

        [StringLength(20)]
        public string TDL_HEIN_ORDER { get; set; }

        public long TDL_SERVICE_TYPE_ID { get; set; }

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

        public long TDL_REQUEST_ROOM_ID { get; set; }

        public long TDL_REQUEST_DEPARTMENT_ID { get; set; }

        [StringLength(50)]
        public string TDL_REQUEST_LOGINNAME { get; set; }

        [StringLength(100)]
        public string TDL_REQUEST_USERNAME { get; set; }

        public long TDL_EXECUTE_ROOM_ID { get; set; }

        public long TDL_EXECUTE_DEPARTMENT_ID { get; set; }

        public long TDL_EXECUTE_BRANCH_ID { get; set; }

        public long? TDL_EXECUTE_GROUP_ID { get; set; }

        [StringLength(3)]
        public string TDL_SPECIALITY_CODE { get; set; }

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

        [StringLength(2000)]
        public string TDL_SERVICE_DESCRIPTION { get; set; }

        public short? TDL_IS_OUT_OF_DRG { get; set; }

        public long? SERVICE_CONDITION_ID { get; set; }

        public short? IS_ACCEPTING_NO_EXECUTE { get; set; }

        [StringLength(100)]
        public string TDL_REQUEST_USER_TITLE { get; set; }

        [StringLength(50)]
        public string DISCOUNT_LOGINNAME { get; set; }

        [StringLength(100)]
        public string DISCOUNT_USERNAME { get; set; }

        [StringLength(500)]
        public string NO_EXECUTE_REASON { get; set; }

        public decimal? ACTUAL_PRICE { get; set; }

        public short? IS_TEMP_BED_PROCESSED { get; set; }

        public short? IS_NOT_USE_BHYT { get; set; }

        public long? TDL_CARER_CARD_BORROW_ID { get; set; }

        public long? TDL_RATION_TIME_ID { get; set; }

        public short? IS_CONFIRM_NO_EXCUTE { get; set; }

        [StringLength(500)]
        public string CONFIRM_NO_EXCUTE_REASON { get; set; }

        public short? TDL_IS_VACCINE { get; set; }

        public virtual HIS_EKIP HIS_EKIP { get; set; }

        public virtual HIS_EQUIPMENT_SET HIS_EQUIPMENT_SET { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_BLOOD> HIS_EXP_MEST_BLOOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_MATERIAL> HIS_EXP_MEST_MATERIAL { get; set; }

        public virtual HIS_EXP_MEST_MATERIAL HIS_EXP_MEST_MATERIAL1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_MEDICINE> HIS_EXP_MEST_MEDICINE { get; set; }

        public virtual HIS_EXP_MEST_MEDICINE HIS_EXP_MEST_MEDICINE1 { get; set; }

        public virtual HIS_HEIN_APPROVAL HIS_HEIN_APPROVAL { get; set; }

        public virtual HIS_OTHER_PAY_SOURCE HIS_OTHER_PAY_SOURCE { get; set; }

        public virtual HIS_PACKAGE HIS_PACKAGE { get; set; }

        public virtual HIS_PATIENT_TYPE HIS_PATIENT_TYPE { get; set; }

        public virtual HIS_PATIENT_TYPE HIS_PATIENT_TYPE1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_BILL> HIS_SERE_SERV_BILL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_DEBT> HIS_SERE_SERV_DEBT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_DEPOSIT> HIS_SERE_SERV_DEPOSIT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_FILE> HIS_SERE_SERV_FILE { get; set; }

        public virtual HIS_SERVICE HIS_SERVICE { get; set; }

        public virtual HIS_SERVICE_CONDITION HIS_SERVICE_CONDITION { get; set; }

        public virtual HIS_SERVICE_REQ HIS_SERVICE_REQ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV> HIS_SERE_SERV1 { get; set; }

        public virtual HIS_SERE_SERV HIS_SERE_SERV2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_MATY> HIS_SERE_SERV_MATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_PTTT> HIS_SERE_SERV_PTTT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_REHA> HIS_SERE_SERV_REHA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_SUIN> HIS_SERE_SERV_SUIN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_TEIN> HIS_SERE_SERV_TEIN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_CHANGE_REQ> HIS_SERVICE_CHANGE_REQ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_CHANGE_REQ> HIS_SERVICE_CHANGE_REQ1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SESE_TRANS_REQ> HIS_SESE_TRANS_REQ { get; set; }
    }
}

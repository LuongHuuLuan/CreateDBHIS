namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_MEDICINE_TYPE")]
    public partial class HIS_MEDICINE_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_MEDICINE_TYPE()
        {
            HIS_ADR_MEDICINE_TYPE = new HashSet<HIS_ADR_MEDICINE_TYPE>();
            HIS_ALLERGENIC = new HashSet<HIS_ALLERGENIC>();
            HIS_ANTICIPATE_METY = new HashSet<HIS_ANTICIPATE_METY>();
            HIS_BID_MEDICINE_TYPE = new HashSet<HIS_BID_MEDICINE_TYPE>();
            HIS_DEBT_GOODS = new HashSet<HIS_DEBT_GOODS>();
            HIS_EMTE_MEDICINE_TYPE = new HashSet<HIS_EMTE_MEDICINE_TYPE>();
            HIS_EXP_MEST_METY_REQ = new HashSet<HIS_EXP_MEST_METY_REQ>();
            HIS_MEDI_CONTRACT_METY = new HashSet<HIS_MEDI_CONTRACT_METY>();
            HIS_MEDI_STOCK_METY = new HashSet<HIS_MEDI_STOCK_METY>();
            HIS_MEDICINE = new HashSet<HIS_MEDICINE>();
            HIS_MEDICINE_INTERACTIVE = new HashSet<HIS_MEDICINE_INTERACTIVE>();
            HIS_MEDICINE_INTERACTIVE1 = new HashSet<HIS_MEDICINE_INTERACTIVE>();
            HIS_MEDICINE_TYPE_ACIN = new HashSet<HIS_MEDICINE_TYPE_ACIN>();
            HIS_MEDICINE_TYPE1 = new HashSet<HIS_MEDICINE_TYPE>();
            HIS_MEDICINE_TYPE_ROOM = new HashSet<HIS_MEDICINE_TYPE_ROOM>();
            HIS_MEDICINE_TYPE_TUT = new HashSet<HIS_MEDICINE_TYPE_TUT>();
            HIS_MEST_METY_DEPA = new HashSet<HIS_MEST_METY_DEPA>();
            HIS_MEST_METY_UNIT = new HashSet<HIS_MEST_METY_UNIT>();
            HIS_MEST_PERIOD_METY = new HashSet<HIS_MEST_PERIOD_METY>();
            HIS_METY_METY = new HashSet<HIS_METY_METY>();
            HIS_METY_PRODUCT = new HashSet<HIS_METY_PRODUCT>();
            HIS_MIXED_MEDICINE = new HashSet<HIS_MIXED_MEDICINE>();
            HIS_PREPARE_METY = new HashSet<HIS_PREPARE_METY>();
            HIS_SERVICE_METY = new HashSet<HIS_SERVICE_METY>();
            HIS_SERVICE_REQ_METY = new HashSet<HIS_SERVICE_REQ_METY>();
            HIS_TREATMENT = new HashSet<HIS_TREATMENT>();
            HIS_VITAMIN_A = new HashSet<HIS_VITAMIN_A>();
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

        [Required]
        [StringLength(25)]
        public string MEDICINE_TYPE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string MEDICINE_TYPE_NAME { get; set; }

        public long SERVICE_ID { get; set; }

        public long? PARENT_ID { get; set; }

        public short? IS_LEAF { get; set; }

        public long? NUM_ORDER { get; set; }

        [StringLength(1000)]
        public string CONCENTRA { get; set; }

        [StringLength(500)]
        public string ACTIVE_INGR_BHYT_CODE { get; set; }

        [StringLength(1000)]
        public string ACTIVE_INGR_BHYT_NAME { get; set; }

        [StringLength(500)]
        public string REGISTER_NUMBER { get; set; }

        public long? PACKING_TYPE_ID__DELETE { get; set; }

        public long? MANUFACTURER_ID { get; set; }

        public long? MEDICINE_USE_FORM_ID { get; set; }

        public long? MEDICINE_LINE_ID { get; set; }

        public long? MEDICINE_GROUP_ID { get; set; }

        public long TDL_SERVICE_UNIT_ID { get; set; }

        public long? TDL_GENDER_ID { get; set; }

        [StringLength(1000)]
        public string NATIONAL_NAME { get; set; }

        [StringLength(2000)]
        public string TUTORIAL { get; set; }

        public decimal? IMP_PRICE { get; set; }

        public decimal? IMP_VAT_RATIO { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        public decimal? ALERT_MAX_IN_TREATMENT { get; set; }

        public long? ALERT_EXPIRED_DATE { get; set; }

        public decimal? ALERT_MIN_IN_STOCK { get; set; }

        public decimal? ALERT_MAX_IN_PRESCRIPTION { get; set; }

        public short? IS_STOP_IMP { get; set; }

        public short? IS_STAR_MARK { get; set; }

        public short? IS_ALLOW_ODD { get; set; }

        public short? IS_ALLOW_EXPORT_ODD { get; set; }

        public short? IS_FUNCTIONAL_FOOD { get; set; }

        public short? IS_REQUIRE_HSD { get; set; }

        public short? IS_SALE_EQUAL_IMP_PRICE { get; set; }

        public short? IS_BUSINESS { get; set; }

        public short? IS_RAW_MEDICINE { get; set; }

        public short? IS_AUTO_EXPEND { get; set; }

        public short? IS_VITAMIN_A { get; set; }

        public short? IS_VACCINE { get; set; }

        public short? IS_TCMR { get; set; }

        public short? IS_MUST_PREPARE { get; set; }

        public decimal? USE_ON_DAY { get; set; }

        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        public long? MEMA_GROUP_ID { get; set; }

        [StringLength(50)]
        public string BYT_NUM_ORDER { get; set; }

        [StringLength(20)]
        public string TCY_NUM_ORDER { get; set; }

        [StringLength(200)]
        public string MEDICINE_TYPE_PROPRIETARY_NAME { get; set; }

        [StringLength(300)]
        public string PACKING_TYPE_NAME { get; set; }

        public long? RANK { get; set; }

        [StringLength(30)]
        public string MEDICINE_NATIONAL_CODE { get; set; }

        public short? IS_KIDNEY { get; set; }

        public short? IS_CHEMICAL_SUBSTANCE { get; set; }

        public decimal? LAST_EXP_PRICE { get; set; }

        public decimal? LAST_EXP_VAT_RATIO { get; set; }

        [StringLength(4000)]
        public string CONTRAINDICATION { get; set; }

        public decimal? LAST_IMP_PRICE { get; set; }

        public decimal? LAST_IMP_VAT_RATIO { get; set; }

        [StringLength(500)]
        public string ATC_CODES { get; set; }

        public long? LAST_EXPIRED_DATE { get; set; }

        [StringLength(20)]
        public string RECORDING_TRANSACTION { get; set; }

        public short? IS_TREATMENT_DAY_COUNT { get; set; }

        public short? ALLOW_MISSING_PKG_INFO { get; set; }

        public short? IS_BLOCK_MAX_IN_PRESCRIPTION { get; set; }

        public short? IS_OXYGEN { get; set; }

        public short? IS_SPLIT_COMPENSATION { get; set; }

        public long? STORAGE_CONDITION_ID { get; set; }

        [StringLength(500)]
        public string CONTRAINDICATION_IDS { get; set; }

        public short? IS_OUT_HOSPITAL { get; set; }

        public long? IMP_UNIT_ID { get; set; }

        public decimal? IMP_UNIT_CONVERT_RATIO { get; set; }

        [StringLength(500)]
        public string SCIENTIFIC_NAME { get; set; }

        [StringLength(1000)]
        public string PREPROCESSING { get; set; }

        [StringLength(1000)]
        public string PROCESSING { get; set; }

        [StringLength(500)]
        public string USED_PART { get; set; }

        [StringLength(2000)]
        public string DOSAGE_FORM { get; set; }

        [StringLength(500)]
        public string DISTRIBUTED_AMOUNT { get; set; }

        public short? IS_NOT_TREATMENT_DAY_COUNT { get; set; }

        public short? IS_ANAESTHESIA { get; set; }

        public long? VACCINE_TYPE_ID { get; set; }

        [StringLength(1000)]
        public string QUALITY_STANDARDS { get; set; }

        public short? SOURCE_MEDICINE { get; set; }

        public short? IS_DRUG_STORE { get; set; }

        [StringLength(4000)]
        public string LOCKING_REASON { get; set; }

        [StringLength(255)]
        public string PREPROCESSING_CODE { get; set; }

        [StringLength(255)]
        public string PROCESSING_CODE { get; set; }

        [StringLength(50)]
        public string NUM_ORDER_CIRCULARS20 { get; set; }

        public short? IS_BLOCK_MAX_IN_DAY { get; set; }

        public decimal? ALERT_MAX_IN_DAY { get; set; }

        public long? HTU_ID { get; set; }

        [StringLength(2000)]
        public string ODD_WARNING_CONTENT { get; set; }

        public short? IS_ORIGINAL_BRAND_NAME { get; set; }

        public short? IS_GENERIC { get; set; }

        public short? IS_BIOLOGIC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ADR_MEDICINE_TYPE> HIS_ADR_MEDICINE_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ALLERGENIC> HIS_ALLERGENIC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ANTICIPATE_METY> HIS_ANTICIPATE_METY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BID_MEDICINE_TYPE> HIS_BID_MEDICINE_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEBT_GOODS> HIS_DEBT_GOODS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EMTE_MEDICINE_TYPE> HIS_EMTE_MEDICINE_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_METY_REQ> HIS_EXP_MEST_METY_REQ { get; set; }

        public virtual HIS_HTU HIS_HTU { get; set; }

        public virtual HIS_MANUFACTURER HIS_MANUFACTURER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_CONTRACT_METY> HIS_MEDI_CONTRACT_METY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_STOCK_METY> HIS_MEDI_STOCK_METY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICINE> HIS_MEDICINE { get; set; }

        public virtual HIS_MEDICINE_GROUP HIS_MEDICINE_GROUP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICINE_INTERACTIVE> HIS_MEDICINE_INTERACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICINE_INTERACTIVE> HIS_MEDICINE_INTERACTIVE1 { get; set; }

        public virtual HIS_MEDICINE_LINE HIS_MEDICINE_LINE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICINE_TYPE_ACIN> HIS_MEDICINE_TYPE_ACIN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICINE_TYPE> HIS_MEDICINE_TYPE1 { get; set; }

        public virtual HIS_MEDICINE_TYPE HIS_MEDICINE_TYPE2 { get; set; }

        public virtual HIS_STORAGE_CONDITION HIS_STORAGE_CONDITION { get; set; }

        public virtual HIS_SERVICE_UNIT HIS_SERVICE_UNIT { get; set; }

        public virtual HIS_VACCINE_TYPE HIS_VACCINE_TYPE { get; set; }

        public virtual HIS_SERVICE HIS_SERVICE { get; set; }

        public virtual HIS_PACKING_TYPE HIS_PACKING_TYPE { get; set; }

        public virtual HIS_MEDICINE_USE_FORM HIS_MEDICINE_USE_FORM { get; set; }

        public virtual HIS_MEMA_GROUP HIS_MEMA_GROUP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICINE_TYPE_ROOM> HIS_MEDICINE_TYPE_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICINE_TYPE_TUT> HIS_MEDICINE_TYPE_TUT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_METY_DEPA> HIS_MEST_METY_DEPA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_METY_UNIT> HIS_MEST_METY_UNIT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_PERIOD_METY> HIS_MEST_PERIOD_METY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_METY_METY> HIS_METY_METY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_METY_PRODUCT> HIS_METY_PRODUCT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MIXED_MEDICINE> HIS_MIXED_MEDICINE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PREPARE_METY> HIS_PREPARE_METY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_METY> HIS_SERVICE_METY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_REQ_METY> HIS_SERVICE_REQ_METY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TREATMENT> HIS_TREATMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VITAMIN_A> HIS_VITAMIN_A { get; set; }
    }
}

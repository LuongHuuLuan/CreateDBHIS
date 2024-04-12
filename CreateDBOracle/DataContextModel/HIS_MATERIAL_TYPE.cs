namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_MATERIAL_TYPE")]
    public partial class HIS_MATERIAL_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_MATERIAL_TYPE()
        {
            HIS_ANTICIPATE_MATY = new HashSet<HIS_ANTICIPATE_MATY>();
            HIS_BID_MATERIAL_TYPE = new HashSet<HIS_BID_MATERIAL_TYPE>();
            HIS_DEBT_GOODS = new HashSet<HIS_DEBT_GOODS>();
            HIS_EMTE_MATERIAL_TYPE = new HashSet<HIS_EMTE_MATERIAL_TYPE>();
            HIS_EQUIPMENT_SET_MATY = new HashSet<HIS_EQUIPMENT_SET_MATY>();
            HIS_EXP_MEST_MATY_REQ = new HashSet<HIS_EXP_MEST_MATY_REQ>();
            HIS_MACHINE_SERV_MATY = new HashSet<HIS_MACHINE_SERV_MATY>();
            HIS_MATERIAL = new HashSet<HIS_MATERIAL>();
            HIS_MATERIAL_TYPE1 = new HashSet<HIS_MATERIAL_TYPE>();
            HIS_MATY_MATY = new HashSet<HIS_MATY_MATY>();
            HIS_MATY_MATY1 = new HashSet<HIS_MATY_MATY>();
            HIS_MEDI_CONTRACT_MATY = new HashSet<HIS_MEDI_CONTRACT_MATY>();
            HIS_MEDI_STOCK_MATY = new HashSet<HIS_MEDI_STOCK_MATY>();
            HIS_MEST_MATY_DEPA = new HashSet<HIS_MEST_MATY_DEPA>();
            HIS_MEST_PERIOD_MATY = new HashSet<HIS_MEST_PERIOD_MATY>();
            HIS_METY_MATY = new HashSet<HIS_METY_MATY>();
            HIS_QC_NORMATION = new HashSet<HIS_QC_NORMATION>();
            HIS_SERE_SERV_MATY = new HashSet<HIS_SERE_SERV_MATY>();
            HIS_SERVICE_MATY = new HashSet<HIS_SERVICE_MATY>();
            HIS_SERVICE_REQ_MATY = new HashSet<HIS_SERVICE_REQ_MATY>();
            HIS_TEST_INDEX = new HashSet<HIS_TEST_INDEX>();
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
        public string MATERIAL_TYPE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string MATERIAL_TYPE_NAME { get; set; }

        public long SERVICE_ID { get; set; }

        public long? PARENT_ID { get; set; }

        public short? IS_LEAF { get; set; }

        public long? NUM_ORDER { get; set; }

        [StringLength(1000)]
        public string CONCENTRA { get; set; }

        public long? PACKING_TYPE_ID__DELETE { get; set; }

        public long? MANUFACTURER_ID { get; set; }

        public long TDL_SERVICE_UNIT_ID { get; set; }

        public long? TDL_GENDER_ID { get; set; }

        [StringLength(100)]
        public string NATIONAL_NAME { get; set; }

        public decimal? IMP_PRICE { get; set; }

        public decimal? IMP_VAT_RATIO { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        public long? ALERT_EXPIRED_DATE { get; set; }

        public decimal? ALERT_MIN_IN_STOCK { get; set; }

        public decimal? ALERT_MAX_IN_PRESCRIPTION { get; set; }

        public short? IS_CHEMICAL_SUBSTANCE { get; set; }

        public short? IS_AUTO_EXPEND { get; set; }

        public short? IS_STENT { get; set; }

        public short? IS_IN_KTC_FEE { get; set; }

        public short? IS_ALLOW_ODD { get; set; }

        public short? IS_ALLOW_EXPORT_ODD { get; set; }

        public short? IS_STOP_IMP { get; set; }

        public short? IS_REQUIRE_HSD { get; set; }

        public short? IS_SALE_EQUAL_IMP_PRICE { get; set; }

        public short? IS_BUSINESS { get; set; }

        public short? IS_RAW_MATERIAL { get; set; }

        public short? IS_MUST_PREPARE { get; set; }

        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        public long? MEMA_GROUP_ID { get; set; }

        [StringLength(300)]
        public string PACKING_TYPE_NAME { get; set; }

        public short? IS_REUSABLE { get; set; }

        public long? MAX_REUSE_COUNT { get; set; }

        [StringLength(500)]
        public string MATERIAL_GROUP_BHYT { get; set; }

        public long? MATERIAL_TYPE_MAP_ID { get; set; }

        public decimal? LAST_EXP_PRICE { get; set; }

        public decimal? LAST_EXP_VAT_RATIO { get; set; }

        public decimal? LAST_IMP_PRICE { get; set; }

        public decimal? LAST_IMP_VAT_RATIO { get; set; }

        public long? FILM_SIZE_ID { get; set; }

        public short? IS_FILM { get; set; }

        public long? LAST_EXPIRED_DATE { get; set; }

        [StringLength(20)]
        public string RECORDING_TRANSACTION { get; set; }

        [StringLength(500)]
        public string REGISTER_NUMBER { get; set; }

        public short? IS_CONSUMABLE { get; set; }

        public short? IS_OUT_HOSPITAL { get; set; }

        public long? IMP_UNIT_ID { get; set; }

        public decimal? IMP_UNIT_CONVERT_RATIO { get; set; }

        public short? IS_DRUG_STORE { get; set; }

        public short? IS_NOT_SHOW_TRACKING { get; set; }

        [StringLength(4000)]
        public string LOCKING_REASON { get; set; }

        public decimal? ALERT_MAX_IN_DAY { get; set; }

        [StringLength(250)]
        public string MODEL_CODE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ANTICIPATE_MATY> HIS_ANTICIPATE_MATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BID_MATERIAL_TYPE> HIS_BID_MATERIAL_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEBT_GOODS> HIS_DEBT_GOODS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EMTE_MATERIAL_TYPE> HIS_EMTE_MATERIAL_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EQUIPMENT_SET_MATY> HIS_EQUIPMENT_SET_MATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_MATY_REQ> HIS_EXP_MEST_MATY_REQ { get; set; }

        public virtual HIS_FILM_SIZE HIS_FILM_SIZE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MACHINE_SERV_MATY> HIS_MACHINE_SERV_MATY { get; set; }

        public virtual HIS_MANUFACTURER HIS_MANUFACTURER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MATERIAL> HIS_MATERIAL { get; set; }

        public virtual HIS_PACKING_TYPE HIS_PACKING_TYPE { get; set; }

        public virtual HIS_SERVICE_UNIT HIS_SERVICE_UNIT { get; set; }

        public virtual HIS_SERVICE HIS_SERVICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MATERIAL_TYPE> HIS_MATERIAL_TYPE1 { get; set; }

        public virtual HIS_MATERIAL_TYPE HIS_MATERIAL_TYPE2 { get; set; }

        public virtual HIS_MEMA_GROUP HIS_MEMA_GROUP { get; set; }

        public virtual HIS_MATERIAL_TYPE_MAP HIS_MATERIAL_TYPE_MAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MATY_MATY> HIS_MATY_MATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MATY_MATY> HIS_MATY_MATY1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_CONTRACT_MATY> HIS_MEDI_CONTRACT_MATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_STOCK_MATY> HIS_MEDI_STOCK_MATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_MATY_DEPA> HIS_MEST_MATY_DEPA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_PERIOD_MATY> HIS_MEST_PERIOD_MATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_METY_MATY> HIS_METY_MATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_QC_NORMATION> HIS_QC_NORMATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_MATY> HIS_SERE_SERV_MATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_MATY> HIS_SERVICE_MATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_REQ_MATY> HIS_SERVICE_REQ_MATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TEST_INDEX> HIS_TEST_INDEX { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_MATERIAL")]
    public partial class HIS_MATERIAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_MATERIAL()
        {
            HIS_EXP_MEST_MATERIAL = new HashSet<HIS_EXP_MEST_MATERIAL>();
            HIS_IMP_MEST_MATERIAL = new HashSet<HIS_IMP_MEST_MATERIAL>();
            HIS_MATERIAL_BEAN = new HashSet<HIS_MATERIAL_BEAN>();
            HIS_MATERIAL_MATERIAL = new HashSet<HIS_MATERIAL_MATERIAL>();
            HIS_MATERIAL_MATERIAL1 = new HashSet<HIS_MATERIAL_MATERIAL>();
            HIS_MATERIAL_PATY = new HashSet<HIS_MATERIAL_PATY>();
            HIS_MEDICINE_MATERIAL = new HashSet<HIS_MEDICINE_MATERIAL>();
            HIS_MEST_PERIOD_MATE = new HashSet<HIS_MEST_PERIOD_MATE>();
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

        public long MATERIAL_TYPE_ID { get; set; }

        public long? SUPPLIER_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public long? IMP_SOURCE_ID { get; set; }

        public decimal IMP_PRICE { get; set; }

        public decimal IMP_VAT_RATIO { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        public long? IMP_TIME { get; set; }

        public long? BID_ID { get; set; }

        [StringLength(30)]
        public string TDL_BID_NUMBER { get; set; }

        [StringLength(50)]
        public string TDL_BID_NUM_ORDER { get; set; }

        [StringLength(4)]
        public string TDL_BID_GROUP_CODE { get; set; }

        [StringLength(4)]
        public string TDL_BID_PACKAGE_CODE { get; set; }

        [StringLength(20)]
        public string TDL_BID_YEAR { get; set; }

        [StringLength(100)]
        public string PACKAGE_NUMBER { get; set; }

        public long? EXPIRED_DATE { get; set; }

        public short? IS_PREGNANT { get; set; }

        public short? IS_SALE_EQUAL_IMP_PRICE { get; set; }

        public long TDL_SERVICE_ID { get; set; }

        public decimal? VIR_IMP_PRICE { get; set; }

        public long? MAX_REUSE_COUNT { get; set; }

        public long? DOCUMENT_PRICE { get; set; }

        [StringLength(1000)]
        public string CONCENTRA { get; set; }

        public long? MANUFACTURER_ID { get; set; }

        [StringLength(100)]
        public string NATIONAL_NAME { get; set; }

        [StringLength(12)]
        public string TDL_IMP_MEST_CODE { get; set; }

        [StringLength(25)]
        public string TDL_IMP_MEST_SUB_CODE { get; set; }

        [StringLength(500)]
        public string MATERIAL_REGISTER_NUMBER { get; set; }

        public decimal? IMP_UNIT_AMOUNT { get; set; }

        public decimal? IMP_UNIT_PRICE { get; set; }

        public long? TDL_IMP_UNIT_ID { get; set; }

        public decimal? TDL_IMP_UNIT_CONVERT_RATIO { get; set; }

        public long? MEDICAL_CONTRACT_ID { get; set; }

        public decimal? CONTRACT_PRICE { get; set; }

        public decimal? PROFIT_RATIO { get; set; }

        [StringLength(50)]
        public string BID_MATERIAL_TYPE_CODE { get; set; }

        [StringLength(500)]
        public string BID_MATERIAL_TYPE_NAME { get; set; }

        public decimal? TAX_RATIO { get; set; }

        [StringLength(50)]
        public string TDL_BID_EXTRA_CODE { get; set; }

        [StringLength(4000)]
        public string LOCKING_REASON { get; set; }

        public virtual HIS_BID HIS_BID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_MATERIAL> HIS_EXP_MEST_MATERIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST_MATERIAL> HIS_IMP_MEST_MATERIAL { get; set; }

        public virtual HIS_IMP_SOURCE HIS_IMP_SOURCE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MATERIAL_BEAN> HIS_MATERIAL_BEAN { get; set; }

        public virtual HIS_MATERIAL_TYPE HIS_MATERIAL_TYPE { get; set; }

        public virtual HIS_SUPPLIER HIS_SUPPLIER { get; set; }

        public virtual HIS_MEDICAL_CONTRACT HIS_MEDICAL_CONTRACT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MATERIAL_MATERIAL> HIS_MATERIAL_MATERIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MATERIAL_MATERIAL> HIS_MATERIAL_MATERIAL1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MATERIAL_PATY> HIS_MATERIAL_PATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICINE_MATERIAL> HIS_MEDICINE_MATERIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_PERIOD_MATE> HIS_MEST_PERIOD_MATE { get; set; }
    }
}

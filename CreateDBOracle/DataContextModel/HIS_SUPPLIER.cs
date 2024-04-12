namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SUPPLIER")]
    public partial class HIS_SUPPLIER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_SUPPLIER()
        {
            HIS_ANTICIPATE_BLTY = new HashSet<HIS_ANTICIPATE_BLTY>();
            HIS_ANTICIPATE_MATY = new HashSet<HIS_ANTICIPATE_MATY>();
            HIS_ANTICIPATE_METY = new HashSet<HIS_ANTICIPATE_METY>();
            HIS_BID_BLOOD_TYPE = new HashSet<HIS_BID_BLOOD_TYPE>();
            HIS_BID_MATERIAL_TYPE = new HashSet<HIS_BID_MATERIAL_TYPE>();
            HIS_BID_MEDICINE_TYPE = new HashSet<HIS_BID_MEDICINE_TYPE>();
            HIS_BLOOD = new HashSet<HIS_BLOOD>();
            HIS_EXP_MEST = new HashSet<HIS_EXP_MEST>();
            HIS_IMP_MEST = new HashSet<HIS_IMP_MEST>();
            HIS_IMP_MEST_PROPOSE = new HashSet<HIS_IMP_MEST_PROPOSE>();
            HIS_MATERIAL = new HashSet<HIS_MATERIAL>();
            HIS_MEDICAL_CONTRACT = new HashSet<HIS_MEDICAL_CONTRACT>();
            HIS_MEDICAL_CONTRACT1 = new HashSet<HIS_MEDICAL_CONTRACT>();
            HIS_MEDICINE = new HashSet<HIS_MEDICINE>();
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
        [StringLength(10)]
        public string SUPPLIER_CODE { get; set; }

        [Required]
        [StringLength(1000)]
        public string SUPPLIER_NAME { get; set; }

        [StringLength(100)]
        public string SUPPLIER_SHORT_NAME { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(20)]
        public string PHONE { get; set; }

        [StringLength(2000)]
        public string ADDRESS { get; set; }

        [StringLength(20)]
        public string TAX_CODE { get; set; }

        [StringLength(200)]
        public string REPRESENTATIVE { get; set; }

        [StringLength(20)]
        public string FAX { get; set; }

        [StringLength(100)]
        public string POSITION { get; set; }

        [StringLength(50)]
        public string AUTH_LETTER_NUM { get; set; }

        public long? AUTH_LETTER_ISSUE_DATE { get; set; }

        [StringLength(50)]
        public string CONTRACT_NUM { get; set; }

        public long? CONTRACT_DATE { get; set; }

        public decimal? BANK_ACCOUNT { get; set; }

        [StringLength(300)]
        public string BANK_INFO { get; set; }

        public short? IS_BLOOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ANTICIPATE_BLTY> HIS_ANTICIPATE_BLTY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ANTICIPATE_MATY> HIS_ANTICIPATE_MATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ANTICIPATE_METY> HIS_ANTICIPATE_METY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BID_BLOOD_TYPE> HIS_BID_BLOOD_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BID_MATERIAL_TYPE> HIS_BID_MATERIAL_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BID_MEDICINE_TYPE> HIS_BID_MEDICINE_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BLOOD> HIS_BLOOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST> HIS_EXP_MEST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST> HIS_IMP_MEST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST_PROPOSE> HIS_IMP_MEST_PROPOSE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MATERIAL> HIS_MATERIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICAL_CONTRACT> HIS_MEDICAL_CONTRACT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICAL_CONTRACT> HIS_MEDICAL_CONTRACT1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICINE> HIS_MEDICINE { get; set; }
    }
}

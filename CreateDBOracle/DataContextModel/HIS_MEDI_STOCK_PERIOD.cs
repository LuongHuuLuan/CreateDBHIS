namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_MEDI_STOCK_PERIOD")]
    public partial class HIS_MEDI_STOCK_PERIOD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_MEDI_STOCK_PERIOD()
        {
            HIS_EXP_MEST = new HashSet<HIS_EXP_MEST>();
            HIS_EXP_MEST_BLOOD = new HashSet<HIS_EXP_MEST_BLOOD>();
            HIS_EXP_MEST_MATERIAL = new HashSet<HIS_EXP_MEST_MATERIAL>();
            HIS_EXP_MEST_MEDICINE = new HashSet<HIS_EXP_MEST_MEDICINE>();
            HIS_IMP_MEST = new HashSet<HIS_IMP_MEST>();
            HIS_IMP_MEST1 = new HashSet<HIS_IMP_MEST>();
            HIS_MEDI_STOCK_PERIOD1 = new HashSet<HIS_MEDI_STOCK_PERIOD>();
            HIS_MEST_INVENTORY = new HashSet<HIS_MEST_INVENTORY>();
            HIS_MEST_PERIOD_BLOOD = new HashSet<HIS_MEST_PERIOD_BLOOD>();
            HIS_MEST_PERIOD_BLTY = new HashSet<HIS_MEST_PERIOD_BLTY>();
            HIS_MEST_PERIOD_MATE = new HashSet<HIS_MEST_PERIOD_MATE>();
            HIS_MEST_PERIOD_MATY = new HashSet<HIS_MEST_PERIOD_MATY>();
            HIS_MEST_PERIOD_MEDI = new HashSet<HIS_MEST_PERIOD_MEDI>();
            HIS_MEST_PERIOD_METY = new HashSet<HIS_MEST_PERIOD_METY>();
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
        [StringLength(100)]
        public string MEDI_STOCK_PERIOD_NAME { get; set; }

        public long MEDI_STOCK_ID { get; set; }

        public long? PREVIOUS_ID { get; set; }

        public long? COUNT_MEDICINE_TYPE { get; set; }

        public long? COUNT_MATERIAL_TYPE { get; set; }

        public long? COUNT_IMP_MEST { get; set; }

        public long? COUNT_EXP_MEST { get; set; }

        public long? TO_TIME { get; set; }

        public short? IS_APPROVE { get; set; }

        public short? IS_AUTO_PERIOD { get; set; }

        [StringLength(80)]
        public string VIR_UNIQUE_AUTO_PERIOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST> HIS_EXP_MEST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_BLOOD> HIS_EXP_MEST_BLOOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_MATERIAL> HIS_EXP_MEST_MATERIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_MEDICINE> HIS_EXP_MEST_MEDICINE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST> HIS_IMP_MEST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST> HIS_IMP_MEST1 { get; set; }

        public virtual HIS_MEDI_STOCK HIS_MEDI_STOCK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_STOCK_PERIOD> HIS_MEDI_STOCK_PERIOD1 { get; set; }

        public virtual HIS_MEDI_STOCK_PERIOD HIS_MEDI_STOCK_PERIOD2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_INVENTORY> HIS_MEST_INVENTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_PERIOD_BLOOD> HIS_MEST_PERIOD_BLOOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_PERIOD_BLTY> HIS_MEST_PERIOD_BLTY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_PERIOD_MATE> HIS_MEST_PERIOD_MATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_PERIOD_MATY> HIS_MEST_PERIOD_MATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_PERIOD_MEDI> HIS_MEST_PERIOD_MEDI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_PERIOD_METY> HIS_MEST_PERIOD_METY { get; set; }
    }
}

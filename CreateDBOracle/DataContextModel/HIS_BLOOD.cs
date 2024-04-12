namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_BLOOD")]
    public partial class HIS_BLOOD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_BLOOD()
        {
            HIS_EXP_MEST_BLOOD = new HashSet<HIS_EXP_MEST_BLOOD>();
            HIS_IMP_MEST_BLOOD = new HashSet<HIS_IMP_MEST_BLOOD>();
            HIS_MEST_PERIOD_BLOOD = new HashSet<HIS_MEST_PERIOD_BLOOD>();
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
        [StringLength(20)]
        public string BLOOD_CODE { get; set; }

        public long BLOOD_TYPE_ID { get; set; }

        public long BLOOD_ABO_ID { get; set; }

        public long? BLOOD_RH_ID { get; set; }

        public long? MEDI_STOCK_ID { get; set; }

        public long? SUPPLIER_ID { get; set; }

        public long? IMP_SOURCE_ID { get; set; }

        public long? BID_ID { get; set; }

        [StringLength(50)]
        public string BID_NUM_ORDER { get; set; }

        public decimal IMP_PRICE { get; set; }

        public decimal IMP_VAT_RATIO { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        public long? IMP_TIME { get; set; }

        public long? PACKING_TIME { get; set; }

        [StringLength(100)]
        public string PACKAGE_NUMBER { get; set; }

        public long? EXPIRED_DATE { get; set; }

        public short? IS_INFECT { get; set; }

        [StringLength(100)]
        public string GIVE_NAME { get; set; }

        [StringLength(20)]
        public string GIVE_CODE { get; set; }

        public short? IS_PREGNANT { get; set; }

        public decimal? VIR_IMP_PRICE { get; set; }

        public long? BLOOD_GIVE_ID { get; set; }

        public long? LAST_EXP_MEST_BLOOD_ID { get; set; }

        public virtual HIS_BID HIS_BID { get; set; }

        public virtual HIS_BLOOD_TYPE HIS_BLOOD_TYPE { get; set; }

        public virtual HIS_BLOOD_GIVER HIS_BLOOD_GIVER { get; set; }

        public virtual HIS_MEDI_STOCK HIS_MEDI_STOCK { get; set; }

        public virtual HIS_SUPPLIER HIS_SUPPLIER { get; set; }

        public virtual HIS_IMP_SOURCE HIS_IMP_SOURCE { get; set; }

        public virtual HIS_BLOOD_ABO HIS_BLOOD_ABO { get; set; }

        public virtual HIS_BLOOD_RH HIS_BLOOD_RH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_BLOOD> HIS_EXP_MEST_BLOOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST_BLOOD> HIS_IMP_MEST_BLOOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_PERIOD_BLOOD> HIS_MEST_PERIOD_BLOOD { get; set; }
    }
}

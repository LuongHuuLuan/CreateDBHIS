namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_BLOOD_TYPE")]
    public partial class HIS_BLOOD_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_BLOOD_TYPE()
        {
            HIS_ANTICIPATE_BLTY = new HashSet<HIS_ANTICIPATE_BLTY>();
            HIS_BID_BLOOD_TYPE = new HashSet<HIS_BID_BLOOD_TYPE>();
            HIS_BLOOD = new HashSet<HIS_BLOOD>();
            HIS_BLOOD_TYPE1 = new HashSet<HIS_BLOOD_TYPE>();
            HIS_BLTY_SERVICE = new HashSet<HIS_BLTY_SERVICE>();
            HIS_BLTY_VOLUME = new HashSet<HIS_BLTY_VOLUME>();
            HIS_EXP_BLTY_SERVICE = new HashSet<HIS_EXP_BLTY_SERVICE>();
            HIS_EXP_MEST_BLTY_REQ = new HashSet<HIS_EXP_MEST_BLTY_REQ>();
            HIS_MEDI_STOCK_BLTY = new HashSet<HIS_MEDI_STOCK_BLTY>();
            HIS_MEST_PERIOD_BLTY = new HashSet<HIS_MEST_PERIOD_BLTY>();
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
        public string BLOOD_TYPE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string BLOOD_TYPE_NAME { get; set; }

        public long SERVICE_ID { get; set; }

        public long? PARENT_ID { get; set; }

        public short? IS_LEAF { get; set; }

        public long? NUM_ORDER { get; set; }

        public long TDL_SERVICE_UNIT_ID { get; set; }

        public long BLOOD_VOLUME_ID { get; set; }

        public long? BLOOD_GROUP_ID { get; set; }

        public long? PACKING_TYPE_ID { get; set; }

        public decimal? IMP_PRICE { get; set; }

        public decimal? IMP_VAT_RATIO { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        public long? ALERT_EXPIRED_DATE { get; set; }

        [StringLength(100)]
        public string ELEMENT { get; set; }

        public short? IS_RED_BLOOD_CELLS { get; set; }

        public long? WARNING_DAY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ANTICIPATE_BLTY> HIS_ANTICIPATE_BLTY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BID_BLOOD_TYPE> HIS_BID_BLOOD_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BLOOD> HIS_BLOOD { get; set; }

        public virtual HIS_BLOOD_GROUP HIS_BLOOD_GROUP { get; set; }

        public virtual HIS_SERVICE HIS_SERVICE { get; set; }

        public virtual HIS_BLOOD_VOLUME HIS_BLOOD_VOLUME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BLOOD_TYPE> HIS_BLOOD_TYPE1 { get; set; }

        public virtual HIS_BLOOD_TYPE HIS_BLOOD_TYPE2 { get; set; }

        public virtual HIS_PACKING_TYPE HIS_PACKING_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BLTY_SERVICE> HIS_BLTY_SERVICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BLTY_VOLUME> HIS_BLTY_VOLUME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_BLTY_SERVICE> HIS_EXP_BLTY_SERVICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_BLTY_REQ> HIS_EXP_MEST_BLTY_REQ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_STOCK_BLTY> HIS_MEDI_STOCK_BLTY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_PERIOD_BLTY> HIS_MEST_PERIOD_BLTY { get; set; }
    }
}

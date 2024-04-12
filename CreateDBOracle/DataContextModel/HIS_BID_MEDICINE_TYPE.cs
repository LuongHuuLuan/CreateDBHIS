namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_BID_MEDICINE_TYPE")]
    public partial class HIS_BID_MEDICINE_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_BID_MEDICINE_TYPE()
        {
            HIS_MEDI_CONTRACT_METY = new HashSet<HIS_MEDI_CONTRACT_METY>();
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

        public long BID_ID { get; set; }

        public long MEDICINE_TYPE_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal? IMP_PRICE { get; set; }

        public decimal? IMP_VAT_RATIO { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        [StringLength(50)]
        public string BID_NUM_ORDER { get; set; }

        public long SUPPLIER_ID { get; set; }

        [StringLength(4)]
        public string BID_GROUP_CODE { get; set; }

        [StringLength(4)]
        public string BID_PACKAGE_CODE { get; set; }

        public long? EXPIRED_DATE { get; set; }

        [StringLength(1000)]
        public string NATIONAL_NAME { get; set; }

        public long? MANUFACTURER_ID { get; set; }

        [StringLength(1000)]
        public string CONCENTRA { get; set; }

        [StringLength(500)]
        public string MEDICINE_REGISTER_NUMBER { get; set; }

        public decimal? TDL_CONTRACT_AMOUNT { get; set; }

        [StringLength(300)]
        public string PACKING_TYPE_NAME { get; set; }

        [StringLength(500)]
        public string HEIN_SERVICE_BHYT_NAME { get; set; }

        public long? MONTH_LIFESPAN { get; set; }

        public long? DAY_LIFESPAN { get; set; }

        public long? HOUR_LIFESPAN { get; set; }

        [StringLength(1000)]
        public string ACTIVE_INGR_BHYT_NAME { get; set; }

        public long? MEDICINE_USE_FORM_ID { get; set; }

        [StringLength(100)]
        public string DOSAGE_FORM { get; set; }

        [StringLength(4000)]
        public string NOTE { get; set; }

        public decimal? IMP_MORE_RATIO { get; set; }

        public decimal? ADJUST_AMOUNT { get; set; }

        public virtual HIS_BID HIS_BID { get; set; }

        public virtual HIS_MEDICINE_TYPE HIS_MEDICINE_TYPE { get; set; }

        public virtual HIS_SUPPLIER HIS_SUPPLIER { get; set; }

        public virtual HIS_MEDICINE_USE_FORM HIS_MEDICINE_USE_FORM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_CONTRACT_METY> HIS_MEDI_CONTRACT_METY { get; set; }
    }
}

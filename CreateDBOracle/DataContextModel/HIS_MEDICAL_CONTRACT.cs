namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_MEDICAL_CONTRACT")]
    public partial class HIS_MEDICAL_CONTRACT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_MEDICAL_CONTRACT()
        {
            HIS_IMP_MEST = new HashSet<HIS_IMP_MEST>();
            HIS_IMP_MEST_PROPOSE = new HashSet<HIS_IMP_MEST_PROPOSE>();
            HIS_MATERIAL = new HashSet<HIS_MATERIAL>();
            HIS_MEDI_CONTRACT_MATY = new HashSet<HIS_MEDI_CONTRACT_MATY>();
            HIS_MEDI_CONTRACT_METY = new HashSet<HIS_MEDI_CONTRACT_METY>();
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
        [StringLength(50)]
        public string MEDICAL_CONTRACT_CODE { get; set; }

        [StringLength(200)]
        public string MEDICAL_CONTRACT_NAME { get; set; }

        public long SUPPLIER_ID { get; set; }

        public long? DOCUMENT_SUPPLIER_ID { get; set; }

        public long? BID_ID { get; set; }

        [StringLength(500)]
        public string VENTURE_AGREENING { get; set; }

        public long? VALID_FROM_DATE { get; set; }

        public long? VALID_TO_DATE { get; set; }

        [StringLength(4000)]
        public string NOTE { get; set; }

        public decimal? VIR_CREATE_DATE { get; set; }

        public virtual HIS_BID HIS_BID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST> HIS_IMP_MEST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST_PROPOSE> HIS_IMP_MEST_PROPOSE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MATERIAL> HIS_MATERIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_CONTRACT_MATY> HIS_MEDI_CONTRACT_MATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_CONTRACT_METY> HIS_MEDI_CONTRACT_METY { get; set; }

        public virtual HIS_SUPPLIER HIS_SUPPLIER { get; set; }

        public virtual HIS_SUPPLIER HIS_SUPPLIER1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICINE> HIS_MEDICINE { get; set; }
    }
}

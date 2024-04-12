namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_ALLERGY_CARD")]
    public partial class HIS_ALLERGY_CARD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_ALLERGY_CARD()
        {
            HIS_ALLERGENIC = new HashSet<HIS_ALLERGENIC>();
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

        public long TREATMENT_ID { get; set; }

        public long ISSUE_TIME { get; set; }

        [Required]
        [StringLength(50)]
        public string DIAGNOSE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string DIAGNOSE_USERNAME { get; set; }

        [StringLength(12)]
        public string DIAGNOSE_PHONE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ALLERGENIC> HIS_ALLERGENIC { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }
    }
}

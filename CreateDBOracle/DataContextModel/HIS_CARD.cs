namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_CARD")]
    public partial class HIS_CARD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_CARD()
        {
            HIS_TRANSACTION = new HashSet<HIS_TRANSACTION>();
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
        [StringLength(40)]
        public string SERVICE_CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string CARD_CODE { get; set; }

        [StringLength(20)]
        public string CARD_NUMBER { get; set; }

        [StringLength(50)]
        public string CARD_MAC { get; set; }

        public long? PATIENT_ID { get; set; }

        [StringLength(20)]
        public string BANK_CARD_CODE { get; set; }

        public virtual HIS_PATIENT HIS_PATIENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TRANSACTION> HIS_TRANSACTION { get; set; }
    }
}

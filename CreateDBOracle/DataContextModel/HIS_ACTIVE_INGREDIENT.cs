namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_ACTIVE_INGREDIENT")]
    public partial class HIS_ACTIVE_INGREDIENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_ACTIVE_INGREDIENT()
        {
            HIS_ACIN_INTERACTIVE = new HashSet<HIS_ACIN_INTERACTIVE>();
            HIS_ACIN_INTERACTIVE1 = new HashSet<HIS_ACIN_INTERACTIVE>();
            HIS_ANTIBIOTIC_NEW_REG = new HashSet<HIS_ANTIBIOTIC_NEW_REG>();
            HIS_ICD_SERVICE = new HashSet<HIS_ICD_SERVICE>();
            HIS_MEDICINE_TYPE_ACIN = new HashSet<HIS_MEDICINE_TYPE_ACIN>();
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
        [StringLength(15)]
        public string ACTIVE_INGREDIENT_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string ACTIVE_INGREDIENT_NAME { get; set; }

        public short? IS_CONSULTATION_REQUIRED { get; set; }

        [StringLength(1000)]
        public string NOTE { get; set; }

        public short? IS_APPROVAL_REQUIRED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ACIN_INTERACTIVE> HIS_ACIN_INTERACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ACIN_INTERACTIVE> HIS_ACIN_INTERACTIVE1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ANTIBIOTIC_NEW_REG> HIS_ANTIBIOTIC_NEW_REG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ICD_SERVICE> HIS_ICD_SERVICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICINE_TYPE_ACIN> HIS_MEDICINE_TYPE_ACIN { get; set; }
    }
}

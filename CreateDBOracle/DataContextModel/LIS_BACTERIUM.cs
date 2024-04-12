namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.LIS_BACTERIUM")]
    public partial class LIS_BACTERIUM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LIS_BACTERIUM()
        {
            LIS_BAC_ANTIBIOTIC = new HashSet<LIS_BAC_ANTIBIOTIC>();
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
        public string BACTERIUM_CODE { get; set; }

        [Required]
        [StringLength(200)]
        public string BACTERIUM_NAME { get; set; }

        public long BACTERIUM_FAMILY_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIS_BAC_ANTIBIOTIC> LIS_BAC_ANTIBIOTIC { get; set; }

        public virtual LIS_BACTERIUM_FAMILY LIS_BACTERIUM_FAMILY { get; set; }
    }
}

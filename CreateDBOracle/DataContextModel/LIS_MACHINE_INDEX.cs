namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.LIS_MACHINE_INDEX")]
    public partial class LIS_MACHINE_INDEX
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LIS_MACHINE_INDEX()
        {
            LIS_TEST_INDEX_MAP = new HashSet<LIS_TEST_INDEX_MAP>();
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
        public string MACHINE_INDEX_CODE { get; set; }

        [StringLength(100)]
        public string MACHINE_INDEX_NAME { get; set; }

        public long MACHINE_ID { get; set; }

        [StringLength(20)]
        public string FORMAT_VALUE { get; set; }

        public decimal? RESULT_COEFFICIENT { get; set; }

        public virtual LIS_MACHINE LIS_MACHINE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIS_TEST_INDEX_MAP> LIS_TEST_INDEX_MAP { get; set; }
    }
}

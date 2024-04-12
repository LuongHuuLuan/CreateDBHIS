namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.SDA_CONFIG_APP")]
    public partial class SDA_CONFIG_APP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SDA_CONFIG_APP()
        {
            SDA_CONFIG_APP_USER = new HashSet<SDA_CONFIG_APP_USER>();
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

        [StringLength(20)]
        public string GROUP_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string KEY { get; set; }

        [StringLength(500)]
        public string DEFAULT_VALUE { get; set; }

        [StringLength(20)]
        public string VALUE_TYPE { get; set; }

        [StringLength(100)]
        public string VALUE_ALLOW_MIN { get; set; }

        [StringLength(100)]
        public string VALUE_ALLOW_MAX { get; set; }

        [StringLength(100)]
        public string VALUE_ALLOW_IN { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        [StringLength(3)]
        public string APP_CODE { get; set; }

        [StringLength(4000)]
        public string MODULE_LINKS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SDA_CONFIG_APP_USER> SDA_CONFIG_APP_USER { get; set; }
    }
}

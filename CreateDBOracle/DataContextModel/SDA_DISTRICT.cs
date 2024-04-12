namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.SDA_DISTRICT")]
    public partial class SDA_DISTRICT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SDA_DISTRICT()
        {
            SDA_COMMUNE = new HashSet<SDA_COMMUNE>();
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
        [StringLength(4)]
        public string DISTRICT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string DISTRICT_NAME { get; set; }

        [StringLength(20)]
        public string INITIAL_NAME { get; set; }

        public long PROVINCE_ID { get; set; }

        [StringLength(10)]
        public string SEARCH_CODE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SDA_COMMUNE> SDA_COMMUNE { get; set; }

        public virtual SDA_PROVINCE SDA_PROVINCE { get; set; }
    }
}

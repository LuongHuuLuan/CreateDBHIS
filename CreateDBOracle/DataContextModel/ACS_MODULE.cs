namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.ACS_MODULE")]
    public partial class ACS_MODULE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACS_MODULE()
        {
            ACS_MODULE_ROLE = new HashSet<ACS_MODULE_ROLE>();
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
        [StringLength(100)]
        public string MODULE_NAME { get; set; }

        [StringLength(200)]
        public string MODULE_LINK { get; set; }

        public short? IS_VISIBLE { get; set; }

        public long? NUM_ORDER { get; set; }

        public short? IS_LEAF { get; set; }

        public long? PARENT_ID { get; set; }

        public long APPLICATION_ID { get; set; }

        public long? MODULE_GROUP_ID { get; set; }

        [StringLength(1000)]
        public string ICON_LINK { get; set; }

        public short? IS_ANONYMOUS { get; set; }

        [StringLength(200)]
        public string MODULE_URL { get; set; }

        [StringLength(200)]
        public string VIR_MODULE_LINK { get; set; }

        [StringLength(4000)]
        public string VIDEO_URLS { get; set; }

        public short? IS_NOT_SHOW_DIALOG { get; set; }

        public virtual ACS_APPLICATION ACS_APPLICATION { get; set; }

        public virtual ACS_MODULE_GROUP ACS_MODULE_GROUP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACS_MODULE_ROLE> ACS_MODULE_ROLE { get; set; }
    }
}

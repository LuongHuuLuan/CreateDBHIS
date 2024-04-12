namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_HEIN_SERVICE_TYPE")]
    public partial class HIS_HEIN_SERVICE_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_HEIN_SERVICE_TYPE()
        {
            HIS_SERVICE = new HashSet<HIS_SERVICE>();
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
        [StringLength(10)]
        public string HEIN_SERVICE_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string HEIN_SERVICE_TYPE_NAME { get; set; }

        public long? NUM_ORDER { get; set; }

        [StringLength(2)]
        public string BHYT_CODE { get; set; }

        public long? PARENT_NUM_ORDER { get; set; }

        public long? VIR_PARENT_NUM_ORDER { get; set; }

        [StringLength(2)]
        public string OLD_BHYT_CODE { get; set; }

        public long? BHYT_CODE_IN_TIME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE> HIS_SERVICE { get; set; }
    }
}

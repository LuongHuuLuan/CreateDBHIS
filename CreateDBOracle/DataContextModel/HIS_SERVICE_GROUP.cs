namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SERVICE_GROUP")]
    public partial class HIS_SERVICE_GROUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_SERVICE_GROUP()
        {
            HIS_SERV_SEGR = new HashSet<HIS_SERV_SEGR>();
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
        [StringLength(6)]
        public string SERVICE_GROUP_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_GROUP_NAME { get; set; }

        public short? IS_PUBLIC { get; set; }

        public short? NUM_ORDER { get; set; }

        public long? PARENT_SERVICE_ID { get; set; }

        [StringLength(1000)]
        public string DESCRIPTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERV_SEGR> HIS_SERV_SEGR { get; set; }

        public virtual HIS_SERVICE HIS_SERVICE { get; set; }
    }
}

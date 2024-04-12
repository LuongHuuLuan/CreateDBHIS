namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_DESK")]
    public partial class HIS_DESK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_DESK()
        {
            HIS_SERVICE_REQ = new HashSet<HIS_SERVICE_REQ>();
            HIS_SUBCLINICAL_RS_ADD = new HashSet<HIS_SUBCLINICAL_RS_ADD>();
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
        public string DESK_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string DESK_NAME { get; set; }

        public long? ROOM_ID { get; set; }

        public long? MAX_REQ_PER_DAY { get; set; }

        public long? AREA_ID { get; set; }

        public virtual HIS_AREA HIS_AREA { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_REQ> HIS_SERVICE_REQ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SUBCLINICAL_RS_ADD> HIS_SUBCLINICAL_RS_ADD { get; set; }
    }
}

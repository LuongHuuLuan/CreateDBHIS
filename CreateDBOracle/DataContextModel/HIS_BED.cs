namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_BED")]
    public partial class HIS_BED
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_BED()
        {
            HIS_BED_BSTY = new HashSet<HIS_BED_BSTY>();
            HIS_BED_LOG = new HashSet<HIS_BED_LOG>();
            HIS_TREATMENT_BED_ROOM = new HashSet<HIS_TREATMENT_BED_ROOM>();
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
        public string BED_CODE { get; set; }

        [Required]
        [StringLength(200)]
        public string BED_NAME { get; set; }

        public long BED_ROOM_ID { get; set; }

        public long BED_TYPE_ID { get; set; }

        public long? MAX_CAPACITY { get; set; }

        [StringLength(6)]
        public string X { get; set; }

        [StringLength(6)]
        public string Y { get; set; }

        public long? TREATMENT_ROOM_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BED_BSTY> HIS_BED_BSTY { get; set; }

        public virtual HIS_BED_ROOM HIS_BED_ROOM { get; set; }

        public virtual HIS_BED_TYPE HIS_BED_TYPE { get; set; }

        public virtual HIS_TREATMENT_ROOM HIS_TREATMENT_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BED_LOG> HIS_BED_LOG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TREATMENT_BED_ROOM> HIS_TREATMENT_BED_ROOM { get; set; }
    }
}

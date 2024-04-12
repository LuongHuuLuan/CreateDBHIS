namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SUIM_INDEX")]
    public partial class HIS_SUIM_INDEX
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_SUIM_INDEX()
        {
            HIS_SERE_SERV_SUIN = new HashSet<HIS_SERE_SERV_SUIN>();
            HIS_SERVICE = new HashSet<HIS_SERVICE>();
            HIS_SUIM_SETY_SUIN = new HashSet<HIS_SUIM_SETY_SUIN>();
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
        public string SUIM_INDEX_CODE { get; set; }

        [Required]
        [StringLength(1000)]
        public string SUIM_INDEX_NAME { get; set; }

        public long? SUIM_INDEX_UNIT_ID { get; set; }

        public long? NUM_ORDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_SUIN> HIS_SERE_SERV_SUIN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE> HIS_SERVICE { get; set; }

        public virtual HIS_SUIM_INDEX_UNIT HIS_SUIM_INDEX_UNIT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SUIM_SETY_SUIN> HIS_SUIM_SETY_SUIN { get; set; }
    }
}

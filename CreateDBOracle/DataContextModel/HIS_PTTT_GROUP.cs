namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_PTTT_GROUP")]
    public partial class HIS_PTTT_GROUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_PTTT_GROUP()
        {
            HIS_PTTT_GROUP_BEST = new HashSet<HIS_PTTT_GROUP_BEST>();
            HIS_PTTT_METHOD = new HashSet<HIS_PTTT_METHOD>();
            HIS_SERE_SERV_PTTT = new HashSet<HIS_SERE_SERV_PTTT>();
            HIS_SERE_SERV_PTTT_TEMP = new HashSet<HIS_SERE_SERV_PTTT_TEMP>();
            HIS_SERVICE = new HashSet<HIS_SERVICE>();
            HIS_SESE_PTTT_METHOD = new HashSet<HIS_SESE_PTTT_METHOD>();
            HIS_SURG_REMUNERATION = new HashSet<HIS_SURG_REMUNERATION>();
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
        [StringLength(2)]
        public string PTTT_GROUP_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string PTTT_GROUP_NAME { get; set; }

        public decimal? REMUNERATION { get; set; }

        public long? NUM_ORDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PTTT_GROUP_BEST> HIS_PTTT_GROUP_BEST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PTTT_METHOD> HIS_PTTT_METHOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_PTTT> HIS_SERE_SERV_PTTT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_PTTT_TEMP> HIS_SERE_SERV_PTTT_TEMP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE> HIS_SERVICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SESE_PTTT_METHOD> HIS_SESE_PTTT_METHOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SURG_REMUNERATION> HIS_SURG_REMUNERATION { get; set; }
    }
}

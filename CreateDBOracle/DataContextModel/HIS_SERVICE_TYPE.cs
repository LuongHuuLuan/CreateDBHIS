namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SERVICE_TYPE")]
    public partial class HIS_SERVICE_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_SERVICE_TYPE()
        {
            HIS_SERE_SERV_TEMP = new HashSet<HIS_SERE_SERV_TEMP>();
            HIS_SERVICE = new HashSet<HIS_SERVICE>();
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
        public string SERVICE_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_TYPE_NAME { get; set; }

        public long? NUM_ORDER { get; set; }

        public long? EXE_SERVICE_MODULE_ID { get; set; }

        public short? IS_AUTO_SPLIT_REQ { get; set; }

        public short? IS_NOT_DISPLAY_ASSIGN { get; set; }

        public short? IS_SPLIT_REQ_BY_SAMPLE_TYPE { get; set; }

        public short? IS_REQUIRED_SAMPLE_TYPE { get; set; }

        public virtual HIS_EXE_SERVICE_MODULE HIS_EXE_SERVICE_MODULE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_TEMP> HIS_SERE_SERV_TEMP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE> HIS_SERVICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SURG_REMUNERATION> HIS_SURG_REMUNERATION { get; set; }
    }
}

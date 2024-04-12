namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_MACHINE")]
    public partial class HIS_MACHINE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_MACHINE()
        {
            HIS_EXP_MEST = new HashSet<HIS_EXP_MEST>();
            HIS_MACHINE_SERV_MATY = new HashSet<HIS_MACHINE_SERV_MATY>();
            HIS_QC_NORMATION = new HashSet<HIS_QC_NORMATION>();
            HIS_SERE_SERV_EXT = new HashSet<HIS_SERE_SERV_EXT>();
            HIS_SERE_SERV_TEIN = new HashSet<HIS_SERE_SERV_TEIN>();
            HIS_SERVICE_MACHINE = new HashSet<HIS_SERVICE_MACHINE>();
            HIS_SERVICE_REQ = new HashSet<HIS_SERVICE_REQ>();
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
        public string MACHINE_CODE { get; set; }

        [StringLength(200)]
        public string MACHINE_NAME { get; set; }

        [StringLength(200)]
        public string SERIAL_NUMBER { get; set; }

        [StringLength(2)]
        public string SOURCE_CODE { get; set; }

        [StringLength(10)]
        public string MACHINE_GROUP_CODE { get; set; }

        [StringLength(500)]
        public string INTEGRATE_ADDRESS { get; set; }

        public long? ROOM_ID { get; set; }

        public short? IS_KIDNEY { get; set; }

        [StringLength(2000)]
        public string ROOM_IDS { get; set; }

        public long? MAX_SERVICE_PER_DAY { get; set; }

        [StringLength(500)]
        public string MANUFACTURER_NAME { get; set; }

        [StringLength(500)]
        public string NATIONAL_NAME { get; set; }

        public short? MANUFACTURED_YEAR { get; set; }

        public short? USED_YEAR { get; set; }

        [StringLength(22)]
        public string CIRCULATION_NUMBER { get; set; }

        [StringLength(500)]
        public string SYMBOL { get; set; }

        public long? DEPARTMENT_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST> HIS_EXP_MEST { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MACHINE_SERV_MATY> HIS_MACHINE_SERV_MATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_QC_NORMATION> HIS_QC_NORMATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_EXT> HIS_SERE_SERV_EXT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_TEIN> HIS_SERE_SERV_TEIN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_MACHINE> HIS_SERVICE_MACHINE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_REQ> HIS_SERVICE_REQ { get; set; }
    }
}

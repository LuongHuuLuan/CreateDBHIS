namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_REGISTER_GATE")]
    public partial class HIS_REGISTER_GATE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_REGISTER_GATE()
        {
            HIS_REGISTER_REQ = new HashSet<HIS_REGISTER_REQ>();
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
        public string REGISTER_GATE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string REGISTER_GATE_NAME { get; set; }

        public short? IS_RESET_AFTER_NOON { get; set; }

        public long? WAITING_LIMIT { get; set; }

        public long? DEPARTMENT_ID { get; set; }

        [StringLength(200)]
        public string ADDRESS { get; set; }

        public long? HOUR_FROM { get; set; }

        public long? MINUTE_FROM { get; set; }

        public long? HOUR_TO { get; set; }

        public long? MINUTE_TO { get; set; }

        public long? CURRENT_ISSUED_NUMBER { get; set; }

        public long? CURRENT_CALLED_NUMBER { get; set; }

        public long? ISSUED_NUMBER_DATE { get; set; }

        public long? PRIORITY { get; set; }

        [StringLength(20)]
        public string FORMAT { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_REGISTER_REQ> HIS_REGISTER_REQ { get; set; }
    }
}

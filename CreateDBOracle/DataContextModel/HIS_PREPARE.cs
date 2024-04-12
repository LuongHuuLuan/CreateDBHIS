namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_PREPARE")]
    public partial class HIS_PREPARE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_PREPARE()
        {
            HIS_PREPARE_METY = new HashSet<HIS_PREPARE_METY>();
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
        public string PREPARE_CODE { get; set; }

        public long TREATMENT_ID { get; set; }

        public long? FROM_TIME { get; set; }

        public long? TO_TIME { get; set; }

        [Required]
        [StringLength(50)]
        public string REQ_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REQ_USERNAME { get; set; }

        [StringLength(50)]
        public string APPROVAL_LOGINNAME { get; set; }

        [StringLength(100)]
        public string APPROVAL_USERNAME { get; set; }

        public long? APPROVAL_TIME { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PREPARE_METY> HIS_PREPARE_METY { get; set; }
    }
}

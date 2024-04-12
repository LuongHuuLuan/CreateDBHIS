namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_IMP_MEST_PROPOSE")]
    public partial class HIS_IMP_MEST_PROPOSE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_IMP_MEST_PROPOSE()
        {
            HIS_IMP_MEST = new HashSet<HIS_IMP_MEST>();
            HIS_IMP_MEST_PAY = new HashSet<HIS_IMP_MEST_PAY>();
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
        [StringLength(8)]
        public string IMP_MEST_PROPOSE_CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string PROPOSE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string PROPOSE_USERNAME { get; set; }

        public long SUPPLIER_ID { get; set; }

        public long PROPOSE_ROOM_ID { get; set; }

        public long PROPOSE_DEPARTMENT_ID { get; set; }

        public long? MEDICAL_CONTRACT_ID { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST> HIS_IMP_MEST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST_PAY> HIS_IMP_MEST_PAY { get; set; }

        public virtual HIS_SUPPLIER HIS_SUPPLIER { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        public virtual HIS_MEDICAL_CONTRACT HIS_MEDICAL_CONTRACT { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_CARER_CARD_BORROW")]
    public partial class HIS_CARER_CARD_BORROW
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_CARER_CARD_BORROW()
        {
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

        public long BORROW_TIME { get; set; }

        public long? GIVE_BACK_TIME { get; set; }

        public long CARER_CARD_ID { get; set; }

        public long TREATMENT_ID { get; set; }

        [StringLength(50)]
        public string GIVING_LOGINNAME { get; set; }

        [StringLength(100)]
        public string GIVING_USERNAME { get; set; }

        public short? IS_LOST { get; set; }

        [StringLength(50)]
        public string RECEIVING_LOGINNAME { get; set; }

        [StringLength(100)]
        public string RECEIVING_USERNAME { get; set; }

        public virtual HIS_CARER_CARD HIS_CARER_CARD { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_REQ> HIS_SERVICE_REQ { get; set; }
    }
}

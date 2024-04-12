namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_TRANS_REQ")]
    public partial class HIS_TRANS_REQ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_TRANS_REQ()
        {
            HIS_SESE_TRANS_REQ = new HashSet<HIS_SESE_TRANS_REQ>();
            HIS_TRANSACTION = new HashSet<HIS_TRANSACTION>();
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

        public decimal AMOUNT { get; set; }

        public long TREATMENT_ID { get; set; }

        public long? TRANS_REQ_STT_ID { get; set; }

        [StringLength(4000)]
        public string BANK_JSON_DATA { get; set; }

        [Required]
        [StringLength(12)]
        public string TRANS_REQ_CODE { get; set; }

        public short? TRANS_REQ_TYPE { get; set; }

        [StringLength(2000)]
        public string BANK_MESSAGE { get; set; }

        [StringLength(12)]
        public string TDL_TREATMENT_CODE { get; set; }

        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        public long? REQUEST_ROOM_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SESE_TRANS_REQ> HIS_SESE_TRANS_REQ { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TRANSACTION> HIS_TRANSACTION { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_TREATMENT_TYPE")]
    public partial class HIS_TREATMENT_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_TREATMENT_TYPE()
        {
            HIS_DEPARTMENT = new HashSet<HIS_DEPARTMENT>();
            HIS_EMR_COVER_CONFIG = new HashSet<HIS_EMR_COVER_CONFIG>();
            HIS_EXME_REASON_CFG = new HashSet<HIS_EXME_REASON_CFG>();
            HIS_HEIN_APPROVAL = new HashSet<HIS_HEIN_APPROVAL>();
            HIS_MEST_PATY_TRTY = new HashSet<HIS_MEST_PATY_TRTY>();
            HIS_PATIENT_TYPE_ALTER = new HashSet<HIS_PATIENT_TYPE_ALTER>();
            HIS_PROGRAM = new HashSet<HIS_PROGRAM>();
            HIS_TRANSACTION = new HashSet<HIS_TRANSACTION>();
            HIS_TREATMENT = new HashSet<HIS_TREATMENT>();
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
        public string TREATMENT_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string TREATMENT_TYPE_NAME { get; set; }

        [Required]
        [StringLength(2)]
        public string HEIN_TREATMENT_TYPE_CODE { get; set; }

        public short IS_ALLOW_RECEPTION { get; set; }

        public short? IS_NOT_ALLOW_UNPAUSE { get; set; }

        public short? ALLOW_HOSPITALIZE_WHEN_PRES { get; set; }

        public short? UNSIGN_DOC_FINISH_OPTION { get; set; }

        public short? IS_DIS_SERVICE_REPAY { get; set; }

        public short? DIS_DEPOSIT_OPTION { get; set; }

        [StringLength(5)]
        public string END_CODE_PREFIX { get; set; }

        public long? REQUIRED_SERVICE_ID { get; set; }

        public short? TRANS_TIME_OUT_TIME_OPTION { get; set; }

        public long? DIS_SERVICE_DEPOSIT_OPTION { get; set; }

        public short? IS_NOT_ALLOW_SHARE_BED { get; set; }

        public short? FEE_DEBT_OPTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEPARTMENT> HIS_DEPARTMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EMR_COVER_CONFIG> HIS_EMR_COVER_CONFIG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXME_REASON_CFG> HIS_EXME_REASON_CFG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_HEIN_APPROVAL> HIS_HEIN_APPROVAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_PATY_TRTY> HIS_MEST_PATY_TRTY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PATIENT_TYPE_ALTER> HIS_PATIENT_TYPE_ALTER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PROGRAM> HIS_PROGRAM { get; set; }

        public virtual HIS_SERVICE HIS_SERVICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TRANSACTION> HIS_TRANSACTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TREATMENT> HIS_TREATMENT { get; set; }
    }
}

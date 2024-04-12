namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_DEPARTMENT_TRAN")]
    public partial class HIS_DEPARTMENT_TRAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_DEPARTMENT_TRAN()
        {
            HIS_CO_TREATMENT = new HashSet<HIS_CO_TREATMENT>();
            HIS_DEPARTMENT_TRAN1 = new HashSet<HIS_DEPARTMENT_TRAN>();
            HIS_PATIENT_TYPE_ALTER = new HashSet<HIS_PATIENT_TYPE_ALTER>();
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

        public long TREATMENT_ID { get; set; }

        public long DEPARTMENT_ID { get; set; }

        public long? PREVIOUS_ID { get; set; }

        public long? DEPARTMENT_IN_TIME { get; set; }

        public long? ICD_ID__DELETE { get; set; }

        [StringLength(10)]
        public string ICD_CODE { get; set; }

        [StringLength(500)]
        public string ICD_NAME { get; set; }

        [StringLength(500)]
        public string ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string ICD_TEXT { get; set; }

        public long? REQUEST_TIME { get; set; }

        [StringLength(10)]
        public string TRADITIONAL_ICD_CODE { get; set; }

        [StringLength(500)]
        public string TRADITIONAL_ICD_NAME { get; set; }

        [StringLength(500)]
        public string TRADITIONAL_ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string TRADITIONAL_ICD_TEXT { get; set; }

        public short? IS_HOSPITALIZED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_CO_TREATMENT> HIS_CO_TREATMENT { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEPARTMENT_TRAN> HIS_DEPARTMENT_TRAN1 { get; set; }

        public virtual HIS_DEPARTMENT_TRAN HIS_DEPARTMENT_TRAN2 { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PATIENT_TYPE_ALTER> HIS_PATIENT_TYPE_ALTER { get; set; }
    }
}

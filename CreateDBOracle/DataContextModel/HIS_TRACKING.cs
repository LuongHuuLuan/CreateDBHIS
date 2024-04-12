namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_TRACKING")]
    public partial class HIS_TRACKING
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_TRACKING()
        {
            HIS_CARE = new HashSet<HIS_CARE>();
            HIS_DEBATE = new HashSet<HIS_DEBATE>();
            HIS_DHST = new HashSet<HIS_DHST>();
            HIS_SERVICE_REQ = new HashSet<HIS_SERVICE_REQ>();
            HIS_SERVICE_REQ1 = new HashSet<HIS_SERVICE_REQ>();
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

        public long TRACKING_TIME { get; set; }

        public long? ICD_ID__DELETE { get; set; }

        [StringLength(10)]
        public string ICD_CODE { get; set; }

        [StringLength(500)]
        public string ICD_NAME { get; set; }

        [StringLength(500)]
        public string ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string ICD_TEXT { get; set; }

        [StringLength(4000)]
        public string MEDICAL_INSTRUCTION { get; set; }

        public long? DEPARTMENT_ID { get; set; }

        [StringLength(4000)]
        public string SUBCLINICAL_PROCESSES_BK { get; set; }

        [StringLength(4000)]
        public string CARE_INSTRUCTION { get; set; }

        [StringLength(4000)]
        public string GENERAL_EXPRESSION { get; set; }

        [StringLength(4000)]
        public string ORIENTATION_CAPACITY { get; set; }

        [StringLength(4000)]
        public string EMOTION { get; set; }

        [StringLength(4000)]
        public string PERCEPTION { get; set; }

        [StringLength(4000)]
        public string FORM_OF_THINKING { get; set; }

        [StringLength(4000)]
        public string CONTENT_OF_THINKING { get; set; }

        [StringLength(4000)]
        public string INSTINCTIVELY_BEHAVIOR { get; set; }

        [StringLength(4000)]
        public string AWARENESS_BEHAVIOR { get; set; }

        [StringLength(4000)]
        public string MEMORY { get; set; }

        [StringLength(4000)]
        public string INTELLECTUAL { get; set; }

        [StringLength(4000)]
        public string CONCENTRATION { get; set; }

        [StringLength(4000)]
        public string CARDIOVASCULAR { get; set; }

        [StringLength(4000)]
        public string RESPIRATORY { get; set; }

        public long? ROOM_ID { get; set; }

        [StringLength(10)]
        public string TRADITIONAL_ICD_CODE { get; set; }

        [StringLength(500)]
        public string TRADITIONAL_ICD_NAME { get; set; }

        [StringLength(500)]
        public string TRADITIONAL_ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string TRADITIONAL_ICD_TEXT { get; set; }

        [StringLength(500)]
        public string EYE_TENSION_LEFT { get; set; }

        [StringLength(500)]
        public string EYE_TENSION_RIGHT { get; set; }

        [StringLength(500)]
        public string EYESIGHT_LEFT { get; set; }

        [StringLength(500)]
        public string EYESIGHT_RIGHT { get; set; }

        [StringLength(500)]
        public string EYESIGHT_GLASS_LEFT { get; set; }

        [StringLength(500)]
        public string EYESIGHT_GLASS_RIGHT { get; set; }

        public long? SHEET_ORDER { get; set; }

        public long? EMR_DOCUMENT_STT_ID { get; set; }

        [StringLength(1000)]
        public string EMR_DOCUMENT_URL { get; set; }

        [StringLength(15)]
        public string EMR_DOCUMENT_CODE { get; set; }

        [StringLength(4000)]
        public string CONTENT_BK { get; set; }

        public string CONTENT { get; set; }

        public string SUBCLINICAL_PROCESSES { get; set; }

        [StringLength(1000)]
        public string DISEASE_STAGE { get; set; }

        [StringLength(4000)]
        public string REHABILITATION_CONTENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_CARE> HIS_CARE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEBATE> HIS_DEBATE { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DHST> HIS_DHST { get; set; }

        public virtual HIS_EMR_DOCUMENT_STT HIS_EMR_DOCUMENT_STT { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_REQ> HIS_SERVICE_REQ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_REQ> HIS_SERVICE_REQ1 { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }
    }
}

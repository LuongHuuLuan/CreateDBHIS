namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_ANTIBIOTIC_REQUEST")]
    public partial class HIS_ANTIBIOTIC_REQUEST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_ANTIBIOTIC_REQUEST()
        {
            HIS_ANTIBIOTIC_MICROBI = new HashSet<HIS_ANTIBIOTIC_MICROBI>();
            HIS_ANTIBIOTIC_NEW_REG = new HashSet<HIS_ANTIBIOTIC_NEW_REG>();
            HIS_ANTIBIOTIC_OLD_REG = new HashSet<HIS_ANTIBIOTIC_OLD_REG>();
            HIS_EXP_MEST = new HashSet<HIS_EXP_MEST>();
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
        [StringLength(12)]
        public string ANTIBIOTIC_REQUEST_CODE { get; set; }

        public long TREATMENT_ID { get; set; }

        public long DHST_ID { get; set; }

        public long REQUEST_DEPARTMENT_ID { get; set; }

        public long REQUEST_TIME { get; set; }

        [Required]
        [StringLength(50)]
        public string REQUEST_LOGINNAME { get; set; }

        [Required]
        [StringLength(100)]
        public string REQUEST_USERNAME { get; set; }

        public long? APPROVE_TIME { get; set; }

        public long ANTIBIOTIC_REQUEST_STT { get; set; }

        [StringLength(50)]
        public string APPROVAL_LOGINNAME { get; set; }

        [StringLength(100)]
        public string APPROVAL_USERNAME { get; set; }

        [StringLength(1000)]
        public string ALLERGY { get; set; }

        public short? IS_INFECTION_SHOCK { get; set; }

        public short? IS_COMMUNITY_PNEUMONIA { get; set; }

        public short? IS_HOSPITAL_PNEUMONIA { get; set; }

        public short? IS_VENTILATOR_PNEUMONIA { get; set; }

        public short? IS_MENINGITIS { get; set; }

        public short? IS_URINARY_INFECTION { get; set; }

        public short? IS_ABDOMINAL_INFECTION { get; set; }

        public short? IS_SEPSIS { get; set; }

        public short? IS_SKIN_INFECTION { get; set; }

        public short? IS_OTHER_INFECTION { get; set; }

        [StringLength(1000)]
        public string INFECTION_ENTRY { get; set; }

        [StringLength(500)]
        public string ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string ICD_TEXT { get; set; }

        [StringLength(4000)]
        public string CLINICAL_CONDITION { get; set; }

        [StringLength(100)]
        public string WHITE_BLOOD_CELL { get; set; }

        [StringLength(100)]
        public string CRP { get; set; }

        [StringLength(100)]
        public string PCT { get; set; }

        [StringLength(4000)]
        public string SUBCLINICAL_RESULT { get; set; }

        public decimal? CRCL { get; set; }

        [StringLength(4000)]
        public string NO_MICROBIOLOGY_REASON { get; set; }

        public short? IS_LESS_RESPONSIVE_REGIMEN { get; set; }

        public short? IS_DRUG_RESISTANCE { get; set; }

        [StringLength(200)]
        public string ADR_ANTIBIOTIC_NAME { get; set; }

        [StringLength(1000)]
        public string OTHER_REASON { get; set; }

        [StringLength(4000)]
        public string OTHER_OPINION { get; set; }

        public short? IS_CONTINUOUS_DIALYSIS { get; set; }

        public short? IS_HD_DIALYSIS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ANTIBIOTIC_MICROBI> HIS_ANTIBIOTIC_MICROBI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ANTIBIOTIC_NEW_REG> HIS_ANTIBIOTIC_NEW_REG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ANTIBIOTIC_OLD_REG> HIS_ANTIBIOTIC_OLD_REG { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        public virtual HIS_DHST HIS_DHST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST> HIS_EXP_MEST { get; set; }
    }
}

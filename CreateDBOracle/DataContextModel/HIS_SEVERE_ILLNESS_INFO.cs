namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SEVERE_ILLNESS_INFO")]
    public partial class HIS_SEVERE_ILLNESS_INFO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_SEVERE_ILLNESS_INFO()
        {
            HIS_EVENTS_CAUSES_DEATH = new HashSet<HIS_EVENTS_CAUSES_DEATH>();
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

        public short? IS_DEATH { get; set; }

        public short? DEATH_TYPE { get; set; }

        public short? IS_SEVERE_ILLNESS_HOME { get; set; }

        public decimal? IS_WITHIN_4_WEEK_SURGERY { get; set; }

        public long? SURGERY_DATE { get; set; }

        [StringLength(500)]
        public string SURGERY_REASON { get; set; }

        public short? IS_USING_FORENSIC_EXAMINATION { get; set; }

        public short? DEATH_CAUSES_TYPE { get; set; }

        public short? EXTERNAL_CAUSES { get; set; }

        [StringLength(500)]
        public string OTHER_EXTERNAL_CAUSES { get; set; }

        public short? IS_FETAL_OR_INFANT_DEATH { get; set; }

        public short? MULTIPLE_PREGNANCY { get; set; }

        public short? PREMATURE_BIRTH { get; set; }

        public long? INFANT_AGE { get; set; }

        public long? INFANT_WEIGHT { get; set; }

        public long? FETAL_AGE { get; set; }

        public long? MOTHER_AGE { get; set; }

        [StringLength(500)]
        public string FETAL_INFANT_AFFECTED_ICD { get; set; }

        public short? IS_DIED_WHEN_PREGNANCY { get; set; }

        public short? TIME_OF_PREGNANCY { get; set; }

        public short? IS_PREGNANCY_CAUSING_DEATH { get; set; }

        [StringLength(500)]
        public string DEATH_MAIN_CAUSE { get; set; }

        public long? TREATMENT_ID { get; set; }

        public long? DEPARTMENT_ID { get; set; }

        public long? ABSENT_DAY { get; set; }

        public long? ICU_BED_DAYS_COUNT { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EVENTS_CAUSES_DEATH> HIS_EVENTS_CAUSES_DEATH { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }
    }
}

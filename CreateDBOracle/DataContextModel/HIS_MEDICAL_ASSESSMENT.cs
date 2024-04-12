namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_MEDICAL_ASSESSMENT")]
    public partial class HIS_MEDICAL_ASSESSMENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_MEDICAL_ASSESSMENT()
        {
            HIS_ASSESSMENT_MEMBER = new HashSet<HIS_ASSESSMENT_MEMBER>();
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

        public long ASSESSMENT_OBJECT_ID { get; set; }

        public long? ASSESSMENT_TYPE_ID { get; set; }

        [StringLength(20)]
        public string WELFARE_TYPE_IDS { get; set; }

        public long ASSESSMENT_TIME_FROM { get; set; }

        [StringLength(20)]
        public string REPORT_NUMBER { get; set; }

        public decimal? PREVIOUS_INJURY_RATE { get; set; }

        [StringLength(20)]
        public string REFERRAL_CODE { get; set; }

        public long? REQUEST_TIME { get; set; }

        [StringLength(20)]
        public string REQUEST_ORG_CODE { get; set; }

        [StringLength(1000)]
        public string REQUEST_ORG_NAME { get; set; }

        [StringLength(4000)]
        public string EXAMINATION_RESULT { get; set; }

        [StringLength(200)]
        public string LEGAL_GROUND_NUMBERS { get; set; }

        public decimal? INJURY_RATE { get; set; }

        public decimal? INJURY_RATE_TOTAL { get; set; }

        public long? DISABILITY_TYPE_ID { get; set; }

        public long? DISABILITY_STATUS_ID { get; set; }

        [StringLength(4000)]
        public string REQUEST_AFTER_ASSESSMENT { get; set; }

        [StringLength(4000)]
        public string CONCLUSION { get; set; }

        [StringLength(200)]
        public string ASSESSMENT_BOARD_NAME { get; set; }

        public long? ASSESSMENT_TIME_TO { get; set; }

        [StringLength(4000)]
        public string ASSESSMENT_PURPOSE { get; set; }

        [StringLength(4000)]
        public string LEGAL_GROUND_DOCUMENTS { get; set; }

        [StringLength(4000)]
        public string ASSESSMENT_REQUEST_CONTENT { get; set; }

        [StringLength(4000)]
        public string PATHOLOGICAL_HISTORY { get; set; }

        [StringLength(4000)]
        public string DISCUSSION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ASSESSMENT_MEMBER> HIS_ASSESSMENT_MEMBER { get; set; }

        public virtual HIS_ASSESSMENT_OBJECT HIS_ASSESSMENT_OBJECT { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_ADR")]
    public partial class HIS_ADR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_ADR()
        {
            HIS_ADR_MEDICINE_TYPE = new HashSet<HIS_ADR_MEDICINE_TYPE>();
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
        [StringLength(10)]
        public string ADR_CODE { get; set; }

        public long TREATMENT_ID { get; set; }

        public long ADR_TIME { get; set; }

        [Required]
        [StringLength(50)]
        public string REPORT_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REPORT_USERNAME { get; set; }

        [StringLength(2000)]
        public string RELATED_TEST { get; set; }

        [StringLength(2000)]
        public string PATHOLOGICAL_HISTORY { get; set; }

        [StringLength(2000)]
        public string REACTION_METHOD { get; set; }

        [StringLength(4000)]
        public string DESCRIPTION { get; set; }

        [StringLength(100)]
        public string APPEAR_AFTER_TIME { get; set; }

        public short? SERIOUS_LEVEL { get; set; }

        public long? ADR_RESULT_ID { get; set; }

        public long? RELATIONSHIP_ID { get; set; }

        [StringLength(100)]
        public string RELATIONSHIP_ORTHER { get; set; }

        public long? EXPERTISE_STANDER_ID { get; set; }

        [StringLength(20)]
        public string EXPERTISE_STANDER_OTHER { get; set; }

        [StringLength(500)]
        public string BYT_COMMENT { get; set; }

        public decimal? WEIGHT { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ADR_MEDICINE_TYPE> HIS_ADR_MEDICINE_TYPE { get; set; }
    }
}

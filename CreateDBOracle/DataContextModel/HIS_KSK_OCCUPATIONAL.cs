namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_KSK_OCCUPATIONAL")]
    public partial class HIS_KSK_OCCUPATIONAL
    {
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

        public long SERVICE_REQ_ID { get; set; }

        public long? DHST_ID { get; set; }

        [StringLength(4000)]
        public string EXAM_CIRCULATION { get; set; }

        public long? EXAM_CIRCULATION_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_RESPIRATORY { get; set; }

        public long? EXAM_RESPIRATORY_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_DIGESTION { get; set; }

        public long? EXAM_DIGESTION_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_KIDNEY_UROLOGY { get; set; }

        public long? EXAM_KIDNEY_UROLOGY_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_NEUROLOGICAL { get; set; }

        public long? EXAM_NEUROLOGICAL_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_MUSCLE_BONE { get; set; }

        public long? EXAM_MUSCLE_BONE_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_ENT { get; set; }

        public long? EXAM_ENT_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_STOMATOLOGY { get; set; }

        public long? EXAM_STOMATOLOGY_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_EYE { get; set; }

        public long? EXAM_EYE_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_OEND { get; set; }

        public long? EXAM_OEND_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_MENTAL { get; set; }

        public long? EXAM_MENTAL_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_DERMATOLOGY { get; set; }

        public long? EXAM_DERMATOLOGY_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_SURGERY { get; set; }

        public long? EXAM_SURGERY_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_NAIL { get; set; }

        public long? EXAM_NAIL_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_MUCOSA { get; set; }

        public long? EXAM_MUCOSA_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_HEMATOPOIETIC { get; set; }

        public long? EXAM_HEMATOPOIETIC_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_MOTION { get; set; }

        public long? EXAM_MOTION_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_CARDIOVASCULAR { get; set; }

        public long? EXAM_CARDIOVASCULAR_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_LYMPH_NODES { get; set; }

        public long? EXAM_LYMPH_NODES_RANK { get; set; }

        [StringLength(4000)]
        public string EXAM_CAPILLARY { get; set; }

        public long? EXAM_CAPILLARY_RANK { get; set; }

        public long? HEALTH_EXAM_RANK_ID { get; set; }

        [StringLength(4000)]
        public string DISEASES { get; set; }

        [StringLength(4000)]
        public string TREATMENT_INSTRUCTION { get; set; }

        [StringLength(4000)]
        public string CONCLUSION { get; set; }

        public virtual HIS_DHST HIS_DHST { get; set; }

        public virtual HIS_SERVICE_REQ HIS_SERVICE_REQ { get; set; }
    }
}

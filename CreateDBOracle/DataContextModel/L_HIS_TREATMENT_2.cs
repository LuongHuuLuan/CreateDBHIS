namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.L_HIS_TREATMENT_2")]
    public partial class L_HIS_TREATMENT_2
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string TREATMENT_CODE { get; set; }

        public long? TDL_PATIENT_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PATIENT_ID { get; set; }

        [StringLength(20)]
        public string HRM_KSK_CODE { get; set; }

        [StringLength(10)]
        public string ICD_CODE { get; set; }

        [StringLength(500)]
        public string ICD_NAME { get; set; }

        [StringLength(10)]
        public string ICD_CAUSE_CODE { get; set; }

        [StringLength(500)]
        public string ICD_CAUSE_NAME { get; set; }

        public short? IS_PAUSE { get; set; }

        public short? IS_CHRONIC { get; set; }

        [StringLength(500)]
        public string ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string ICD_TEXT { get; set; }

        [StringLength(200)]
        public string HOSPITALIZATION_REASON { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IN_TIME { get; set; }

        public long? OUT_TIME { get; set; }

        public long? TREATMENT_RESULT_ID { get; set; }

        public long? IN_TREATMENT_TYPE_ID { get; set; }

        public long? TDL_FIRST_EXAM_ROOM_ID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        public short? NEED_SICK_LEAVE_CERT { get; set; }

        [StringLength(500)]
        public string CONTRAINDICATION_IDS { get; set; }

        [StringLength(3000)]
        public string PT_PATHOLOGICAL_HISTORY_FAMILY { get; set; }

        [StringLength(3000)]
        public string PT_PATHOLOGICAL_HISTORY { get; set; }
    }
}

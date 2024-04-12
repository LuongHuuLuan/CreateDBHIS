namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_SERE_SERV_PTTT_1")]
    public partial class V_HIS_SERE_SERV_PTTT_1
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

        public long SERE_SERV_ID { get; set; }

        public long? PTTT_GROUP_ID { get; set; }

        public long? PTTT_METHOD_ID { get; set; }

        public long? PTTT_CONDITION_ID { get; set; }

        public long? PTTT_CATASTROPHE_ID { get; set; }

        public long? PTTT_HIGH_TECH_ID { get; set; }

        public long? PTTT_PRIORITY_ID { get; set; }

        public long? PTTT_TABLE_ID { get; set; }

        public long? EMOTIONLESS_METHOD_ID { get; set; }

        public long? EMOTIONLESS_METHOD_SECOND_ID { get; set; }

        public long? EMOTIONLESS_RESULT_ID { get; set; }

        [StringLength(10)]
        public string ICD_CODE { get; set; }

        [StringLength(500)]
        public string ICD_NAME { get; set; }

        [StringLength(500)]
        public string ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string ICD_TEXT { get; set; }

        [StringLength(10)]
        public string BEFORE_PTTT_ICD_CODE { get; set; }

        [StringLength(500)]
        public string BEFORE_PTTT_ICD_NAME { get; set; }

        [StringLength(10)]
        public string AFTER_PTTT_ICD_CODE { get; set; }

        [StringLength(500)]
        public string AFTER_PTTT_ICD_NAME { get; set; }

        public long? BLOOD_ABO_ID { get; set; }

        public long? BLOOD_RH_ID { get; set; }

        public long? DEATH_WITHIN_ID { get; set; }

        [StringLength(3000)]
        public string MANNER { get; set; }

        public long? TDL_TREATMENT_ID { get; set; }

        public long? ICD_ID__DELETE { get; set; }

        public long? BEFORE_PTTT_ICD_ID__DELETE { get; set; }

        [StringLength(500)]
        public string BEFORE_PTTT_ICD_TEXT__DELETE { get; set; }

        public long? AFTER_PTTT_ICD_ID__DELETE { get; set; }

        [StringLength(500)]
        public string AFTER_PTTT_ICD_TEXT__DELETE { get; set; }

        public long? REAL_PTTT_METHOD_ID { get; set; }

        public long? EYE_SURGRY_DESC_ID { get; set; }

        public long? SURGERY_POSITION_ID { get; set; }

        public long? SKIN_SURGERY_DESC_ID { get; set; }

        [StringLength(10)]
        public string ICD_CM_CODE { get; set; }

        [StringLength(500)]
        public string ICD_CM_NAME { get; set; }

        [StringLength(500)]
        public string ICD_CM_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string ICD_CM_TEXT { get; set; }

        [StringLength(2)]
        public string PTTT_GROUP_CODE { get; set; }

        [StringLength(100)]
        public string PTTT_GROUP_NAME { get; set; }

        public long? NUM_ORDER { get; set; }

        public long? INTRUCTION_DATE { get; set; }

        public long? SERVICE_TYPE_ID { get; set; }

        [StringLength(2)]
        public string SERVICE_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string SERVICE_TYPE_NAME { get; set; }
    }
}

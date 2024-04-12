namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SERE_SERV_PTTT")]
    public partial class HIS_SERE_SERV_PTTT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_SERE_SERV_PTTT()
        {
            HIS_SESE_PTTT_METHOD = new HashSet<HIS_SESE_PTTT_METHOD>();
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

        [StringLength(1000)]
        public string WICK { get; set; }

        [StringLength(1000)]
        public string DRAINAGE { get; set; }

        public long? DRAW_DATE { get; set; }

        public long? CUT_SEWING_DATE { get; set; }

        [StringLength(500)]
        public string OTHER { get; set; }

        [StringLength(20)]
        public string PARTICIPANT_NUMBER { get; set; }

        [StringLength(500)]
        public string PCI { get; set; }

        [StringLength(500)]
        public string STENTING { get; set; }

        [StringLength(200)]
        public string LOCATION_INTERVENTION { get; set; }

        [StringLength(1000)]
        public string REASON_INTERVENTION { get; set; }

        [StringLength(1000)]
        public string INTRODUCER { get; set; }

        [StringLength(1000)]
        public string GUIDING_CATHETER { get; set; }

        [StringLength(1000)]
        public string GUITE_WIRE { get; set; }

        [StringLength(1000)]
        public string BALLON { get; set; }

        [StringLength(1000)]
        public string STENT { get; set; }

        [StringLength(1000)]
        public string CONTRAST_AGENT { get; set; }

        [StringLength(1000)]
        public string INSTRUMENTS_OTHER { get; set; }

        [StringLength(1000)]
        public string STENT_NOTE { get; set; }

        public virtual HIS_BLOOD_ABO HIS_BLOOD_ABO { get; set; }

        public virtual HIS_BLOOD_RH HIS_BLOOD_RH { get; set; }

        public virtual HIS_EMOTIONLESS_METHOD HIS_EMOTIONLESS_METHOD { get; set; }

        public virtual HIS_EMOTIONLESS_METHOD HIS_EMOTIONLESS_METHOD1 { get; set; }

        public virtual HIS_EMOTIONLESS_RESULT HIS_EMOTIONLESS_RESULT { get; set; }

        public virtual HIS_EYE_SURGRY_DESC HIS_EYE_SURGRY_DESC { get; set; }

        public virtual HIS_PTTT_CATASTROPHE HIS_PTTT_CATASTROPHE { get; set; }

        public virtual HIS_PTTT_CONDITION HIS_PTTT_CONDITION { get; set; }

        public virtual HIS_PTTT_GROUP HIS_PTTT_GROUP { get; set; }

        public virtual HIS_PTTT_HIGH_TECH HIS_PTTT_HIGH_TECH { get; set; }

        public virtual HIS_PTTT_METHOD HIS_PTTT_METHOD { get; set; }

        public virtual HIS_PTTT_METHOD HIS_PTTT_METHOD1 { get; set; }

        public virtual HIS_PTTT_PRIORITY HIS_PTTT_PRIORITY { get; set; }

        public virtual HIS_PTTT_TABLE HIS_PTTT_TABLE { get; set; }

        public virtual HIS_SERE_SERV HIS_SERE_SERV { get; set; }

        public virtual HIS_SKIN_SURGERY_DESC HIS_SKIN_SURGERY_DESC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SESE_PTTT_METHOD> HIS_SESE_PTTT_METHOD { get; set; }
    }
}

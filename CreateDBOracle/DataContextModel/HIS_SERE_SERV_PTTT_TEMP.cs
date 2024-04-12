namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SERE_SERV_PTTT_TEMP")]
    public partial class HIS_SERE_SERV_PTTT_TEMP
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

        public long? BLOOD_ABO_ID { get; set; }

        public long? BLOOD_RH_ID { get; set; }

        public long? DEATH_WITHIN_ID { get; set; }

        [StringLength(3000)]
        public string MANNER { get; set; }

        public long? REAL_PTTT_METHOD_ID { get; set; }

        public short? IS_PUBLIC { get; set; }

        public short? IS_PUBLIC_IN_DEPARTMENT { get; set; }

        public long? DEPARTMENT_ID { get; set; }

        [StringLength(4000)]
        public string CONCLUDE { get; set; }

        [StringLength(4000)]
        public string DESCRIPTION { get; set; }

        [StringLength(3000)]
        public string NOTE { get; set; }

        [Required]
        [StringLength(50)]
        public string SERE_SERV_PTTT_TEMP_CODE { get; set; }

        [StringLength(500)]
        public string SERE_SERV_PTTT_TEMP_NAME { get; set; }

        public virtual HIS_BLOOD_ABO HIS_BLOOD_ABO { get; set; }

        public virtual HIS_BLOOD_RH HIS_BLOOD_RH { get; set; }

        public virtual HIS_DEATH_WITHIN HIS_DEATH_WITHIN { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        public virtual HIS_EMOTIONLESS_METHOD HIS_EMOTIONLESS_METHOD { get; set; }

        public virtual HIS_EMOTIONLESS_METHOD HIS_EMOTIONLESS_METHOD1 { get; set; }

        public virtual HIS_EMOTIONLESS_RESULT HIS_EMOTIONLESS_RESULT { get; set; }

        public virtual HIS_PTTT_CATASTROPHE HIS_PTTT_CATASTROPHE { get; set; }

        public virtual HIS_PTTT_CONDITION HIS_PTTT_CONDITION { get; set; }

        public virtual HIS_PTTT_GROUP HIS_PTTT_GROUP { get; set; }

        public virtual HIS_PTTT_HIGH_TECH HIS_PTTT_HIGH_TECH { get; set; }

        public virtual HIS_PTTT_METHOD HIS_PTTT_METHOD { get; set; }

        public virtual HIS_PTTT_METHOD HIS_PTTT_METHOD1 { get; set; }

        public virtual HIS_PTTT_PRIORITY HIS_PTTT_PRIORITY { get; set; }

        public virtual HIS_PTTT_TABLE HIS_PTTT_TABLE { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_ICD")]
    public partial class V_HIS_ICD
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

        [Required]
        [StringLength(10)]
        public string ICD_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string ICD_NAME { get; set; }

        [StringLength(500)]
        public string ICD_NAME_EN { get; set; }

        [StringLength(7)]
        public string CHAPTER_CODE { get; set; }

        [StringLength(500)]
        public string CHAPTER_NAME { get; set; }

        [StringLength(500)]
        public string CHAPTER_NAME_EN { get; set; }

        [StringLength(7)]
        public string SUB_CODE { get; set; }

        [StringLength(500)]
        public string SUB_NAME { get; set; }

        [StringLength(500)]
        public string SUB_NAME_EN { get; set; }

        [StringLength(7)]
        public string SUB_CODE_1 { get; set; }

        [StringLength(500)]
        public string SUB_NAME_1 { get; set; }

        [StringLength(500)]
        public string SUB_NAME_1_EN { get; set; }

        [StringLength(7)]
        public string SUB_CODE_2 { get; set; }

        [StringLength(500)]
        public string SUB_NAME_2 { get; set; }

        [StringLength(500)]
        public string SUB_NAME_2_EN { get; set; }

        [StringLength(3)]
        public string TYPE_CODE { get; set; }

        [StringLength(500)]
        public string TYPE_NAME { get; set; }

        [StringLength(500)]
        public string TYPE_NAME_EN { get; set; }

        [StringLength(3)]
        public string BYT_REPORT_CODE { get; set; }

        [StringLength(500)]
        public string ICD_NAME_COMMON { get; set; }

        public long? ICD_CHAPTER_ID { get; set; }

        public long? ICD_GROUP_ID { get; set; }

        public short? IS_HEIN_NDS { get; set; }

        public short? IS_REQUIRE_CAUSE { get; set; }

        public short? IS_CAUSE { get; set; }

        public short? IS_TRADITIONAL { get; set; }

        public short? UNABLE_FOR_TREATMENT { get; set; }

        public short? IS_LATENT_TUBERCULOSIS { get; set; }

        public short? DO_NOT_USE_HEIN { get; set; }

        public long? GENDER_ID { get; set; }

        [StringLength(4000)]
        public string ATTACH_ICD_CODES { get; set; }

        public long? AGE_FROM { get; set; }

        public long? AGE_TO { get; set; }

        public long? AGE_TYPE_ID { get; set; }

        public short? IS_SUBCODE { get; set; }

        public short? IS_SWORD { get; set; }

        public short? IS_COVID { get; set; }

        [StringLength(2)]
        public string GENDER_CODE { get; set; }

        [StringLength(100)]
        public string GENDER_NAME { get; set; }

        [StringLength(10)]
        public string AGE_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string AGE_TYPE_NAME { get; set; }
    }
}

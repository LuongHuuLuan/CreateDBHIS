namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_EXME_REASON_CFG")]
    public partial class V_HIS_EXME_REASON_CFG
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

        public long EXP_MEST_REASON_ID { get; set; }

        public long PATIENT_CLASSIFY_ID { get; set; }

        public long TREATMENT_TYPE_ID { get; set; }

        public long? PATIENT_TYPE_ID { get; set; }

        public long? OTHER_PAY_SOURCE_ID { get; set; }

        [Required]
        [StringLength(2)]
        public string EXP_MEST_REASON_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string EXP_MEST_REASON_NAME { get; set; }

        [Required]
        [StringLength(10)]
        public string PATIENT_CLASSIFY_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string PATIENT_CLASSIFY_NAME { get; set; }

        [Required]
        [StringLength(2)]
        public string TREATMENT_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string TREATMENT_TYPE_NAME { get; set; }

        [StringLength(6)]
        public string PATIENT_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string PATIENT_TYPE_NAME { get; set; }

        [StringLength(20)]
        public string OTHER_PAY_SOURCE_CODE { get; set; }

        [StringLength(200)]
        public string OTHER_PAY_SOURCE_NAME { get; set; }
    }
}

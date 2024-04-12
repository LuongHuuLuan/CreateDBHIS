namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_DEPARTMENT_1")]
    public partial class V_HIS_DEPARTMENT_1
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
        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        public long BRANCH_ID { get; set; }

        [StringLength(50)]
        public string BHYT_CODE { get; set; }

        public long? NUM_ORDER { get; set; }

        public short? IS_AUTO_RECEIVE_PATIENT { get; set; }

        public short? IS_CLINICAL { get; set; }

        public long? THEORY_PATIENT_COUNT { get; set; }

        public long? REALITY_PATIENT_COUNT { get; set; }

        [Required]
        [StringLength(10)]
        public string G_CODE { get; set; }

        public long? DEFAULT_INSTR_PATIENT_TYPE_ID { get; set; }

        public short? ALLOW_ASSIGN_SURGERY_PRICE { get; set; }

        public decimal? ALLOW_ASSIGN_PACKAGE_PRICE { get; set; }

        [StringLength(20)]
        public string ALLOW_TREATMENT_TYPE_IDS { get; set; }

        public long? REQ_SURG_TREATMENT_TYPE_ID { get; set; }

        [StringLength(50)]
        public string PHONE { get; set; }

        public short? IS_EMERGENCY { get; set; }

        public short? IS_EXAM { get; set; }

        [StringLength(50)]
        public string HEAD_LOGINNAME { get; set; }

        [StringLength(100)]
        public string HEAD_USERNAME { get; set; }

        public short? IS_IN_DEP_STOCK_MOBA { get; set; }

        public long? AUTO_BED_ASSIGN_OPTION { get; set; }

        [StringLength(4000)]
        public string ACCEPTED_ICD_CODES { get; set; }

        [Required]
        [StringLength(20)]
        public string BRANCH_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string BRANCH_NAME { get; set; }

        [StringLength(6)]
        public string HEIN_MEDI_ORG_CODE { get; set; }

        [StringLength(4000)]
        public string ACCEPT_HEIN_MEDI_ORG_CODE { get; set; }

        [StringLength(500)]
        public string ADDRESS { get; set; }

        [StringLength(100)]
        public string PARENT_ORGANIZATION_NAME { get; set; }

        [StringLength(2)]
        public string HEIN_PROVINCE_CODE { get; set; }

        [StringLength(1)]
        public string HEIN_LEVEL_CODE { get; set; }

        public decimal? PATIENT_COUNT { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_KSK_CONTRACT")]
    public partial class V_HIS_KSK_CONTRACT
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
        public string KSK_CONTRACT_CODE { get; set; }

        public long WORK_PLACE_ID { get; set; }

        public long? CONTRACT_DATE { get; set; }

        public long? EFFECT_DATE { get; set; }

        public long? EXPIRY_DATE { get; set; }

        public decimal? CONTRACT_VALUE { get; set; }

        public decimal? DEPOSIT_AMOUNT { get; set; }

        public decimal PAYMENT_RATIO { get; set; }

        public short? IS_REQUIRED_APPROVAL { get; set; }

        public short? IS_RESTRICTED { get; set; }

        public long? DEPARTMENT_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string WORK_PLACE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string WORK_PLACE_NAME { get; set; }

        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }
    }
}

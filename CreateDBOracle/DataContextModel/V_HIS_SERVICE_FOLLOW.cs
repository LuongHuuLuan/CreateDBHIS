namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_SERVICE_FOLLOW")]
    public partial class V_HIS_SERVICE_FOLLOW
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

        public long SERVICE_ID { get; set; }

        public long FOLLOW_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public short? IS_EXPEND { get; set; }

        public decimal? CONDITIONED_AMOUNT { get; set; }

        [StringLength(100)]
        public string TREATMENT_TYPE_IDS { get; set; }

        [Required]
        [StringLength(25)]
        public string SERVICE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string SERVICE_NAME { get; set; }

        public long SERVICE_TYPE_ID { get; set; }

        [StringLength(3)]
        public string SPECIALITY_CODE { get; set; }

        [Required]
        [StringLength(2)]
        public string SERVICE_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_TYPE_NAME { get; set; }

        [Required]
        [StringLength(25)]
        public string FOLLOW_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string FOLLOW_NAME { get; set; }

        public long FOLLOW_TYPE_ID { get; set; }

        [Required]
        [StringLength(2)]
        public string FOLLOW_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string FOLLOW_TYPE_NAME { get; set; }
    }
}

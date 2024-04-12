namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HTC_REPARTITION_RATIO")]
    public partial class V_HTC_REPARTITION_RATIO
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

        public long PERIOD_ID { get; set; }

        public long REPARTITION_TYPE_ID { get; set; }

        public decimal RATIO { get; set; }

        [Required]
        [StringLength(10)]
        public string DEPARTMENT_CODE { get; set; }

        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        [Required]
        [StringLength(2)]
        public string REPARTITION_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string REPARTITION_TYPE_NAME { get; set; }

        [Required]
        [StringLength(6)]
        public string PERIOD_CODE { get; set; }

        [StringLength(100)]
        public string PERIOD_NAME { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HTC_EXPENSE")]
    public partial class V_HTC_EXPENSE
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
        [StringLength(6)]
        public string EXPENSE_CODE { get; set; }

        public long EXPENSE_TIME { get; set; }

        public long EXPENSE_TYPE_ID { get; set; }

        public decimal PRICE { get; set; }

        public long PERIOD_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string DEPARTMENT_CODE { get; set; }

        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        [Required]
        [StringLength(6)]
        public string EXPENSE_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string EXPENSE_TYPE_NAME { get; set; }

        public long? PARENT_ID { get; set; }

        public short? IS_ALLOW_EXPENSE { get; set; }

        public short? IS_PLUS { get; set; }

        [Required]
        [StringLength(6)]
        public string PERIOD_CODE { get; set; }

        public long? FROM_TIME { get; set; }

        public long? TO_TIME { get; set; }

        [StringLength(100)]
        public string PERIOD_NAME { get; set; }
    }
}

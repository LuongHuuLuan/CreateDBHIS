namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HTC_EXPENSE")]
    public partial class HTC_EXPENSE
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

        public virtual HTC_EXPENSE_TYPE HTC_EXPENSE_TYPE { get; set; }

        public virtual HTC_PERIOD HTC_PERIOD { get; set; }
    }
}

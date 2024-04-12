namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_FINANCE_PERIOD")]
    public partial class HIS_FINANCE_PERIOD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_FINANCE_PERIOD()
        {
            HIS_FINANCE_PERIOD1 = new HashSet<HIS_FINANCE_PERIOD>();
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

        public long? PREVIOUS_ID { get; set; }

        public long PERIOD_TIME { get; set; }

        public long? TOTAL_LOCK_HEIN { get; set; }

        public long? TOTAL_LOCK_FEE { get; set; }

        public long? TOTAL_TRANSACTION { get; set; }

        public decimal? TOTAL_DEPOSIT { get; set; }

        public decimal? TOTAL_REPAY_AMOUNT { get; set; }

        public decimal? TOTAL_BILL_AMOUNT { get; set; }

        public decimal? TOTAL_BILL_TRANSFER_AMOUNT { get; set; }

        public decimal? TOTAL_BILL_EXEMPTION { get; set; }

        public long? TOTAL_BILL_FUND { get; set; }

        public long BRANCH_ID { get; set; }

        public virtual HIS_BRANCH HIS_BRANCH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_FINANCE_PERIOD> HIS_FINANCE_PERIOD1 { get; set; }

        public virtual HIS_FINANCE_PERIOD HIS_FINANCE_PERIOD2 { get; set; }
    }
}

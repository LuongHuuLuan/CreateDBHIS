namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HTC_PERIOD")]
    public partial class HTC_PERIOD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HTC_PERIOD()
        {
            HTC_EXPENSE = new HashSet<HTC_EXPENSE>();
            HTC_PERIOD_DEPARTMENT = new HashSet<HTC_PERIOD_DEPARTMENT>();
            HTC_REPARTITION_RATIO = new HashSet<HTC_REPARTITION_RATIO>();
            HTC_REVENUE = new HashSet<HTC_REVENUE>();
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

        [Required]
        [StringLength(6)]
        public string PERIOD_CODE { get; set; }

        public long? FROM_TIME { get; set; }

        public long? TO_TIME { get; set; }

        [StringLength(100)]
        public string PERIOD_NAME { get; set; }

        public short? YEAR { get; set; }

        public short? MONTH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HTC_EXPENSE> HTC_EXPENSE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HTC_PERIOD_DEPARTMENT> HTC_PERIOD_DEPARTMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HTC_REPARTITION_RATIO> HTC_REPARTITION_RATIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HTC_REVENUE> HTC_REVENUE { get; set; }
    }
}

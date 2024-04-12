namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HTC_EXPENSE_TYPE")]
    public partial class HTC_EXPENSE_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HTC_EXPENSE_TYPE()
        {
            HTC_EXPENSE = new HashSet<HTC_EXPENSE>();
            HTC_EXPENSE_TYPE1 = new HashSet<HTC_EXPENSE_TYPE>();
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
        public string EXPENSE_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string EXPENSE_TYPE_NAME { get; set; }

        public long? PARENT_ID { get; set; }

        public short? IS_ALLOW_EXPENSE { get; set; }

        public short? IS_PLUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HTC_EXPENSE> HTC_EXPENSE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HTC_EXPENSE_TYPE> HTC_EXPENSE_TYPE1 { get; set; }

        public virtual HTC_EXPENSE_TYPE HTC_EXPENSE_TYPE2 { get; set; }
    }
}

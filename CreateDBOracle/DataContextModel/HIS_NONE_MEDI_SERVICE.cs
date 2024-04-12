namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_NONE_MEDI_SERVICE")]
    public partial class HIS_NONE_MEDI_SERVICE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_NONE_MEDI_SERVICE()
        {
            HIS_BILL_GOODS = new HashSet<HIS_BILL_GOODS>();
            HIS_DEBT_GOODS = new HashSet<HIS_DEBT_GOODS>();
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
        [StringLength(10)]
        public string NONE_MEDI_SERVICE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string NONE_MEDI_SERVICE_NAME { get; set; }

        public decimal? PRICE { get; set; }

        public long SERVICE_UNIT_ID { get; set; }

        public long? NUM_ORDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BILL_GOODS> HIS_BILL_GOODS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEBT_GOODS> HIS_DEBT_GOODS { get; set; }

        public virtual HIS_SERVICE_UNIT HIS_SERVICE_UNIT { get; set; }
    }
}

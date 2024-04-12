namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_NUM_ORDER_BLOCK")]
    public partial class HIS_NUM_ORDER_BLOCK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_NUM_ORDER_BLOCK()
        {
            HIS_NUM_ORDER_ISSUE = new HashSet<HIS_NUM_ORDER_ISSUE>();
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

        public long ROOM_TIME_ID { get; set; }

        [Required]
        [StringLength(6)]
        public string FROM_TIME { get; set; }

        [Required]
        [StringLength(6)]
        public string TO_TIME { get; set; }

        public long NUM_ORDER { get; set; }

        public virtual HIS_ROOM_TIME HIS_ROOM_TIME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_NUM_ORDER_ISSUE> HIS_NUM_ORDER_ISSUE { get; set; }
    }
}

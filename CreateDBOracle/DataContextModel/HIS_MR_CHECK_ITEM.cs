namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_MR_CHECK_ITEM")]
    public partial class HIS_MR_CHECK_ITEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_MR_CHECK_ITEM()
        {
            HIS_MR_CHECKLIST = new HashSet<HIS_MR_CHECKLIST>();
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
        [StringLength(200)]
        public string CHECK_ITEM_NAME { get; set; }

        public long CHECK_ITEM_TYPE_ID { get; set; }

        public long? NUM_ORDER { get; set; }

        [StringLength(4000)]
        public string EMR_COVER_TYPE_IDS { get; set; }

        public virtual HIS_MR_CHECK_ITEM_TYPE HIS_MR_CHECK_ITEM_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MR_CHECKLIST> HIS_MR_CHECKLIST { get; set; }
    }
}

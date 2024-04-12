namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_MEDICINE_GROUP")]
    public partial class HIS_MEDICINE_GROUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_MEDICINE_GROUP()
        {
            HIS_MEDICINE_TYPE = new HashSet<HIS_MEDICINE_TYPE>();
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
        [StringLength(4)]
        public string MEDICINE_GROUP_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string MEDICINE_GROUP_NAME { get; set; }

        public long? NUM_ORDER { get; set; }

        public short? IS_SEPARATE_PRINTING { get; set; }

        public short? IS_NUMBERED_TRACKING { get; set; }

        public short? IS_WARNING { get; set; }

        public long? NUMBER_DAY { get; set; }

        public short? IS_AUTO_TREATMENT_DAY_COUNT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICINE_TYPE> HIS_MEDICINE_TYPE { get; set; }
    }
}

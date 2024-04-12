namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SURG_REMUNERATION")]
    public partial class HIS_SURG_REMUNERATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_SURG_REMUNERATION()
        {
            HIS_SURG_REMU_DETAIL = new HashSet<HIS_SURG_REMU_DETAIL>();
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

        [StringLength(50)]
        public string SURG_REMUNERATION_CODE { get; set; }

        [StringLength(200)]
        public string SURG_REMUNERATION_NAME { get; set; }

        public long PTTT_GROUP_ID { get; set; }

        public long? EMOTIONLESS_METHOD_ID { get; set; }

        public long? NUMBER_OF_PEOPLE { get; set; }

        public long SERVICE_TYPE_ID { get; set; }

        public long? SURG_FROM_TIME { get; set; }

        public long? SURG_TO_TIME { get; set; }

        public virtual HIS_EMOTIONLESS_METHOD HIS_EMOTIONLESS_METHOD { get; set; }

        public virtual HIS_PTTT_GROUP HIS_PTTT_GROUP { get; set; }

        public virtual HIS_SERVICE_TYPE HIS_SERVICE_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SURG_REMU_DETAIL> HIS_SURG_REMU_DETAIL { get; set; }
    }
}

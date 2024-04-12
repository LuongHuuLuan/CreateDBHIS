namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_BED_LOG")]
    public partial class HIS_BED_LOG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_BED_LOG()
        {
            HIS_SERE_SERV_EXT = new HashSet<HIS_SERE_SERV_EXT>();
            HIS_SERVICE_REQ1 = new HashSet<HIS_SERVICE_REQ>();
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

        public long TREATMENT_BED_ROOM_ID { get; set; }

        public long BED_ID { get; set; }

        public long START_TIME { get; set; }

        public long? FINISH_TIME { get; set; }

        public long? BED_SERVICE_TYPE_ID { get; set; }

        public long? SERVICE_REQ_ID { get; set; }

        public long? SHARE_COUNT { get; set; }

        public long? PATIENT_TYPE_ID { get; set; }

        public long? PRIMARY_PATIENT_TYPE_ID { get; set; }

        public short? IS_SERVICE_REQ_ASSIGNED { get; set; }

        public virtual HIS_BED HIS_BED { get; set; }

        public virtual HIS_TREATMENT_BED_ROOM HIS_TREATMENT_BED_ROOM { get; set; }

        public virtual HIS_SERVICE HIS_SERVICE { get; set; }

        public virtual HIS_PATIENT_TYPE HIS_PATIENT_TYPE { get; set; }

        public virtual HIS_SERVICE_REQ HIS_SERVICE_REQ { get; set; }

        public virtual HIS_PATIENT_TYPE HIS_PATIENT_TYPE1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_EXT> HIS_SERE_SERV_EXT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_REQ> HIS_SERVICE_REQ1 { get; set; }
    }
}

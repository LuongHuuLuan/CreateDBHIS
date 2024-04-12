namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_TREATMENT_BED_ROOM")]
    public partial class HIS_TREATMENT_BED_ROOM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_TREATMENT_BED_ROOM()
        {
            HIS_BED_LOG = new HashSet<HIS_BED_LOG>();
            HIS_PATIENT_OBSERVATION = new HashSet<HIS_PATIENT_OBSERVATION>();
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

        public long TREATMENT_ID { get; set; }

        public long BED_ROOM_ID { get; set; }

        [StringLength(50)]
        public string ADD_LOGINNAME { get; set; }

        [StringLength(100)]
        public string ADD_USERNAME { get; set; }

        public long ADD_TIME { get; set; }

        [StringLength(50)]
        public string REMOVE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REMOVE_USERNAME { get; set; }

        public long? REMOVE_TIME { get; set; }

        public long? BED_ID { get; set; }

        public long? CO_TREATMENT_ID { get; set; }

        public long? TREATMENT_ROOM_ID { get; set; }

        public long? TDL_OBSERVED_TIME_FROM { get; set; }

        public long? TDL_OBSERVED_TIME_TO { get; set; }

        public virtual HIS_BED HIS_BED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BED_LOG> HIS_BED_LOG { get; set; }

        public virtual HIS_BED_ROOM HIS_BED_ROOM { get; set; }

        public virtual HIS_CO_TREATMENT HIS_CO_TREATMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PATIENT_OBSERVATION> HIS_PATIENT_OBSERVATION { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }
    }
}

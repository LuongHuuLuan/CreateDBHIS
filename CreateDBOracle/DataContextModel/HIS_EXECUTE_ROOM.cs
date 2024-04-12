namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_EXECUTE_ROOM")]
    public partial class HIS_EXECUTE_ROOM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_EXECUTE_ROOM()
        {
            HIS_EXRO_ROOM = new HashSet<HIS_EXRO_ROOM>();
            HIS_PTTT_TABLE = new HashSet<HIS_PTTT_TABLE>();
            HIS_SARO_EXRO = new HashSet<HIS_SARO_EXRO>();
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
        [StringLength(20)]
        public string EXECUTE_ROOM_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string EXECUTE_ROOM_NAME { get; set; }

        public long ROOM_ID { get; set; }

        public short? IS_EXAM { get; set; }

        public short? IS_EMERGENCY { get; set; }

        public short? IS_VITAMIN_A { get; set; }

        public short? IS_VACCINE { get; set; }

        public short? IS_SPECIALITY { get; set; }

        public short? IS_SURGERY { get; set; }

        public short? IS_PRIORITIZE { get; set; }

        public short? IS_PAUSE_ENCLITIC { get; set; }

        public long? MAX_REQUEST_BY_DAY { get; set; }

        public long? MAX_REQ_BHYT_BY_DAY { get; set; }

        public long? NUM_ORDER { get; set; }

        public long? AVERAGE_ETA { get; set; }

        public long? KIDNEY_SHIFT_COUNT { get; set; }

        public short? IS_KIDNEY { get; set; }

        [StringLength(20)]
        public string TEST_TYPE_CODE { get; set; }

        public long? MAX_APPOINTMENT_BY_DAY { get; set; }

        public short? IS_TEST { get; set; }

        public short? IS_AUTO_EXPEND_ADD_EXAM { get; set; }

        public long? MAX_PATIENT_BY_DAY { get; set; }

        public short? ALLOW_NOT_CHOOSE_SERVICE { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXRO_ROOM> HIS_EXRO_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PTTT_TABLE> HIS_PTTT_TABLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SARO_EXRO> HIS_SARO_EXRO { get; set; }
    }
}

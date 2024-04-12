namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.LIS_SAMPLE_SERVICE")]
    public partial class LIS_SAMPLE_SERVICE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LIS_SAMPLE_SERVICE()
        {
            LIS_RESULT = new HashSet<LIS_RESULT>();
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

        public long SAMPLE_ID { get; set; }

        [Required]
        [StringLength(25)]
        public string SERVICE_CODE { get; set; }

        [StringLength(500)]
        public string SERVICE_NAME { get; set; }

        public long SAMPLE_SERVICE_STT_ID { get; set; }

        public short? IS_NO_EXECUTE { get; set; }

        public long? SERVICE_NUM_ORDER { get; set; }

        public short? MAX_TIME_RETURN_RESULT { get; set; }

        public short? IS_RUN_AGAIN { get; set; }

        public short? IS_RUNNING { get; set; }

        public long? MACHINE_ID { get; set; }

        public short? BACTERIAL_CULTIVATION_RESULT { get; set; }

        public virtual LIS_MACHINE LIS_MACHINE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIS_RESULT> LIS_RESULT { get; set; }

        public virtual LIS_SAMPLE LIS_SAMPLE { get; set; }

        public virtual LIS_SAMPLE_SERVICE_STT LIS_SAMPLE_SERVICE_STT { get; set; }
    }
}

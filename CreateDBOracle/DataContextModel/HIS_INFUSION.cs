namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_INFUSION")]
    public partial class HIS_INFUSION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_INFUSION()
        {
            HIS_MIXED_MEDICINE = new HashSet<HIS_MIXED_MEDICINE>();
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

        public long INFUSION_SUM_ID { get; set; }

        public long? MEDICINE_ID { get; set; }

        public long? SERVICE_UNIT_ID { get; set; }

        public long? START_TIME { get; set; }

        public long? FINISH_TIME { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal? SPEED { get; set; }

        [StringLength(50)]
        public string REQUEST_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REQUEST_USERNAME { get; set; }

        [StringLength(50)]
        public string EXECUTE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string EXECUTE_USERNAME { get; set; }

        [StringLength(1000)]
        public string NOTE { get; set; }

        [Required]
        [StringLength(500)]
        public string MEDICINE_TYPE_NAME { get; set; }

        [StringLength(100)]
        public string PACKAGE_NUMBER { get; set; }

        public long? EXPIRED_DATE { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        public long? SPEED_UNIT_ID { get; set; }

        public decimal? VOLUME { get; set; }

        public decimal? CONVERT_TIME_RATIO { get; set; }

        public decimal? CONVERT_VOLUME_RATIO { get; set; }

        [StringLength(500)]
        public string MIXED_MEDICINE { get; set; }

        public long? EMR_DOCUMENT_STT_ID { get; set; }

        [StringLength(1000)]
        public string EMR_DOCUMENT_URL { get; set; }

        [StringLength(15)]
        public string EMR_DOCUMENT_CODE { get; set; }

        public virtual HIS_SERVICE_UNIT HIS_SERVICE_UNIT { get; set; }

        public virtual HIS_MEDICINE HIS_MEDICINE { get; set; }

        public virtual HIS_INFUSION_SUM HIS_INFUSION_SUM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MIXED_MEDICINE> HIS_MIXED_MEDICINE { get; set; }
    }
}

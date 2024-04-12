namespace CreateDBOracle.ContextCodeFirstModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.SAR_REPORT")]
    public partial class SAR_REPORT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SAR_REPORT()
        {
            SAR_REPORT_CALENDAR = new HashSet<SAR_REPORT_CALENDAR>();
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
        public string REPORT_CODE { get; set; }

        [StringLength(200)]
        public string REPORT_NAME { get; set; }

        public long REPORT_TYPE_ID { get; set; }

        public long REPORT_STT_ID { get; set; }

        public long? REPORT_TEMPLATE_ID { get; set; }

        public short? IS_PUBLIC { get; set; }

        [StringLength(2000)]
        public string REPORT_URL { get; set; }

        public short? IS_URL_ERROR { get; set; }

        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        public long? START_TIME { get; set; }

        public long? FINISH_QUERY_TIME { get; set; }

        public long? START_PREPARE_DATA_TIME { get; set; }

        public long? FINISH_PREPARE_DATA_TIME { get; set; }

        public long? START_GENERATE_FILE_TIME { get; set; }

        public long? FINISH_TIME { get; set; }

        public string JSON_FILTER { get; set; }

        [StringLength(4000)]
        public string JSON_READER { get; set; }

        public decimal? VIR_TOTAL_TIME { get; set; }

        public decimal? VIR_QUERY_TIME { get; set; }

        public decimal? VIR_PREPARE_DATA_TIME { get; set; }

        public decimal? VIR_GENERATE_FILE_TIME { get; set; }

        [StringLength(2000)]
        public string REPORT_URL_PDF { get; set; }

        [StringLength(500)]
        public string ERROR { get; set; }

        public short? IS_REFERENCE_TESTING { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAR_REPORT_CALENDAR> SAR_REPORT_CALENDAR { get; set; }

        public virtual SAR_REPORT_STT SAR_REPORT_STT { get; set; }

        public virtual SAR_REPORT_TYPE SAR_REPORT_TYPE { get; set; }

        public virtual SAR_REPORT_TEMPLATE SAR_REPORT_TEMPLATE { get; set; }
    }
}

namespace CreateDBOracle.ContextCodeFirstModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.SAR_REPORT_CALENDAR")]
    public partial class SAR_REPORT_CALENDAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SAR_REPORT_CALENDAR()
        {
            SAR_REPORT_CALENDAR1 = new HashSet<SAR_REPORT_CALENDAR>();
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
        [StringLength(12)]
        public string REPORT_CALENDAR_CODE { get; set; }

        public short? IS_DAY_REPEAT { get; set; }

        public short? IS_WEEK_REPEAT { get; set; }

        public short? IS_MONTH_REPEAT { get; set; }

        public long EXECUTE_TIME { get; set; }

        public long? END_TIME { get; set; }

        public short? IS_DONE { get; set; }

        public string FILTER_TOTAL_JSON { get; set; }

        public long? REPORT_ID { get; set; }

        public long? SOURCE_ID { get; set; }

        public virtual SAR_REPORT SAR_REPORT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAR_REPORT_CALENDAR> SAR_REPORT_CALENDAR1 { get; set; }

        public virtual SAR_REPORT_CALENDAR SAR_REPORT_CALENDAR2 { get; set; }
    }
}

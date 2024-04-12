namespace CreateDBOracle.ContextCodeFirstModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.SAR_REPORT_TYPE")]
    public partial class SAR_REPORT_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SAR_REPORT_TYPE()
        {
            SAR_REPORT = new HashSet<SAR_REPORT>();
            SAR_REPORT_TEMPLATE = new HashSet<SAR_REPORT_TEMPLATE>();
            SAR_RETY_FOFI = new HashSet<SAR_RETY_FOFI>();
            SAR_USER_REPORT_TYPE = new HashSet<SAR_USER_REPORT_TYPE>();
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
        public string REPORT_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string REPORT_TYPE_NAME { get; set; }

        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        public long? REPORT_TYPE_GROUP_ID { get; set; }

        public short? IS_IMPORTANCE { get; set; }

        [StringLength(4)]
        public string HOUR_FROM { get; set; }

        [StringLength(4)]
        public string HOUR_TO { get; set; }

        public byte[] SQL { get; set; }

        [StringLength(10)]
        public string DLL_CODE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAR_REPORT> SAR_REPORT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAR_REPORT_TEMPLATE> SAR_REPORT_TEMPLATE { get; set; }

        public virtual SAR_REPORT_TYPE_GROUP SAR_REPORT_TYPE_GROUP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAR_RETY_FOFI> SAR_RETY_FOFI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAR_USER_REPORT_TYPE> SAR_USER_REPORT_TYPE { get; set; }
    }
}

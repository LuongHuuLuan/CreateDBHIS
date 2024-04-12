namespace CreateDBOracle.ContextCodeFirstModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.SAR_PRINT_TYPE")]
    public partial class SAR_PRINT_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SAR_PRINT_TYPE()
        {
            SAR_PRINT = new HashSet<SAR_PRINT>();
            SAR_PRINT_TYPE_CFG = new HashSet<SAR_PRINT_TYPE_CFG>();
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
        public string PRINT_TYPE_CODE { get; set; }

        [Required]
        [StringLength(200)]
        public string FILE_PATTERN { get; set; }

        [StringLength(100)]
        public string PRINT_TYPE_NAME { get; set; }

        public short? IS_NO_GROUP { get; set; }

        public short? IS_PRINT_LOG { get; set; }

        [StringLength(2)]
        public string EMR_DOCUMENT_TYPE_CODE { get; set; }

        public short? IS_AUTO_CHOOSE_BUSINESS { get; set; }

        [StringLength(2000)]
        public string BUSINESS_CODES { get; set; }

        public short? DO_NOT_ALLOW_REPRINT { get; set; }

        [StringLength(4000)]
        public string REPRINT_EXCEPTION_LOGINNAME { get; set; }

        public short? IS_DIGITAL_SIGN { get; set; }

        public short? IS_SINGLE_COPY { get; set; }

        public short? DO_NOT_ALLOW_PRINT { get; set; }

        [StringLength(4000)]
        public string PRINT_EXCEPTION_LOGINNAME { get; set; }

        public short? PRINT_LOG_ENABLE { get; set; }

        [StringLength(4000)]
        public string EMR_COLUMN_MAPPING { get; set; }

        [StringLength(4000)]
        public string DISABLE_PRINT_BY_KEY_CFG { get; set; }

        [StringLength(4000)]
        public string GEN_SIGNATURE_BY_KEY_CFG { get; set; }

        public short? GEN_SIGNATURE_ENABLE { get; set; }

        [StringLength(6)]
        public string EMR_DOCUMENT_GROUP_CODE { get; set; }

        public short? IS_ALLOW_ATTACH_PRINT { get; set; }

        public short? IS_PRINT_EXCEPTION_REASON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAR_PRINT> SAR_PRINT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAR_PRINT_TYPE_CFG> SAR_PRINT_TYPE_CFG { get; set; }
    }
}

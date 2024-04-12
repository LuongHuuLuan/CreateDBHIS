namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.SDA_SQL")]
    public partial class SDA_SQL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SDA_SQL()
        {
            SDA_SQL_PARAM = new HashSet<SDA_SQL_PARAM>();
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

        [StringLength(20)]
        public string GROUP_CODE { get; set; }

        [Required]
        [StringLength(200)]
        public string SQL_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string SQL_CODE { get; set; }

        public long SQL_TYPE { get; set; }

        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        [Required]
        [StringLength(10)]
        public string SCHEMA_CODE { get; set; }

        public string CONTENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SDA_SQL_PARAM> SDA_SQL_PARAM { get; set; }
    }
}

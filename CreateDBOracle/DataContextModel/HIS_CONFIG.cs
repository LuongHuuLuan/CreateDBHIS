namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_CONFIG")]
    public partial class HIS_CONFIG
    {
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
        [StringLength(100)]
        public string KEY { get; set; }

        [StringLength(4000)]
        public string VALUE_BK { get; set; }

        [StringLength(4000)]
        public string DEFAULT_VALUE_BK { get; set; }

        [StringLength(4000)]
        public string DESCRIPTION_BK { get; set; }

        public long? BRANCH_ID { get; set; }

        [StringLength(4000)]
        public string MODULE_LINKS { get; set; }

        public string VALUE { get; set; }

        public string DEFAULT_VALUE { get; set; }

        public string DESCRIPTION { get; set; }

        [Required]
        [StringLength(20)]
        public string CONFIG_CODE { get; set; }

        [StringLength(1000)]
        public string CONFIG_GROUP_CODES { get; set; }
    }
}

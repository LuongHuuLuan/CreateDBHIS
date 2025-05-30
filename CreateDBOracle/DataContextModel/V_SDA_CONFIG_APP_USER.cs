namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_SDA_CONFIG_APP_USER")]
    public partial class V_SDA_CONFIG_APP_USER
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

        [StringLength(20)]
        public string GROUP_CODE { get; set; }

        public long CONFIG_APP_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string LOGINNAME { get; set; }

        [Required]
        [StringLength(500)]
        public string VALUE { get; set; }

        [Required]
        [StringLength(100)]
        public string KEY { get; set; }

        [StringLength(500)]
        public string DEFAULT_VALUE { get; set; }
    }
}

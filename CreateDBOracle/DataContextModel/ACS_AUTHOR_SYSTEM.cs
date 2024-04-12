namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.ACS_AUTHOR_SYSTEM")]
    public partial class ACS_AUTHOR_SYSTEM
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
        [StringLength(50)]
        public string AUTHOR_SYSTEM_CODE { get; set; }

        [Required]
        [StringLength(200)]
        public string AUTHOR_SYSTEM_NAME { get; set; }

        [Required]
        [StringLength(200)]
        public string SERCURE_KEY { get; set; }

        public decimal AUTHOR_SYSTEM_TYPE_ID { get; set; }

        [StringLength(500)]
        public string WEB_ADDRESS { get; set; }
    }
}

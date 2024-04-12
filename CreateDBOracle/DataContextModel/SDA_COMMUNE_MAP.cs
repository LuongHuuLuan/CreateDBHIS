namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.SDA_COMMUNE_MAP")]
    public partial class SDA_COMMUNE_MAP
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
        [StringLength(10)]
        public string PARTNER_CODE { get; set; }

        [StringLength(20)]
        public string PARTNER_PROVINCE_CODE { get; set; }

        [StringLength(20)]
        public string PARTNER_DISTRICT_CODE { get; set; }

        [Required]
        [StringLength(20)]
        public string PARTNER_COMMUNE_CODE { get; set; }

        [StringLength(20)]
        public string COMMUNE_CODE { get; set; }

        [StringLength(200)]
        public string PARTNER_COMMUNE_NAME { get; set; }
    }
}

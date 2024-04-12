namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_ACS_MODULE")]
    public partial class V_ACS_MODULE
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
        public string MODULE_NAME { get; set; }

        [StringLength(200)]
        public string MODULE_LINK { get; set; }

        public short? IS_VISIBLE { get; set; }

        public long? NUM_ORDER { get; set; }

        public short? IS_LEAF { get; set; }

        public long? PARENT_ID { get; set; }

        public long APPLICATION_ID { get; set; }

        public long? MODULE_GROUP_ID { get; set; }

        [StringLength(1000)]
        public string ICON_LINK { get; set; }

        public short? IS_ANONYMOUS { get; set; }

        [StringLength(200)]
        public string MODULE_URL { get; set; }

        [StringLength(200)]
        public string VIR_MODULE_LINK { get; set; }

        [StringLength(4000)]
        public string VIDEO_URLS { get; set; }

        public short? IS_NOT_SHOW_DIALOG { get; set; }

        [StringLength(8)]
        public string MODULE_GROUP_CODE { get; set; }

        [StringLength(200)]
        public string MODULE_GROUP_NAME { get; set; }

        [Required]
        [StringLength(3)]
        public string APPLICATION_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string APPLICATION_NAME { get; set; }

        [StringLength(100)]
        public string PARENT_NAME { get; set; }
    }
}

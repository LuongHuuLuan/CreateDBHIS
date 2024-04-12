namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.SDA_CUSTOMIZE_BUTTON")]
    public partial class SDA_CUSTOMIZE_BUTTON
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
        [StringLength(3)]
        public string APP_CODE { get; set; }

        [Required]
        [StringLength(200)]
        public string MODULE_LINK { get; set; }

        [Required]
        [StringLength(50)]
        public string BUTTON_CODE { get; set; }

        [StringLength(4000)]
        public string BUTTON_PATH { get; set; }

        [StringLength(20)]
        public string BRANCH_CODE { get; set; }

        [StringLength(50)]
        public string CURRENT_SHORTCUT { get; set; }

        [StringLength(50)]
        public string SHORTCUT { get; set; }

        [StringLength(200)]
        public string CAPTION { get; set; }

        [StringLength(200)]
        public string DEFAULT_CAPTION { get; set; }
    }
}

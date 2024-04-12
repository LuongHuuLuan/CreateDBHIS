namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.SAR_PRINT_TYPE_CFG")]
    public partial class SAR_PRINT_TYPE_CFG
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
        public string CONTROL_CODE { get; set; }

        [Required]
        [StringLength(4000)]
        public string CONTROL_PATH { get; set; }

        [StringLength(20)]
        public string BRANCH_CODE { get; set; }

        public long PRINT_TYPE_ID { get; set; }

        [StringLength(100)]
        public string CAPTION { get; set; }

        public virtual SAR_PRINT_TYPE SAR_PRINT_TYPE { get; set; }
    }
}

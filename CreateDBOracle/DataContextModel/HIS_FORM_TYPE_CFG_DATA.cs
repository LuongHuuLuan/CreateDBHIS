namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_FORM_TYPE_CFG_DATA")]
    public partial class HIS_FORM_TYPE_CFG_DATA
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

        public long FORM_TYPE_CFG_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string FORM_TYPE_CODE { get; set; }

        [StringLength(500)]
        public string VALUE { get; set; }

        public virtual HIS_FORM_TYPE_CFG HIS_FORM_TYPE_CFG { get; set; }
    }
}

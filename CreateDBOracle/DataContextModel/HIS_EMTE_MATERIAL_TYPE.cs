namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_EMTE_MATERIAL_TYPE")]
    public partial class HIS_EMTE_MATERIAL_TYPE
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

        public long EXP_MEST_TEMPLATE_ID { get; set; }

        public long? MATERIAL_TYPE_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public short? IS_EXPEND { get; set; }

        public short? IS_OUT_MEDI_STOCK { get; set; }

        [Required]
        [StringLength(500)]
        public string MATERIAL_TYPE_NAME { get; set; }

        public long? SERVICE_UNIT_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        public virtual HIS_EXP_MEST_TEMPLATE HIS_EXP_MEST_TEMPLATE { get; set; }

        public virtual HIS_MATERIAL_TYPE HIS_MATERIAL_TYPE { get; set; }

        public virtual HIS_SERVICE_UNIT HIS_SERVICE_UNIT { get; set; }
    }
}

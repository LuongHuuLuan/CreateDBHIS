namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.L_HIS_EXP_MEST_MATERIAL_2")]
    public partial class L_HIS_EXP_MEST_MATERIAL_2
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public long? TDL_MATERIAL_TYPE_ID { get; set; }

        public long? CHMS_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EXP_MEST_STT_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MEDI_STOCK_ID { get; set; }

        public long? IMP_MEDI_STOCK_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(12)]
        public string EXP_MEST_CODE { get; set; }
    }
}

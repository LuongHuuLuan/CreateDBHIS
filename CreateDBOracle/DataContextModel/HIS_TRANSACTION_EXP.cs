namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_TRANSACTION_EXP")]
    public partial class HIS_TRANSACTION_EXP
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
        [StringLength(12)]
        public string TDL_EXP_MEST_CODE { get; set; }

        public long TDL_MEDI_STOCK_ID { get; set; }

        public long TRANSACTION_ID { get; set; }

        public long? EXP_MEST_ID { get; set; }

        public virtual HIS_EXP_MEST HIS_EXP_MEST { get; set; }

        public virtual HIS_TRANSACTION HIS_TRANSACTION { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_MEDI_STOCK_EXTY")]
    public partial class HIS_MEDI_STOCK_EXTY
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

        public long MEDI_STOCK_ID { get; set; }

        public long EXP_MEST_TYPE_ID { get; set; }

        public short? IS_AUTO_APPROVE { get; set; }

        public short? IS_AUTO_EXECUTE { get; set; }

        public virtual HIS_EXP_MEST_TYPE HIS_EXP_MEST_TYPE { get; set; }

        public virtual HIS_MEDI_STOCK HIS_MEDI_STOCK { get; set; }
    }
}

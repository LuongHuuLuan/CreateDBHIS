namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_MEST_PERIOD_MEDI")]
    public partial class HIS_MEST_PERIOD_MEDI
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

        public long MEDI_STOCK_PERIOD_ID { get; set; }

        public long MEDICINE_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public long? TDL_MEDICINE_TYPE_ID { get; set; }

        public decimal? BEGIN_AMOUNT { get; set; }

        public decimal? IN_AMOUNT { get; set; }

        public decimal? OUT_AMOUNT { get; set; }

        public decimal? INVENTORY_AMOUNT { get; set; }

        public decimal? VIR_END_AMOUNT { get; set; }

        public long? MEDI_STOCK_ID { get; set; }

        public virtual HIS_MEDI_STOCK HIS_MEDI_STOCK { get; set; }

        public virtual HIS_MEDI_STOCK_PERIOD HIS_MEDI_STOCK_PERIOD { get; set; }

        public virtual HIS_MEDICINE HIS_MEDICINE { get; set; }
    }
}

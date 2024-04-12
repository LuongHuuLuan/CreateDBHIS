namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SALE_PROFIT_CFG")]
    public partial class HIS_SALE_PROFIT_CFG
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

        public decimal RATIO { get; set; }

        public short? IS_MEDICINE { get; set; }

        public short? IS_MATERIAL { get; set; }

        public decimal? IMP_PRICE_FROM { get; set; }

        public decimal? IMP_PRICE_TO { get; set; }

        public short? IS_FUNCTIONAL_FOOD { get; set; }

        public short? IS_COMMON_MEDICINE { get; set; }

        public short? IS_DRUG_STORE { get; set; }
    }
}

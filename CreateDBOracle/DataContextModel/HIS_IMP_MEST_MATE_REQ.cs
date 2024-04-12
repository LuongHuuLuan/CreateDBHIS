namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_IMP_MEST_MATE_REQ")]
    public partial class HIS_IMP_MEST_MATE_REQ
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

        public long IMP_MEST_ID { get; set; }

        public long MATERIAL_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public long? NUM_ORDER { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        public long TDL_MEDI_STOCK_ID { get; set; }

        public decimal? APPROVED_AMOUNT { get; set; }

        public long? TREATMENT_ID { get; set; }

        public long? TH_EXP_MEST_MATERIAL_ID { get; set; }

        public virtual HIS_EXP_MEST_MATERIAL HIS_EXP_MEST_MATERIAL { get; set; }

        public virtual HIS_IMP_MEST HIS_IMP_MEST { get; set; }

        public virtual HIS_MEDICINE HIS_MEDICINE { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }
    }
}

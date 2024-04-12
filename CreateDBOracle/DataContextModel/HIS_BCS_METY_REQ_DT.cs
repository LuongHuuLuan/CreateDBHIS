namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_BCS_METY_REQ_DT")]
    public partial class HIS_BCS_METY_REQ_DT
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

        public long EXP_MEST_MEDICINE_ID { get; set; }

        public long EXP_MEST_METY_REQ_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public long TDL_XBTT_EXP_MEST_ID { get; set; }

        [Required]
        [StringLength(12)]
        public string TDL_XBTT_EXP_MEST_CODE { get; set; }

        public virtual HIS_EXP_MEST_MEDICINE HIS_EXP_MEST_MEDICINE { get; set; }

        public virtual HIS_EXP_MEST_METY_REQ HIS_EXP_MEST_METY_REQ { get; set; }
    }
}

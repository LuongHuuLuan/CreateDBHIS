namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_MR_CHECKLIST")]
    public partial class HIS_MR_CHECKLIST
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

        public long MR_CHECK_ITEM_ID { get; set; }

        public short? IS_SELF_CHECK { get; set; }

        public short? IS_CHECKER_CHECK { get; set; }

        [StringLength(4000)]
        public string NOTE { get; set; }

        public long MR_CHECK_SUMMARY_ID { get; set; }

        public short? IS_CHECKER_NOT_USED { get; set; }

        public virtual HIS_MR_CHECK_ITEM HIS_MR_CHECK_ITEM { get; set; }

        public virtual HIS_MR_CHECK_SUMMARY HIS_MR_CHECK_SUMMARY { get; set; }
    }
}

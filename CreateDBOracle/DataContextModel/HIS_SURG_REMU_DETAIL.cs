namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SURG_REMU_DETAIL")]
    public partial class HIS_SURG_REMU_DETAIL
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

        public long EXECUTE_ROLE_ID { get; set; }

        public decimal PRICE { get; set; }

        public long SURG_REMUNERATION_ID { get; set; }

        public virtual HIS_EXECUTE_ROLE HIS_EXECUTE_ROLE { get; set; }

        public virtual HIS_SURG_REMUNERATION HIS_SURG_REMUNERATION { get; set; }
    }
}

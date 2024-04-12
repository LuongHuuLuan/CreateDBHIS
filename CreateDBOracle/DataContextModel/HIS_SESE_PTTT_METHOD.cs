namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SESE_PTTT_METHOD")]
    public partial class HIS_SESE_PTTT_METHOD
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

        public long SERE_SERV_PTTT_ID { get; set; }

        public long PTTT_METHOD_ID { get; set; }

        public decimal? AMOUNT { get; set; }

        public long TDL_SERE_SERV_ID { get; set; }

        public long TDL_SERVICE_REQ_ID { get; set; }

        public long? EKIP_ID { get; set; }

        public long? PTTT_GROUP_ID { get; set; }

        public virtual HIS_EKIP HIS_EKIP { get; set; }

        public virtual HIS_PTTT_GROUP HIS_PTTT_GROUP { get; set; }

        public virtual HIS_PTTT_METHOD HIS_PTTT_METHOD { get; set; }

        public virtual HIS_SERE_SERV_PTTT HIS_SERE_SERV_PTTT { get; set; }
    }
}

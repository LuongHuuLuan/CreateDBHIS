namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SERE_SERV_SUIN")]
    public partial class HIS_SERE_SERV_SUIN
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

        public long SERE_SERV_ID { get; set; }

        public long SUIM_INDEX_ID { get; set; }

        public decimal? VALUE { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        public virtual HIS_SERE_SERV HIS_SERE_SERV { get; set; }

        public virtual HIS_SUIM_INDEX HIS_SUIM_INDEX { get; set; }
    }
}

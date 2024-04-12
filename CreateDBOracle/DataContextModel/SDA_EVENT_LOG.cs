namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.SDA_EVENT_LOG")]
    public partial class SDA_EVENT_LOG
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

        [StringLength(50)]
        public string LOGIN_NAME { get; set; }

        [StringLength(20)]
        public string IP { get; set; }

        [StringLength(4000)]
        public string DESCRIPTION { get; set; }

        [StringLength(3)]
        public string APP_CODE { get; set; }

        public long? EVENT_TIME { get; set; }

        [StringLength(500)]
        public string TITLE { get; set; }

        public long? CREATE_DATE { get; set; }

        public decimal? EVENT_DATE { get; set; }

        public decimal? EVENT_MONTH { get; set; }
    }
}

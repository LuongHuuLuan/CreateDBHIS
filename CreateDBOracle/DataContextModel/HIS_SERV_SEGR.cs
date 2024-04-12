namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SERV_SEGR")]
    public partial class HIS_SERV_SEGR
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

        public long SERVICE_GROUP_ID { get; set; }

        public long SERVICE_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public long? IS_EXPEND { get; set; }

        [StringLength(1000)]
        public string NOTE { get; set; }

        public long? ROOM_ID { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        public virtual HIS_SERVICE_GROUP HIS_SERVICE_GROUP { get; set; }

        public virtual HIS_SERVICE HIS_SERVICE { get; set; }
    }
}

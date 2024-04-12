namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_STENT_CONCLUDE")]
    public partial class HIS_STENT_CONCLUDE
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

        [StringLength(500)]
        public string SURGERY_NAME { get; set; }

        [StringLength(200)]
        public string DEVICE_NAME { get; set; }

        [StringLength(200)]
        public string BALLON_PRESSURE_TIME { get; set; }

        public decimal? RESULT_BEFORE { get; set; }

        public decimal? RESULT_AFTER { get; set; }

        public long? SERE_SERV_ID { get; set; }
    }
}

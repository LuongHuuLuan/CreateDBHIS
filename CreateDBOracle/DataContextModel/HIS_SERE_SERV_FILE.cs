namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SERE_SERV_FILE")]
    public partial class HIS_SERE_SERV_FILE
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
        public string SERE_SERV_FILE_NAME { get; set; }

        public long SERE_SERV_ID { get; set; }

        [StringLength(2000)]
        public string URL { get; set; }

        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        [StringLength(200)]
        public string CAPTION { get; set; }

        public long? BODY_PART_ID { get; set; }

        public virtual HIS_BODY_PART HIS_BODY_PART { get; set; }

        public virtual HIS_SERE_SERV HIS_SERE_SERV { get; set; }
    }
}

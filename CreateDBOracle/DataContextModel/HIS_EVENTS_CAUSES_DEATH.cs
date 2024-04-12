namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_EVENTS_CAUSES_DEATH")]
    public partial class HIS_EVENTS_CAUSES_DEATH
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

        [StringLength(10)]
        public string ICD_CODE { get; set; }

        public long? HAPPEN_TIME { get; set; }

        [StringLength(500)]
        public string UNIT_NAME { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        public short? IS_OTHER_CAUSE { get; set; }

        public long SEVERE_ILLNESS_INFO_ID { get; set; }

        [StringLength(500)]
        public string EXTERNAL_CAUSE { get; set; }

        [StringLength(500)]
        public string CAUSE_NAME { get; set; }

        public virtual HIS_SEVERE_ILLNESS_INFO HIS_SEVERE_ILLNESS_INFO { get; set; }
    }
}

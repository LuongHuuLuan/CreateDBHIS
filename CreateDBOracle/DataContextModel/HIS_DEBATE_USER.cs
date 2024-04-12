namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_DEBATE_USER")]
    public partial class HIS_DEBATE_USER
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

        public long? DEBATE_ID { get; set; }

        [StringLength(50)]
        public string LOGINNAME { get; set; }

        [StringLength(100)]
        public string USERNAME { get; set; }

        public short? IS_PRESIDENT { get; set; }

        public short? IS_SECRETARY { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        public long? DEBATE_TEMP_ID { get; set; }

        public long? EXECUTE_ROLE_ID { get; set; }

        public virtual HIS_DEBATE HIS_DEBATE { get; set; }

        public virtual HIS_DEBATE_TEMP HIS_DEBATE_TEMP { get; set; }

        public virtual HIS_EXECUTE_ROLE HIS_EXECUTE_ROLE { get; set; }
    }
}

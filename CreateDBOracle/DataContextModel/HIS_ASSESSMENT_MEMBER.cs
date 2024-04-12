namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_ASSESSMENT_MEMBER")]
    public partial class HIS_ASSESSMENT_MEMBER
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

        public long MEDICAL_ASSESSMENT_ID { get; set; }

        [StringLength(50)]
        public string LOGINNAME { get; set; }

        [StringLength(100)]
        public string USERNAME { get; set; }

        public short? IS_PRESIDENT { get; set; }

        public short? IS_SECRETARY { get; set; }

        public short? IS_VICE_PRESIDENT { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        public short? ON_BEHALF_TO_SIGN { get; set; }

        public short? IS_GUEST { get; set; }

        public short? IS_DISAGREED { get; set; }

        [StringLength(4000)]
        public string DISAGREE_REASON { get; set; }

        public short? IS_ABSENT { get; set; }

        public virtual HIS_MEDICAL_ASSESSMENT HIS_MEDICAL_ASSESSMENT { get; set; }
    }
}

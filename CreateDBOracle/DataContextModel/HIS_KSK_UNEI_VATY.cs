namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_KSK_UNEI_VATY")]
    public partial class HIS_KSK_UNEI_VATY
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

        public long KSK_UNDER_EIGHTEEN_ID { get; set; }

        public long VACCINE_TYPE_ID { get; set; }

        public long? CONDITION_TYPE { get; set; }

        public virtual HIS_KSK_UNDER_EIGHTEEN HIS_KSK_UNDER_EIGHTEEN { get; set; }

        public virtual HIS_VACCINE_TYPE HIS_VACCINE_TYPE { get; set; }
    }
}

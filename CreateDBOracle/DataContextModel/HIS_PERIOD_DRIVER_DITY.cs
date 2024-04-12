namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_PERIOD_DRIVER_DITY")]
    public partial class HIS_PERIOD_DRIVER_DITY
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

        public long KSK_PERIOD_DRIVER_ID { get; set; }

        public long DISEASE_TYPE_ID { get; set; }

        [StringLength(20)]
        public string IS_YES_NO { get; set; }

        public virtual HIS_DISEASE_TYPE HIS_DISEASE_TYPE { get; set; }

        public virtual HIS_KSK_PERIOD_DRIVER HIS_KSK_PERIOD_DRIVER { get; set; }
    }
}

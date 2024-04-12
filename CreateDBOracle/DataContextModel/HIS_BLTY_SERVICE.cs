namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_BLTY_SERVICE")]
    public partial class HIS_BLTY_SERVICE
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

        public long BLOOD_TYPE_ID { get; set; }

        public long BLTY_AMOUNT { get; set; }

        public long SERVICE_ID { get; set; }

        public long SERVICE_AMOUNT { get; set; }

        public long? NUM_ORDER { get; set; }

        public virtual HIS_BLOOD_TYPE HIS_BLOOD_TYPE { get; set; }

        public virtual HIS_SERVICE HIS_SERVICE { get; set; }
    }
}

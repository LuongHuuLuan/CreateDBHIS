namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SERVICE_HEIN")]
    public partial class HIS_SERVICE_HEIN
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

        public long SERVICE_ID { get; set; }

        public long BRANCH_ID { get; set; }

        public decimal? PRICE { get; set; }

        public decimal? RATIO { get; set; }

        public long? PRIORITY { get; set; }

        public long? AGE_FROM { get; set; }

        public long? AGE_TO { get; set; }

        [StringLength(2000)]
        public string ICD_CODES { get; set; }

        public long? FROM_TIME { get; set; }

        public long? TO_TIME { get; set; }

        public long? TREATMENT_FROM_TIME { get; set; }

        public long? TREATMENT_TO_TIME { get; set; }

        [StringLength(20)]
        public string SERVICE_HEIN_CODE { get; set; }

        [StringLength(1000)]
        public string SERVICE_HEIN_NAME { get; set; }

        public virtual HIS_BRANCH HIS_BRANCH { get; set; }

        public virtual HIS_SERVICE HIS_SERVICE { get; set; }
    }
}

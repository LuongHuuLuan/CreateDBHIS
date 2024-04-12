namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_ADR_MEDICINE_TYPE")]
    public partial class HIS_ADR_MEDICINE_TYPE
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

        public long MEDICINE_TYPE_ID { get; set; }

        public long ADR_ID { get; set; }

        public short? IS_ADR { get; set; }

        public long? START_TIME { get; set; }

        public long? FINISH_TIME { get; set; }

        [StringLength(100)]
        public string PACKAGE_NUMBER { get; set; }

        public decimal? ONCE_TUTORIAL { get; set; }

        [StringLength(100)]
        public string NUMBER_USE { get; set; }

        [StringLength(500)]
        public string REASON { get; set; }

        public long? IMPROVE_TYPE_ID { get; set; }

        public long? REAPPEAR_TYPE_ID { get; set; }

        public virtual HIS_ADR HIS_ADR { get; set; }

        public virtual HIS_MEDICINE_TYPE HIS_MEDICINE_TYPE { get; set; }
    }
}

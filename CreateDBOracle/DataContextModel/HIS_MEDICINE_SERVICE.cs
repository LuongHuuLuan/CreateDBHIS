namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_MEDICINE_SERVICE")]
    public partial class HIS_MEDICINE_SERVICE
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
        public string ICD_CODE { get; set; }

        [StringLength(4000)]
        public string ICD_NAME { get; set; }

        public long? SERVICE_ID { get; set; }

        public long? MEDICINE_TYPE_ID { get; set; }

        public long? TEST_INDEX_ID { get; set; }

        public short? DATA_TYPE { get; set; }

        public decimal? VALUE_SERVICE_FROM { get; set; }

        public decimal? VALUE_SERVICE_TO { get; set; }

        public decimal? AMOUNT_INDAY_FROM { get; set; }

        public decimal? AMOUNT_INDAY_TO { get; set; }

        [StringLength(4000)]
        public string WARNING_CONTENT { get; set; }
    }
}

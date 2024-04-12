namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SERVICE_REQ_MATY")]
    public partial class HIS_SERVICE_REQ_MATY
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

        public long SERVICE_REQ_ID { get; set; }

        public long? MATERIAL_TYPE_ID { get; set; }

        [Required]
        [StringLength(500)]
        public string MATERIAL_TYPE_NAME { get; set; }

        [StringLength(50)]
        public string UNIT_NAME { get; set; }

        public decimal AMOUNT { get; set; }

        public long? NUM_ORDER { get; set; }

        public decimal? PRICE { get; set; }

        [StringLength(1000)]
        public string TUTORIAL { get; set; }

        public short? IS_SUB_PRES { get; set; }

        public long TDL_TREATMENT_ID { get; set; }

        public decimal? PRES_AMOUNT { get; set; }

        [StringLength(2000)]
        public string EXCEED_LIMIT_IN_PRES_REASON { get; set; }

        [StringLength(2000)]
        public string EXCEED_LIMIT_IN_DAY_REASON { get; set; }

        public virtual HIS_MATERIAL_TYPE HIS_MATERIAL_TYPE { get; set; }

        public virtual HIS_SERVICE_REQ HIS_SERVICE_REQ { get; set; }
    }
}

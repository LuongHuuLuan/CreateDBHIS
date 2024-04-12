namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_TRANSFUSION")]
    public partial class HIS_TRANSFUSION
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

        public long TRANSFUSION_SUM_ID { get; set; }

        public long MEASURE_TIME { get; set; }

        public long SPEED { get; set; }

        [StringLength(100)]
        public string SKIN { get; set; }

        public decimal? BREATH_RATE { get; set; }

        public long? PULSE { get; set; }

        public long? BLOOD_PRESSURE_MAX { get; set; }

        public long? BLOOD_PRESSURE_MIN { get; set; }

        public decimal? TEMPERATURE { get; set; }

        [StringLength(500)]
        public string NOTE { get; set; }

        public virtual HIS_TRANSFUSION_SUM HIS_TRANSFUSION_SUM { get; set; }
    }
}

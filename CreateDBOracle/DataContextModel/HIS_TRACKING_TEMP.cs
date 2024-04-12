namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_TRACKING_TEMP")]
    public partial class HIS_TRACKING_TEMP
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

        [StringLength(4000)]
        public string MEDICAL_INSTRUCTION { get; set; }

        [StringLength(4000)]
        public string CONTENT { get; set; }

        public decimal? TEMPERATURE { get; set; }

        public decimal? BREATH_RATE { get; set; }

        public decimal? WEIGHT { get; set; }

        public decimal? HEIGHT { get; set; }

        public decimal? CHEST { get; set; }

        public decimal? BELLY { get; set; }

        public long? BLOOD_PRESSURE_MAX { get; set; }

        public long? BLOOD_PRESSURE_MIN { get; set; }

        public long? PULSE { get; set; }

        public decimal? VIR_BMI { get; set; }

        public decimal? VIR_BODY_SURFACE_AREA { get; set; }

        [Required]
        [StringLength(6)]
        public string TRACKING_TEMP_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string TRACKING_TEMP_NAME { get; set; }

        public short? IS_PUBLIC { get; set; }

        public long? DEPARTMENT_ID { get; set; }

        public short? IS_PUBLIC_IN_DEPARTMENT { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }
    }
}

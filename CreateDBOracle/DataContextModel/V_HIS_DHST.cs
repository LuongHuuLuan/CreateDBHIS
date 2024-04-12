namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_DHST")]
    public partial class V_HIS_DHST
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

        public long TREATMENT_ID { get; set; }

        public long? DHST_SUM_ID { get; set; }

        public long? TRACKING_ID { get; set; }

        public long? CARE_ID { get; set; }

        public long? EXECUTE_ROOM_ID { get; set; }

        public long? EXECUTE_DEPARTMENT_ID { get; set; }

        [StringLength(50)]
        public string EXECUTE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string EXECUTE_USERNAME { get; set; }

        public long? EXECUTE_TIME { get; set; }

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

        public decimal? SPO2 { get; set; }

        public decimal? CAPILLARY_BLOOD_GLUCOSE { get; set; }

        [StringLength(4000)]
        public string NOTE { get; set; }

        public short? INFUTION_INTO { get; set; }

        public short? INFUTION_OUT { get; set; }

        public long? VACCINATION_EXAM_ID { get; set; }

        [StringLength(1)]
        public string IS_IN_SERVICE_REQ { get; set; }

        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        [StringLength(20)]
        public string ROOM_CODE { get; set; }

        [StringLength(100)]
        public string ROOM_NAME { get; set; }
    }
}

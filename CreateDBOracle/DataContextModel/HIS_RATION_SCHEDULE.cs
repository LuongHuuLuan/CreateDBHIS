namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_RATION_SCHEDULE")]
    public partial class HIS_RATION_SCHEDULE
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

        public long? TREATMENT_ID { get; set; }

        public long? RATION_TIME_ID { get; set; }

        public long? PATIENT_TYPE_ID { get; set; }

        public long? SERVICE_ID { get; set; }

        public long? REFECTORY_ROOM_ID { get; set; }

        public decimal? AMOUNT { get; set; }

        public long? FROM_TIME { get; set; }

        public long? TO_TIME { get; set; }

        public short? IS_FOR_HOMIE { get; set; }

        public short? IS_HALF_IN_FIRST_DAY { get; set; }

        [StringLength(1000)]
        public string NOTE { get; set; }

        public long? LAST_ASSIGN_DATE { get; set; }

        public long? DEPARTMENT_ID { get; set; }

        public long? VIR_FROM_DATE { get; set; }

        public long? VIR_TO_DATE { get; set; }

        public virtual HIS_PATIENT_TYPE HIS_PATIENT_TYPE { get; set; }

        public virtual HIS_RATION_TIME HIS_RATION_TIME { get; set; }

        public virtual HIS_REFECTORY HIS_REFECTORY { get; set; }

        public virtual HIS_SERVICE HIS_SERVICE { get; set; }
    }
}

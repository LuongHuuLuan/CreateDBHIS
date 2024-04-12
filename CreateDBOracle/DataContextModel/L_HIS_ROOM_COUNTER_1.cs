namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.L_HIS_ROOM_COUNTER_1")]
    public partial class L_HIS_ROOM_COUNTER_1
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public long ROOM_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string EXECUTE_ROOM_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string EXECUTE_ROOM_NAME { get; set; }

        public long? MAX_REQ_BHYT_BY_DAY { get; set; }

        public long? MAX_REQUEST_BY_DAY { get; set; }

        public long? NUM_ORDER { get; set; }

        public short? IS_EXAM { get; set; }

        public short? IS_ACTIVE { get; set; }

        public short? IS_PAUSE_ENCLITIC { get; set; }

        public long? MAX_PATIENT_BY_DAY { get; set; }

        public short? ALLOW_NOT_CHOOSE_SERVICE { get; set; }

        public long DEPARTMENT_ID { get; set; }

        public long ROOM_TYPE_ID { get; set; }

        public long? AREA_ID { get; set; }

        public long? DEFAULT_SERVICE_ID { get; set; }

        public long BRANCH_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        public decimal? TOTAL_TODAY_PATIENT { get; set; }
    }
}

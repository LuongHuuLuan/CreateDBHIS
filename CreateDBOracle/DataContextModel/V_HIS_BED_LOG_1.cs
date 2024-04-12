namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_BED_LOG_1")]
    public partial class V_HIS_BED_LOG_1
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

        public long TREATMENT_BED_ROOM_ID { get; set; }

        public long BED_ID { get; set; }

        public long START_TIME { get; set; }

        public long? FINISH_TIME { get; set; }

        public long? BED_SERVICE_TYPE_ID { get; set; }

        public long? SERVICE_REQ_ID { get; set; }

        public long? SHARE_COUNT { get; set; }

        public long? PATIENT_TYPE_ID { get; set; }

        public long? PRIMARY_PATIENT_TYPE_ID { get; set; }

        public short? IS_SERVICE_REQ_ASSIGNED { get; set; }

        [Required]
        [StringLength(10)]
        public string BED_CODE { get; set; }

        public long BED_TYPE_ID { get; set; }

        [StringLength(6)]
        public string X { get; set; }

        [StringLength(6)]
        public string Y { get; set; }

        [Required]
        [StringLength(200)]
        public string BED_NAME { get; set; }

        public long TREATMENT_ID { get; set; }
    }
}

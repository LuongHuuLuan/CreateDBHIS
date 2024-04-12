namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_LIS_SAMPLE_SERVICE")]
    public partial class V_LIS_SAMPLE_SERVICE
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

        public long SAMPLE_ID { get; set; }

        [Required]
        [StringLength(25)]
        public string SERVICE_CODE { get; set; }

        [StringLength(500)]
        public string SERVICE_NAME { get; set; }

        public long SAMPLE_SERVICE_STT_ID { get; set; }

        public short? IS_NO_EXECUTE { get; set; }

        public long? SERVICE_NUM_ORDER { get; set; }

        public short? MAX_TIME_RETURN_RESULT { get; set; }

        public short? IS_RUN_AGAIN { get; set; }

        public short? IS_RUNNING { get; set; }

        public long? MACHINE_ID { get; set; }

        public short? BACTERIAL_CULTIVATION_RESULT { get; set; }

        public long SAMPLE_STT_ID { get; set; }

        [StringLength(15)]
        public string BARCODE { get; set; }

        [StringLength(10)]
        public string SAMPLE_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string SAMPLE_ROOM_NAME { get; set; }

        [Required]
        [StringLength(10)]
        public string EXECUTE_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string EXECUTE_ROOM_NAME { get; set; }

        [StringLength(30)]
        public string FIRST_NAME { get; set; }

        [StringLength(70)]
        public string LAST_NAME { get; set; }

        [StringLength(10)]
        public string PATIENT_CODE { get; set; }

        [StringLength(2)]
        public string GENDER_CODE { get; set; }

        public long? DOB { get; set; }

        [StringLength(10)]
        public string REQUEST_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string REQUEST_ROOM_NAME { get; set; }

        [StringLength(12)]
        public string SERVICE_REQ_CODE { get; set; }

        [Required]
        [StringLength(2)]
        public string SAMPLE_STT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SAMPLE_STT_NAME { get; set; }

        [Required]
        [StringLength(2)]
        public string SAMPLE_SERVICE_STT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SAMPLE_SERVICE_STT_NAME { get; set; }
    }
}

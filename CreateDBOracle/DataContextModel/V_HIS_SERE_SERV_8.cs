namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_SERE_SERV_8")]
    public partial class V_HIS_SERE_SERV_8
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [Required]
        [StringLength(25)]
        public string TDL_SERVICE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string TDL_SERVICE_NAME { get; set; }

        public decimal AMOUNT { get; set; }

        public short? IS_EXPEND { get; set; }

        public long TDL_SERVICE_TYPE_ID { get; set; }

        public short? IS_NO_EXECUTE { get; set; }

        public long? EKIP_ID { get; set; }

        public long? TDL_HEIN_SERVICE_TYPE_ID { get; set; }

        public long TDL_EXECUTE_ROOM_ID { get; set; }

        public long TDL_REQUEST_DEPARTMENT_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_TYPE_NAME { get; set; }

        [StringLength(3)]
        public string PTTT_GROUP_CODE { get; set; }

        [StringLength(100)]
        public string PTTT_GROUP_NAME { get; set; }

        [StringLength(6)]
        public string EMOTIONLESS_METHOD_CODE { get; set; }

        [StringLength(100)]
        public string EMOTIONLESS_METHOD_NAME { get; set; }

        public short? IS_GATHER_DATA { get; set; }

        public short? IS_FEE { get; set; }

        public long? END_TIME { get; set; }

        public long? BEGIN_TIME { get; set; }

        [StringLength(2)]
        public string PTTT_PRIORITY_CODE { get; set; }

        [StringLength(100)]
        public string PTTT_PRIORITY_NAME { get; set; }

        [StringLength(2)]
        public string TREATMENT_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string TREATMENT_TYPE_NAME { get; set; }

        public long? REQ_SURG_TREATMENT_TYPE_ID { get; set; }

        public long? PTTT_PRIORITY_ID { get; set; }

        public long? PTTT_METHOD_ID { get; set; }

        public long? PTTT_GROUP_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string EXECUTE_ROOM_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string EXECUTE_ROOM_NAME { get; set; }

        [StringLength(50)]
        public string EXECUTE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string EXECUTE_USERNAME { get; set; }

        [Required]
        [StringLength(12)]
        public string TDL_TREATMENT_CODE { get; set; }

        [Required]
        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        [Required]
        [StringLength(12)]
        public string SERVICE_REQ_CODE { get; set; }

        public long SERVICE_REQ_STT_ID { get; set; }

        public long? SERVICE_PTTT_GROUP_ID { get; set; }

        [Required]
        [StringLength(2)]
        public string SERVICE_PTTT_GROUP_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_PTTT_GROUP_NAME { get; set; }
    }
}

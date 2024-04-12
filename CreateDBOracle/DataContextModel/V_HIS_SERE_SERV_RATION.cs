namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_SERE_SERV_RATION")]
    public partial class V_HIS_SERE_SERV_RATION
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

        public long SERVICE_ID { get; set; }

        public long SERVICE_REQ_ID { get; set; }

        public long PATIENT_TYPE_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal PRICE { get; set; }

        public decimal? DISCOUNT { get; set; }

        public decimal? VAT_RATIO { get; set; }

        [StringLength(500)]
        public string INSTRUCTION_NOTE { get; set; }

        public long? OTHER_PAY_SOURCE_ID { get; set; }

        public long? PRIMARY_PATIENT_TYPE_ID { get; set; }

        public decimal? ACTUAL_PRICE { get; set; }

        [Required]
        [StringLength(25)]
        public string SERVICE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string SERVICE_NAME { get; set; }

        public long SERVICE_UNIT_ID { get; set; }

        public long? RATION_GROUP_ID { get; set; }

        [Required]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        [StringLength(200)]
        public string OTHER_PAY_SOURCE_NAME { get; set; }

        [StringLength(20)]
        public string OTHER_PAY_SOURCE_CODE { get; set; }

        public long? RATION_TIME_ID { get; set; }

        public long INTRUCTION_TIME { get; set; }

        [StringLength(50)]
        public string REQUEST_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REQUEST_USERNAME { get; set; }

        public long TREATMENT_ID { get; set; }

        public long? TRACKING_ID { get; set; }

        [Required]
        [StringLength(12)]
        public string SERVICE_REQ_CODE { get; set; }

        public long EXECUTE_ROOM_ID { get; set; }

        public long REQUEST_ROOM_ID { get; set; }

        public long REQUEST_DEPARTMENT_ID { get; set; }

        [StringLength(2)]
        public string RATION_TIME_CODE { get; set; }

        [StringLength(100)]
        public string RATION_TIME_NAME { get; set; }

        [Required]
        [StringLength(6)]
        public string PATIENT_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string PATIENT_TYPE_NAME { get; set; }

        public short? IS_RATION { get; set; }

        [StringLength(6)]
        public string PRIMARY_PATIENT_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string PRIMARY_PATIENT_TYPE_NAME { get; set; }

        public long? TDL_PATIENT_CLASSIFY_ID { get; set; }

        public long IN_TIME { get; set; }

        [Required]
        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }
    }
}

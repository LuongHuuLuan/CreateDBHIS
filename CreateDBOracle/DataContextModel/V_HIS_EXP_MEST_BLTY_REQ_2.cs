namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_EXP_MEST_BLTY_REQ_2")]
    public partial class V_HIS_EXP_MEST_BLTY_REQ_2
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

        public long EXP_MEST_ID { get; set; }

        public long BLOOD_TYPE_ID { get; set; }

        public long? BLOOD_ABO_ID { get; set; }

        public long? BLOOD_RH_ID { get; set; }

        public long? PATIENT_TYPE_ID { get; set; }

        public long AMOUNT { get; set; }

        public long? NUM_ORDER { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        public short? IS_EXPEND { get; set; }

        public long? SERE_SERV_PARENT_ID { get; set; }

        public short? IS_OUT_PARENT_FEE { get; set; }

        public decimal? DD_AMOUNT { get; set; }

        public long TDL_MEDI_STOCK_ID { get; set; }

        public long? REQ_BLOOD_TYPE_ID { get; set; }

        public long? REQ_BLOOD_ABO_ID { get; set; }

        public long? REQ_BLOOD_RH_ID { get; set; }

        public long? REQ_AMOUNT { get; set; }

        public decimal? PRICE { get; set; }

        public decimal? VAT_RATIO { get; set; }

        public long? SERVICE_REQ_ID { get; set; }

        [StringLength(20)]
        public string EXP_MEST_SUB_CODE { get; set; }

        [StringLength(50)]
        public string EXP_MEST_SUB_CODE_2 { get; set; }

        public long? TDL_TREATMENT_ID { get; set; }

        public long EXP_MEST_STT_ID { get; set; }

        [Required]
        [StringLength(25)]
        public string BLOOD_TYPE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string BLOOD_TYPE_NAME { get; set; }

        public long SERVICE_ID { get; set; }

        [StringLength(2)]
        public string BLOOD_ABO_CODE { get; set; }

        [StringLength(3)]
        public string BLOOD_RH_CODE { get; set; }

        public long INTRUCTION_TIME { get; set; }

        public long INTRUCTION_DATE { get; set; }

        public long? TRACKING_ID { get; set; }

        [StringLength(50)]
        public string REQUEST_LOGINNAME { get; set; }

        public long REQUEST_DEPARTMENT_ID { get; set; }

        public long REQUEST_ROOM_ID { get; set; }

        public long SERVICE_REQ_TYPE_ID { get; set; }

        public long SERVICE_REQ_STT_ID { get; set; }

        public short? IS_NO_EXECUTE { get; set; }

        [Required]
        [StringLength(12)]
        public string SERVICE_REQ_CODE { get; set; }

        [Required]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        public long SERVICE_TYPE_ID { get; set; }

        [Required]
        [StringLength(25)]
        public string SERVICE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string SERVICE_NAME { get; set; }
    }
}

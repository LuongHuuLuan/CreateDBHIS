namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_EXP_MEST_MEDICINE_4")]
    public partial class V_HIS_EXP_MEST_MEDICINE_4
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

        public decimal? BK_AMOUNT { get; set; }

        public long? EXP_MEST_ID { get; set; }

        public long? MEDICINE_ID { get; set; }

        public long? TDL_MEDI_STOCK_ID { get; set; }

        public long? MEDI_STOCK_PERIOD_ID { get; set; }

        public long? TDL_MEDICINE_TYPE_ID { get; set; }

        public long? TDL_AGGR_EXP_MEST_ID { get; set; }

        public long? EXP_MEST_METY_REQ_ID { get; set; }

        public long? CK_IMP_MEST_MEDICINE_ID { get; set; }

        public short? IS_EXPORT { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal? PRICE { get; set; }

        public decimal? VAT_RATIO { get; set; }

        public decimal? DISCOUNT { get; set; }

        public long? NUM_ORDER { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        [StringLength(50)]
        public string APPROVAL_LOGINNAME { get; set; }

        [StringLength(100)]
        public string APPROVAL_USERNAME { get; set; }

        public long? APPROVAL_TIME { get; set; }

        public long? APPROVAL_DATE { get; set; }

        [StringLength(50)]
        public string EXP_LOGINNAME { get; set; }

        [StringLength(100)]
        public string EXP_USERNAME { get; set; }

        public long? EXP_TIME { get; set; }

        public long? EXP_DATE { get; set; }

        public decimal? TH_AMOUNT { get; set; }

        public long? PATIENT_TYPE_ID { get; set; }

        public long? SERE_SERV_PARENT_ID { get; set; }

        public short? IS_EXPEND { get; set; }

        public short? IS_OUT_PARENT_FEE { get; set; }

        public long? USE_TIME_TO { get; set; }

        [StringLength(1000)]
        public string TUTORIAL { get; set; }

        public long? TDL_SERVICE_REQ_ID { get; set; }

        public long? TDL_TREATMENT_ID { get; set; }

        public short? IS_USE_CLIENT_PRICE { get; set; }

        public decimal? VIR_PRICE { get; set; }

        public long? VACCINATION_RESULT_ID { get; set; }

        public long? TDL_VACCINATION_ID { get; set; }

        public decimal? SPEED { get; set; }

        public long? EXPEND_TYPE_ID { get; set; }

        public short? IS_NOT_PRES { get; set; }

        public short? USE_ORIGINAL_UNIT_FOR_PRES { get; set; }

        public decimal? BCS_REQ_AMOUNT { get; set; }

        public long? DAY_COUNT { get; set; }

        [StringLength(10)]
        public string MORNING { get; set; }

        [StringLength(10)]
        public string NOON { get; set; }

        [StringLength(10)]
        public string AFTERNOON { get; set; }

        [StringLength(10)]
        public string EVENING { get; set; }

        public long? HTU_ID { get; set; }

        [StringLength(10)]
        public string BREATH_SPEED { get; set; }

        [StringLength(10)]
        public string BREATH_TIME { get; set; }

        public long? PREVIOUS_USING_COUNT { get; set; }

        public short? IS_USED { get; set; }

        [Required]
        [StringLength(12)]
        public string EXP_MEST_CODE { get; set; }

        public long EXP_MEST_TYPE_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string EXP_MEST_TYPE_NAME { get; set; }

        [Required]
        [StringLength(2)]
        public string EXP_MEST_TYPE_CODE { get; set; }

        [Required]
        [StringLength(20)]
        public string MEDI_STOCK_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string MEDI_STOCK_NAME { get; set; }

        [Required]
        [StringLength(25)]
        public string MEDICINE_TYPE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string MEDICINE_TYPE_NAME { get; set; }

        public short? IS_OUT_HOSPITAL { get; set; }

        [StringLength(100)]
        public string MEDI_STOCK_PERIOD_NAME { get; set; }
    }
}

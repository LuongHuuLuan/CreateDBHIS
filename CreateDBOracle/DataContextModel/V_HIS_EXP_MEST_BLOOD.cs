namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_EXP_MEST_BLOOD")]
    public partial class V_HIS_EXP_MEST_BLOOD
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

        public long BLOOD_ID { get; set; }

        public long TDL_MEDI_STOCK_ID { get; set; }

        public long? MEDI_STOCK_PERIOD_ID { get; set; }

        public decimal? PRICE { get; set; }

        public decimal? VAT_RATIO { get; set; }

        public decimal? DISCOUNT { get; set; }

        public long? NUM_ORDER { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        public short? IS_EXPORT { get; set; }

        public short? IS_TH { get; set; }

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

        public long TDL_BLOOD_TYPE_ID { get; set; }

        public long? EXP_MEST_BLTY_REQ_ID { get; set; }

        public long? PATIENT_TYPE_ID { get; set; }

        public long? SERE_SERV_PARENT_ID { get; set; }

        public short? IS_OUT_PARENT_FEE { get; set; }

        public long? TDL_SERVICE_REQ_ID { get; set; }

        public long? TDL_TREATMENT_ID { get; set; }

        public decimal? VIR_PRICE { get; set; }

        [StringLength(3)]
        public string PATIENT_BLOOD_ABO_CODE { get; set; }

        [StringLength(3)]
        public string PATIENT_BLOOD_RH_CODE { get; set; }

        [StringLength(100)]
        public string PUC { get; set; }

        [StringLength(100)]
        public string TEST_TUBE { get; set; }

        [StringLength(100)]
        public string SCANGEL_GELCARD { get; set; }

        [StringLength(100)]
        public string COOMBS { get; set; }

        public long? SALT_ENVI { get; set; }

        public long? ANTI_GLOBULIN_ENVI { get; set; }

        [StringLength(100)]
        public string TEST_TUBE_TWO { get; set; }

        public long? SALT_ENVI_TWO { get; set; }

        public long? ANTI_GLOBULIN_ENVI_TWO { get; set; }

        public decimal? AC_SELF_ENVIDENCE { get; set; }

        public decimal? AC_SELF_ENVIDENCE_SECOND { get; set; }

        [Required]
        [StringLength(12)]
        public string EXP_MEST_CODE { get; set; }

        public long EXP_MEST_TYPE_ID { get; set; }

        public long? AGGR_EXP_MEST_ID { get; set; }

        public long MEDI_STOCK_ID { get; set; }

        public long EXP_MEST_STT_ID { get; set; }

        public long REQ_ROOM_ID { get; set; }

        public long REQ_DEPARTMENT_ID { get; set; }

        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        [StringLength(12)]
        public string TDL_TREATMENT_CODE { get; set; }

        [Required]
        [StringLength(20)]
        public string BLOOD_CODE { get; set; }

        public long BLOOD_TYPE_ID { get; set; }

        public long BLOOD_ABO_ID { get; set; }

        public long? BLOOD_RH_ID { get; set; }

        public decimal IMP_PRICE { get; set; }

        public decimal IMP_VAT_RATIO { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        public long? IMP_TIME { get; set; }

        [StringLength(100)]
        public string PACKAGE_NUMBER { get; set; }

        public long? EXPIRED_DATE { get; set; }

        [StringLength(50)]
        public string BID_NUM_ORDER { get; set; }

        public long? BID_ID { get; set; }

        public long? IMP_SOURCE_ID { get; set; }

        public long? SUPPLIER_ID { get; set; }

        [StringLength(100)]
        public string GIVE_NAME { get; set; }

        [StringLength(20)]
        public string GIVE_CODE { get; set; }

        public long? PACKING_TIME { get; set; }

        [Required]
        [StringLength(25)]
        public string BLOOD_TYPE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string BLOOD_TYPE_NAME { get; set; }

        public long SERVICE_ID { get; set; }

        public long? BLOOD_TYPE_NUM_ORDER { get; set; }

        public long BLOOD_VOLUME_ID { get; set; }

        [StringLength(100)]
        public string ELEMENT { get; set; }

        public long SERVICE_UNIT_ID { get; set; }

        public decimal VOLUME { get; set; }

        [Required]
        [StringLength(2)]
        public string BLOOD_ABO_CODE { get; set; }

        [StringLength(3)]
        public string BLOOD_RH_CODE { get; set; }

        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        [StringLength(30)]
        public string BID_NUMBER { get; set; }

        [StringLength(500)]
        public string BID_NAME { get; set; }

        [StringLength(2)]
        public string IMP_SOURCE_CODE { get; set; }

        [StringLength(100)]
        public string IMP_SOURCE_NAME { get; set; }

        [StringLength(10)]
        public string SUPPLIER_CODE { get; set; }

        [StringLength(1000)]
        public string SUPPLIER_NAME { get; set; }

        [StringLength(6)]
        public string PATIENT_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string PATIENT_TYPE_NAME { get; set; }
    }
}

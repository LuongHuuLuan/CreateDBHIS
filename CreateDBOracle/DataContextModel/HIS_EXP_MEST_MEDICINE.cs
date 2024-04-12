namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_EXP_MEST_MEDICINE")]
    public partial class HIS_EXP_MEST_MEDICINE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_EXP_MEST_MEDICINE()
        {
            HIS_BCS_METY_REQ_DT = new HashSet<HIS_BCS_METY_REQ_DT>();
            HIS_IMP_MEST_MEDI_REQ = new HashSet<HIS_IMP_MEST_MEDI_REQ>();
            HIS_IMP_MEST_MEDICINE1 = new HashSet<HIS_IMP_MEST_MEDICINE>();
            HIS_MEDICINE_BEAN = new HashSet<HIS_MEDICINE_BEAN>();
            HIS_SERE_SERV1 = new HashSet<HIS_SERE_SERV>();
        }

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

        public long? SERVICE_CONDITION_ID { get; set; }

        public short? IS_CREATED_BY_APPROVAL { get; set; }

        public long? OTHER_PAY_SOURCE_ID { get; set; }

        public long? MIXED_INFUSION { get; set; }

        [StringLength(500)]
        public string TUTORIAL_INFUSION { get; set; }

        public short? IS_MIXED_MAIN { get; set; }

        public long? VACCINE_TURN { get; set; }

        public decimal? PRES_AMOUNT { get; set; }

        [StringLength(2000)]
        public string EXCEED_LIMIT_IN_PRES_REASON { get; set; }

        [StringLength(2000)]
        public string EXCEED_LIMIT_IN_DAY_REASON { get; set; }

        [StringLength(2000)]
        public string ODD_PRES_REASON { get; set; }

        [StringLength(2000)]
        public string OVER_RESULT_TEST_REASON { get; set; }

        [StringLength(2000)]
        public string OVER_KIDNEY_REASON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BCS_METY_REQ_DT> HIS_BCS_METY_REQ_DT { get; set; }

        public virtual HIS_EXP_MEST HIS_EXP_MEST { get; set; }

        public virtual HIS_IMP_MEST_MEDICINE HIS_IMP_MEST_MEDICINE { get; set; }

        public virtual HIS_VACCINATION_RESULT HIS_VACCINATION_RESULT { get; set; }

        public virtual HIS_HTU HIS_HTU { get; set; }

        public virtual HIS_SERVICE_CONDITION HIS_SERVICE_CONDITION { get; set; }

        public virtual HIS_OTHER_PAY_SOURCE HIS_OTHER_PAY_SOURCE { get; set; }

        public virtual HIS_MEDICINE HIS_MEDICINE { get; set; }

        public virtual HIS_PATIENT_TYPE HIS_PATIENT_TYPE { get; set; }

        public virtual HIS_SERE_SERV HIS_SERE_SERV { get; set; }

        public virtual HIS_EXP_MEST_METY_REQ HIS_EXP_MEST_METY_REQ { get; set; }

        public virtual HIS_MEDI_STOCK_PERIOD HIS_MEDI_STOCK_PERIOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST_MEDI_REQ> HIS_IMP_MEST_MEDI_REQ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST_MEDICINE> HIS_IMP_MEST_MEDICINE1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICINE_BEAN> HIS_MEDICINE_BEAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV> HIS_SERE_SERV1 { get; set; }
    }
}

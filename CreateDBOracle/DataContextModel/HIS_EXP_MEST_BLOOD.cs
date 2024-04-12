namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_EXP_MEST_BLOOD")]
    public partial class HIS_EXP_MEST_BLOOD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_EXP_MEST_BLOOD()
        {
            HIS_TRANSFUSION_SUM = new HashSet<HIS_TRANSFUSION_SUM>();
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

        public virtual HIS_BLOOD HIS_BLOOD { get; set; }

        public virtual HIS_EXP_MEST HIS_EXP_MEST { get; set; }

        public virtual HIS_PATIENT_TYPE HIS_PATIENT_TYPE { get; set; }

        public virtual HIS_SERE_SERV HIS_SERE_SERV { get; set; }

        public virtual HIS_EXP_MEST_BLTY_REQ HIS_EXP_MEST_BLTY_REQ { get; set; }

        public virtual HIS_MEDI_STOCK_PERIOD HIS_MEDI_STOCK_PERIOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TRANSFUSION_SUM> HIS_TRANSFUSION_SUM { get; set; }
    }
}

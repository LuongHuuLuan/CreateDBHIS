namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_MEDICINE_BEAN")]
    public partial class HIS_MEDICINE_BEAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_MEDICINE_BEAN()
        {
            HIS_MEDICINE_BEAN1 = new HashSet<HIS_MEDICINE_BEAN>();
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

        public long MEDICINE_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public long? MEDI_STOCK_ID { get; set; }

        public long? SOURCE_ID { get; set; }

        public decimal? BK_DECREASE_AMOUNT { get; set; }

        public long? BK_MEDI_STOCK_ID { get; set; }

        public long? EXP_MEST_MEDICINE_ID { get; set; }

        public decimal? DETACH_AMOUNT { get; set; }

        [StringLength(50)]
        public string DETACH_KEY { get; set; }

        public short? IS_TH { get; set; }

        public short? IS_CK { get; set; }

        public short? IS_USE { get; set; }

        [StringLength(4000)]
        public string SESSION_KEY { get; set; }

        public long? SESSION_TIME { get; set; }

        public long TDL_MEDICINE_TYPE_ID { get; set; }

        public short? TDL_MEDICINE_IS_ACTIVE { get; set; }

        public decimal TDL_MEDICINE_IMP_PRICE { get; set; }

        public decimal TDL_MEDICINE_IMP_VAT_RATIO { get; set; }

        public long? TDL_MEDICINE_IMP_TIME { get; set; }

        public long? TDL_MEDICINE_EXPIRED_DATE { get; set; }

        public short? TDL_IS_SALE_EQUAL_IMP_PRICE { get; set; }

        public long TDL_SERVICE_ID { get; set; }

        [StringLength(100)]
        public string TDL_PACKAGE_NUMBER { get; set; }

        [StringLength(500)]
        public string TDL_MEDICINE_REGISTER_NUMBER { get; set; }

        [StringLength(4000)]
        public string LOCKING_REASON { get; set; }

        public virtual HIS_EXP_MEST_MEDICINE HIS_EXP_MEST_MEDICINE { get; set; }

        public virtual HIS_MEDI_STOCK HIS_MEDI_STOCK { get; set; }

        public virtual HIS_MEDICINE HIS_MEDICINE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICINE_BEAN> HIS_MEDICINE_BEAN1 { get; set; }

        public virtual HIS_MEDICINE_BEAN HIS_MEDICINE_BEAN2 { get; set; }
    }
}

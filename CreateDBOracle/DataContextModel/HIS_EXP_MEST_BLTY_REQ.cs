namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_EXP_MEST_BLTY_REQ")]
    public partial class HIS_EXP_MEST_BLTY_REQ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_EXP_MEST_BLTY_REQ()
        {
            HIS_EXP_MEST_BLOOD = new HashSet<HIS_EXP_MEST_BLOOD>();
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

        public virtual HIS_BLOOD_ABO HIS_BLOOD_ABO { get; set; }

        public virtual HIS_BLOOD_RH HIS_BLOOD_RH { get; set; }

        public virtual HIS_BLOOD_TYPE HIS_BLOOD_TYPE { get; set; }

        public virtual HIS_EXP_MEST HIS_EXP_MEST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_BLOOD> HIS_EXP_MEST_BLOOD { get; set; }

        public virtual HIS_PATIENT_TYPE HIS_PATIENT_TYPE { get; set; }
    }
}

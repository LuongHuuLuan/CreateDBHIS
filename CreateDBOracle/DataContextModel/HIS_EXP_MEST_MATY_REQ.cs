namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_EXP_MEST_MATY_REQ")]
    public partial class HIS_EXP_MEST_MATY_REQ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_EXP_MEST_MATY_REQ()
        {
            HIS_BCS_MATY_REQ_DT = new HashSet<HIS_BCS_MATY_REQ_DT>();
            HIS_BCS_MATY_REQ_REQ = new HashSet<HIS_BCS_MATY_REQ_REQ>();
            HIS_BCS_MATY_REQ_REQ1 = new HashSet<HIS_BCS_MATY_REQ_REQ>();
            HIS_EXP_MEST_MATERIAL = new HashSet<HIS_EXP_MEST_MATERIAL>();
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

        public long MATERIAL_TYPE_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public long? NUM_ORDER { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        public long TDL_MEDI_STOCK_ID { get; set; }

        public decimal? DD_AMOUNT { get; set; }

        public long? TREATMENT_ID { get; set; }

        public decimal? BCS_REQ_AMOUNT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BCS_MATY_REQ_DT> HIS_BCS_MATY_REQ_DT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BCS_MATY_REQ_REQ> HIS_BCS_MATY_REQ_REQ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BCS_MATY_REQ_REQ> HIS_BCS_MATY_REQ_REQ1 { get; set; }

        public virtual HIS_EXP_MEST HIS_EXP_MEST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_MATERIAL> HIS_EXP_MEST_MATERIAL { get; set; }

        public virtual HIS_MATERIAL_TYPE HIS_MATERIAL_TYPE { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }
    }
}

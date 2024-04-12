namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SERVICE_UNIT")]
    public partial class HIS_SERVICE_UNIT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_SERVICE_UNIT()
        {
            HIS_BILL_GOODS = new HashSet<HIS_BILL_GOODS>();
            HIS_DEBT_GOODS = new HashSet<HIS_DEBT_GOODS>();
            HIS_EMTE_MATERIAL_TYPE = new HashSet<HIS_EMTE_MATERIAL_TYPE>();
            HIS_EMTE_MEDICINE_TYPE = new HashSet<HIS_EMTE_MEDICINE_TYPE>();
            HIS_INFUSION = new HashSet<HIS_INFUSION>();
            HIS_MATERIAL_TYPE = new HashSet<HIS_MATERIAL_TYPE>();
            HIS_MEDICINE_TYPE = new HashSet<HIS_MEDICINE_TYPE>();
            HIS_NONE_MEDI_SERVICE = new HashSet<HIS_NONE_MEDI_SERVICE>();
            HIS_SERVICE = new HashSet<HIS_SERVICE>();
            HIS_SERVICE_MATY = new HashSet<HIS_SERVICE_MATY>();
            HIS_SERVICE_METY = new HashSet<HIS_SERVICE_METY>();
            HIS_SERVICE_UNIT1 = new HashSet<HIS_SERVICE_UNIT>();
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

        [Required]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        [StringLength(10)]
        public string SERVICE_UNIT_SYMBOL { get; set; }

        public long? MEDICINE_NUM_ORDER { get; set; }

        public long? MATERIAL_NUM_ORDER { get; set; }

        public long? CONVERT_ID { get; set; }

        public decimal? CONVERT_RATIO { get; set; }

        public short? IS_PRIMARY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BILL_GOODS> HIS_BILL_GOODS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEBT_GOODS> HIS_DEBT_GOODS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EMTE_MATERIAL_TYPE> HIS_EMTE_MATERIAL_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EMTE_MEDICINE_TYPE> HIS_EMTE_MEDICINE_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_INFUSION> HIS_INFUSION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MATERIAL_TYPE> HIS_MATERIAL_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICINE_TYPE> HIS_MEDICINE_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_NONE_MEDI_SERVICE> HIS_NONE_MEDI_SERVICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE> HIS_SERVICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_MATY> HIS_SERVICE_MATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_METY> HIS_SERVICE_METY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_UNIT> HIS_SERVICE_UNIT1 { get; set; }

        public virtual HIS_SERVICE_UNIT HIS_SERVICE_UNIT2 { get; set; }
    }
}

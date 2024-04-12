namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_MEDI_STOCK")]
    public partial class HIS_MEDI_STOCK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_MEDI_STOCK()
        {
            HIS_BLOOD = new HashSet<HIS_BLOOD>();
            HIS_DISPENSE = new HashSet<HIS_DISPENSE>();
            HIS_EXP_MEST = new HashSet<HIS_EXP_MEST>();
            HIS_EXP_MEST1 = new HashSet<HIS_EXP_MEST>();
            HIS_IMP_MEST = new HashSet<HIS_IMP_MEST>();
            HIS_IMP_MEST1 = new HashSet<HIS_IMP_MEST>();
            HIS_MATERIAL_BEAN = new HashSet<HIS_MATERIAL_BEAN>();
            HIS_MEDI_STOCK_BLTY = new HashSet<HIS_MEDI_STOCK_BLTY>();
            HIS_MEDI_STOCK_EXTY = new HashSet<HIS_MEDI_STOCK_EXTY>();
            HIS_MEDI_STOCK1 = new HashSet<HIS_MEDI_STOCK>();
            HIS_MEDI_STOCK_IMTY = new HashSet<HIS_MEDI_STOCK_IMTY>();
            HIS_MEDI_STOCK_MATY = new HashSet<HIS_MEDI_STOCK_MATY>();
            HIS_MEDI_STOCK_MATY1 = new HashSet<HIS_MEDI_STOCK_MATY>();
            HIS_MEDI_STOCK_METY = new HashSet<HIS_MEDI_STOCK_METY>();
            HIS_MEDI_STOCK_METY1 = new HashSet<HIS_MEDI_STOCK_METY>();
            HIS_MEDI_STOCK_PERIOD = new HashSet<HIS_MEDI_STOCK_PERIOD>();
            HIS_MEDICINE_BEAN = new HashSet<HIS_MEDICINE_BEAN>();
            HIS_MEST_MATY_DEPA = new HashSet<HIS_MEST_MATY_DEPA>();
            HIS_MEST_METY_DEPA = new HashSet<HIS_MEST_METY_DEPA>();
            HIS_MEST_METY_UNIT = new HashSet<HIS_MEST_METY_UNIT>();
            HIS_MEST_PATIENT_TYPE = new HashSet<HIS_MEST_PATIENT_TYPE>();
            HIS_MEST_PATY_SUB = new HashSet<HIS_MEST_PATY_SUB>();
            HIS_MEST_PATY_TRTY = new HashSet<HIS_MEST_PATY_TRTY>();
            HIS_MEST_PERIOD_MATE = new HashSet<HIS_MEST_PERIOD_MATE>();
            HIS_MEST_PERIOD_MEDI = new HashSet<HIS_MEST_PERIOD_MEDI>();
            HIS_MEST_ROOM = new HashSet<HIS_MEST_ROOM>();
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
        [StringLength(20)]
        public string MEDI_STOCK_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string MEDI_STOCK_NAME { get; set; }

        public long ROOM_ID { get; set; }

        public long? PARENT_ID { get; set; }

        [StringLength(200)]
        public string BHYT_HEAD_CODE { get; set; }

        [StringLength(200)]
        public string NOT_IN_BHYT_HEAD_CODE { get; set; }

        public short? IS_ALLOW_IMP_SUPPLIER { get; set; }

        public short? IS_CABINET { get; set; }

        public short? IS_BUSINESS { get; set; }

        public short? IS_AUTO_CREATE_CHMS_IMP { get; set; }

        public short? IS_GOODS_RESTRICT { get; set; }

        public short? IS_ODD { get; set; }

        public short? IS_BLOOD { get; set; }

        public short? IS_SHOW_DDT { get; set; }

        public short? IS_NEW_MEDICINE { get; set; }

        public short? IS_TRADITIONAL_MEDICINE { get; set; }

        public short? IS_PLANNING_TRANS_AS_DEFAULT { get; set; }

        public short? CABINET_MANAGE_OPTION { get; set; }

        public short? IS_SHOW_INPATIENT_RETURN_PRES { get; set; }

        public short? IS_DRUG_STORE { get; set; }

        public short? IS_FOR_REJECTED_MOBA { get; set; }

        public short? IS_MOBA_CHANGE_AMOUNT { get; set; }

        [StringLength(200)]
        public string PATIENT_CLASSIFY_IDS { get; set; }

        public short? IS_SHOW_DRUG_STORE { get; set; }

        public short? IS_EXPEND { get; set; }

        public short? IS_AUTO_CREATE_REUSABLE_IMP { get; set; }

        public short? DO_NOT_IMP_MEDICINE { get; set; }

        public short? DO_NOT_IMP_MATERIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BLOOD> HIS_BLOOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DISPENSE> HIS_DISPENSE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST> HIS_EXP_MEST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST> HIS_EXP_MEST1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST> HIS_IMP_MEST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST> HIS_IMP_MEST1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MATERIAL_BEAN> HIS_MATERIAL_BEAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_STOCK_BLTY> HIS_MEDI_STOCK_BLTY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_STOCK_EXTY> HIS_MEDI_STOCK_EXTY { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_STOCK> HIS_MEDI_STOCK1 { get; set; }

        public virtual HIS_MEDI_STOCK HIS_MEDI_STOCK2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_STOCK_IMTY> HIS_MEDI_STOCK_IMTY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_STOCK_MATY> HIS_MEDI_STOCK_MATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_STOCK_MATY> HIS_MEDI_STOCK_MATY1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_STOCK_METY> HIS_MEDI_STOCK_METY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_STOCK_METY> HIS_MEDI_STOCK_METY1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_STOCK_PERIOD> HIS_MEDI_STOCK_PERIOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICINE_BEAN> HIS_MEDICINE_BEAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_MATY_DEPA> HIS_MEST_MATY_DEPA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_METY_DEPA> HIS_MEST_METY_DEPA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_METY_UNIT> HIS_MEST_METY_UNIT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_PATIENT_TYPE> HIS_MEST_PATIENT_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_PATY_SUB> HIS_MEST_PATY_SUB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_PATY_TRTY> HIS_MEST_PATY_TRTY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_PERIOD_MATE> HIS_MEST_PERIOD_MATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_PERIOD_MEDI> HIS_MEST_PERIOD_MEDI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_ROOM> HIS_MEST_ROOM { get; set; }
    }
}

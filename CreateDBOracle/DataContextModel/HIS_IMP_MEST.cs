namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_IMP_MEST")]
    public partial class HIS_IMP_MEST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_IMP_MEST()
        {
            HIS_BLOOD_GIVER = new HashSet<HIS_BLOOD_GIVER>();
            HIS_EXP_MEST = new HashSet<HIS_EXP_MEST>();
            HIS_IMP_MEST_BLOOD = new HashSet<HIS_IMP_MEST_BLOOD>();
            HIS_IMP_MEST1 = new HashSet<HIS_IMP_MEST>();
            HIS_IMP_MEST11 = new HashSet<HIS_IMP_MEST>();
            HIS_IMP_MEST_MATE_REQ = new HashSet<HIS_IMP_MEST_MATE_REQ>();
            HIS_IMP_MEST_MATERIAL = new HashSet<HIS_IMP_MEST_MATERIAL>();
            HIS_IMP_MEST_MEDI_REQ = new HashSet<HIS_IMP_MEST_MEDI_REQ>();
            HIS_IMP_MEST_MEDICINE = new HashSet<HIS_IMP_MEST_MEDICINE>();
            HIS_IMP_MEST_USER = new HashSet<HIS_IMP_MEST_USER>();
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
        [StringLength(12)]
        public string IMP_MEST_CODE { get; set; }

        public long IMP_MEST_TYPE_ID { get; set; }

        public long IMP_MEST_STT_ID { get; set; }

        public long MEDI_STOCK_ID { get; set; }

        public long? MEDI_STOCK_PERIOD_ID { get; set; }

        [StringLength(50)]
        public string IMP_LOGINNAME { get; set; }

        [StringLength(100)]
        public string IMP_USERNAME { get; set; }

        public long? IMP_TIME { get; set; }

        public long? IMP_DATE { get; set; }

        [StringLength(50)]
        public string APPROVAL_LOGINNAME { get; set; }

        [StringLength(100)]
        public string APPROVAL_USERNAME { get; set; }

        public long? APPROVAL_TIME { get; set; }

        [StringLength(50)]
        public string REQ_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REQ_USERNAME { get; set; }

        public long? REQ_ROOM_ID { get; set; }

        public long? REQ_DEPARTMENT_ID { get; set; }

        public long CREATE_DATE { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        public long? CHMS_EXP_MEST_ID { get; set; }

        [StringLength(12)]
        public string TDL_CHMS_EXP_MEST_CODE { get; set; }

        public long? AGGR_IMP_MEST_ID { get; set; }

        [StringLength(12)]
        public string TDL_AGGR_IMP_MEST_CODE { get; set; }

        public long? MOBA_EXP_MEST_ID { get; set; }

        [StringLength(12)]
        public string TDL_MOBA_EXP_MEST_CODE { get; set; }

        public long? TDL_TREATMENT_ID { get; set; }

        public long? DISPENSE_ID { get; set; }

        [StringLength(8)]
        public string TDL_DISPENSE_CODE { get; set; }

        public long? SUPPLIER_ID { get; set; }

        [StringLength(50)]
        public string DOCUMENT_NUMBER { get; set; }

        public long? DOCUMENT_DATE { get; set; }

        public decimal? DOCUMENT_PRICE { get; set; }

        public decimal? DISCOUNT { get; set; }

        public decimal? DISCOUNT_RATIO { get; set; }

        [StringLength(100)]
        public string DELIVERER { get; set; }

        [StringLength(12)]
        public string TDL_TREATMENT_CODE { get; set; }

        public long? TDL_PATIENT_ID { get; set; }

        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        public long? TDL_PATIENT_DOB { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        public long? TDL_PATIENT_GENDER_ID { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        [StringLength(30)]
        public string TDL_PATIENT_FIRST_NAME { get; set; }

        [StringLength(70)]
        public string TDL_PATIENT_LAST_NAME { get; set; }

        public short? TDL_PATIENT_IS_HAS_NOT_DAY_DOB { get; set; }

        [StringLength(50)]
        public string NATIONAL_IMP_MEST_CODE { get; set; }

        public long? IMP_MEST_PROPOSE_ID { get; set; }

        [StringLength(50)]
        public string CREDIT_ACCOUNT { get; set; }

        [StringLength(50)]
        public string DEBIT_ACCOUNT { get; set; }

        [StringLength(20)]
        public string INVOICE_SYMBOL { get; set; }

        public long? CHMS_TYPE_ID { get; set; }

        public long? CHMS_MEDI_STOCK_ID { get; set; }

        public long? SOURCE_MEST_PERIOD_ID { get; set; }

        [StringLength(25)]
        public string IMP_MEST_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string TDL_BID_NAMES { get; set; }

        [StringLength(500)]
        public string TDL_BID_GROUP_CODES { get; set; }

        [StringLength(4000)]
        public string TDL_BID_NUMBERS { get; set; }

        [StringLength(50)]
        public string RECEIVER_LOGINNAME { get; set; }

        [StringLength(100)]
        public string RECEIVER_USERNAME { get; set; }

        [StringLength(50)]
        public string IMP_MEST_SUB_CODE_2 { get; set; }

        public long? SPECIAL_MEDICINE_NUM_ORDER { get; set; }

        public long? SPECIAL_MEDICINE_TYPE { get; set; }

        [StringLength(180)]
        public string VIR_SPECIAL_MEDICINE_NUM_ORDER { get; set; }

        public decimal? VIR_CREATE_YEAR { get; set; }

        public long? MEDICAL_CONTRACT_ID { get; set; }

        public long? APPROVAL_IMP_MEST_ID { get; set; }

        public long? TRACKING_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BLOOD_GIVER> HIS_BLOOD_GIVER { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        public virtual HIS_DISPENSE HIS_DISPENSE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST> HIS_EXP_MEST { get; set; }

        public virtual HIS_EXP_MEST HIS_EXP_MEST1 { get; set; }

        public virtual HIS_EXP_MEST HIS_EXP_MEST2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST_BLOOD> HIS_IMP_MEST_BLOOD { get; set; }

        public virtual HIS_IMP_MEST_TYPE HIS_IMP_MEST_TYPE { get; set; }

        public virtual HIS_IMP_MEST_PROPOSE HIS_IMP_MEST_PROPOSE { get; set; }

        public virtual HIS_MEDI_STOCK HIS_MEDI_STOCK { get; set; }

        public virtual HIS_MEDI_STOCK_PERIOD HIS_MEDI_STOCK_PERIOD { get; set; }

        public virtual HIS_MEDICAL_CONTRACT HIS_MEDICAL_CONTRACT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST> HIS_IMP_MEST1 { get; set; }

        public virtual HIS_IMP_MEST HIS_IMP_MEST2 { get; set; }

        public virtual HIS_MEDI_STOCK HIS_MEDI_STOCK1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST> HIS_IMP_MEST11 { get; set; }

        public virtual HIS_IMP_MEST HIS_IMP_MEST3 { get; set; }

        public virtual HIS_MEDI_STOCK_PERIOD HIS_MEDI_STOCK_PERIOD1 { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        public virtual HIS_SUPPLIER HIS_SUPPLIER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST_MATE_REQ> HIS_IMP_MEST_MATE_REQ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST_MATERIAL> HIS_IMP_MEST_MATERIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST_MEDI_REQ> HIS_IMP_MEST_MEDI_REQ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST_MEDICINE> HIS_IMP_MEST_MEDICINE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST_USER> HIS_IMP_MEST_USER { get; set; }
    }
}

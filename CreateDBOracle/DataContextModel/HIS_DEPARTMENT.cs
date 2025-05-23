namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_DEPARTMENT")]
    public partial class HIS_DEPARTMENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_DEPARTMENT()
        {
            HIS_ACCIDENT_HURT = new HashSet<HIS_ACCIDENT_HURT>();
            HIS_ALERT = new HashSet<HIS_ALERT>();
            HIS_ANTIBIOTIC_REQUEST = new HashSet<HIS_ANTIBIOTIC_REQUEST>();
            HIS_ANTICIPATE = new HashSet<HIS_ANTICIPATE>();
            HIS_AREA = new HashSet<HIS_AREA>();
            HIS_CARE = new HashSet<HIS_CARE>();
            HIS_CARE_SUM = new HashSet<HIS_CARE_SUM>();
            HIS_CARO_DEPARTMENT = new HashSet<HIS_CARO_DEPARTMENT>();
            HIS_CO_TREATMENT = new HashSet<HIS_CO_TREATMENT>();
            HIS_DATA_STORE = new HashSet<HIS_DATA_STORE>();
            HIS_DEBATE = new HashSet<HIS_DEBATE>();
            HIS_DEBATE_EKIP_USER = new HashSet<HIS_DEBATE_EKIP_USER>();
            HIS_DEBATE_TEMP = new HashSet<HIS_DEBATE_TEMP>();
            HIS_DEPARTMENT_TRAN = new HashSet<HIS_DEPARTMENT_TRAN>();
            HIS_DEPOSIT_REQ = new HashSet<HIS_DEPOSIT_REQ>();
            HIS_DHST = new HashSet<HIS_DHST>();
            HIS_EKIP_TEMP = new HashSet<HIS_EKIP_TEMP>();
            HIS_EKIP_TEMP_USER = new HashSet<HIS_EKIP_TEMP_USER>();
            HIS_EKIP_USER = new HashSet<HIS_EKIP_USER>();
            HIS_EMPLOYEE = new HashSet<HIS_EMPLOYEE>();
            HIS_EMR_COVER_CONFIG = new HashSet<HIS_EMR_COVER_CONFIG>();
            HIS_EXP_MEST = new HashSet<HIS_EXP_MEST>();
            HIS_IMP_MEST = new HashSet<HIS_IMP_MEST>();
            HIS_IMP_MEST_PROPOSE = new HashSet<HIS_IMP_MEST_PROPOSE>();
            HIS_INFUSION_SUM = new HashSet<HIS_INFUSION_SUM>();
            HIS_KSK_CONTRACT = new HashSet<HIS_KSK_CONTRACT>();
            HIS_MEDI_REACT_SUM = new HashSet<HIS_MEDI_REACT_SUM>();
            HIS_MEDI_RECORD_BORROW = new HashSet<HIS_MEDI_RECORD_BORROW>();
            HIS_MEDI_RECORD = new HashSet<HIS_MEDI_RECORD>();
            HIS_MEDICINE_INTERACTIVE = new HashSet<HIS_MEDICINE_INTERACTIVE>();
            HIS_MEST_MATY_DEPA = new HashSet<HIS_MEST_MATY_DEPA>();
            HIS_MEST_METY_DEPA = new HashSet<HIS_MEST_METY_DEPA>();
            HIS_MR_CHECK_SUMMARY = new HashSet<HIS_MR_CHECK_SUMMARY>();
            HIS_OBEY_CONTRAINDI = new HashSet<HIS_OBEY_CONTRAINDI>();
            HIS_PTTT_CALENDAR = new HashSet<HIS_PTTT_CALENDAR>();
            HIS_RATION_SUM = new HashSet<HIS_RATION_SUM>();
            HIS_REGISTER_GATE = new HashSet<HIS_REGISTER_GATE>();
            HIS_REJECT_ALERT = new HashSet<HIS_REJECT_ALERT>();
            HIS_ROOM = new HashSet<HIS_ROOM>();
            HIS_SERE_SERV_PTTT_TEMP = new HashSet<HIS_SERE_SERV_PTTT_TEMP>();
            HIS_SERVICE = new HashSet<HIS_SERVICE>();
            HIS_SERVICE_REQ = new HashSet<HIS_SERVICE_REQ>();
            HIS_SERVICE_REQ1 = new HashSet<HIS_SERVICE_REQ>();
            HIS_SEVERE_ILLNESS_INFO = new HashSet<HIS_SEVERE_ILLNESS_INFO>();
            HIS_TEXT_LIB = new HashSet<HIS_TEXT_LIB>();
            HIS_TRACKING = new HashSet<HIS_TRACKING>();
            HIS_TRACKING_TEMP = new HashSet<HIS_TRACKING_TEMP>();
            HIS_TRANSFUSION_SUM = new HashSet<HIS_TRANSFUSION_SUM>();
            HIS_TREATMENT_BORROW = new HashSet<HIS_TREATMENT_BORROW>();
            HIS_TREATMENT = new HashSet<HIS_TREATMENT>();
            HIS_TREATMENT1 = new HashSet<HIS_TREATMENT>();
            HIS_TREATMENT2 = new HashSet<HIS_TREATMENT>();
            HIS_TREATMENT3 = new HashSet<HIS_TREATMENT>();
            HIS_TREATMENT4 = new HashSet<HIS_TREATMENT>();
            HIS_VACCINATION_EXAM = new HashSet<HIS_VACCINATION_EXAM>();
            HIS_VACCINATION_EXAM1 = new HashSet<HIS_VACCINATION_EXAM>();
            HIS_VACCINATION_EXAM2 = new HashSet<HIS_VACCINATION_EXAM>();
            HIS_VACCINATION = new HashSet<HIS_VACCINATION>();
            HIS_VACCINATION1 = new HashSet<HIS_VACCINATION>();
            HIS_VITAMIN_A = new HashSet<HIS_VITAMIN_A>();
            HIS_VITAMIN_A1 = new HashSet<HIS_VITAMIN_A>();
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
        public string DEPARTMENT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        public long BRANCH_ID { get; set; }

        [StringLength(50)]
        public string BHYT_CODE { get; set; }

        public long? NUM_ORDER { get; set; }

        public short? IS_AUTO_RECEIVE_PATIENT { get; set; }

        public short? IS_CLINICAL { get; set; }

        public long? THEORY_PATIENT_COUNT { get; set; }

        public long? REALITY_PATIENT_COUNT { get; set; }

        [Required]
        [StringLength(10)]
        public string G_CODE { get; set; }

        public long? DEFAULT_INSTR_PATIENT_TYPE_ID { get; set; }

        public short? ALLOW_ASSIGN_SURGERY_PRICE { get; set; }

        public decimal? ALLOW_ASSIGN_PACKAGE_PRICE { get; set; }

        [StringLength(20)]
        public string ALLOW_TREATMENT_TYPE_IDS { get; set; }

        public long? REQ_SURG_TREATMENT_TYPE_ID { get; set; }

        [StringLength(50)]
        public string PHONE { get; set; }

        public short? IS_EMERGENCY { get; set; }

        public short? IS_EXAM { get; set; }

        [StringLength(50)]
        public string HEAD_LOGINNAME { get; set; }

        [StringLength(100)]
        public string HEAD_USERNAME { get; set; }

        public short? IS_IN_DEP_STOCK_MOBA { get; set; }

        public long? AUTO_BED_ASSIGN_OPTION { get; set; }

        [StringLength(4000)]
        public string ACCEPTED_ICD_CODES { get; set; }

        public short? WARNING_WHEN_IS_NO_SURG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ACCIDENT_HURT> HIS_ACCIDENT_HURT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ALERT> HIS_ALERT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ANTIBIOTIC_REQUEST> HIS_ANTIBIOTIC_REQUEST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ANTICIPATE> HIS_ANTICIPATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_AREA> HIS_AREA { get; set; }

        public virtual HIS_BRANCH HIS_BRANCH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_CARE> HIS_CARE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_CARE_SUM> HIS_CARE_SUM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_CARO_DEPARTMENT> HIS_CARO_DEPARTMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_CO_TREATMENT> HIS_CO_TREATMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DATA_STORE> HIS_DATA_STORE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEBATE> HIS_DEBATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEBATE_EKIP_USER> HIS_DEBATE_EKIP_USER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEBATE_TEMP> HIS_DEBATE_TEMP { get; set; }

        public virtual HIS_PATIENT_TYPE HIS_PATIENT_TYPE { get; set; }

        public virtual HIS_TREATMENT_TYPE HIS_TREATMENT_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEPARTMENT_TRAN> HIS_DEPARTMENT_TRAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEPOSIT_REQ> HIS_DEPOSIT_REQ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DHST> HIS_DHST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EKIP_TEMP> HIS_EKIP_TEMP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EKIP_TEMP_USER> HIS_EKIP_TEMP_USER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EKIP_USER> HIS_EKIP_USER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EMPLOYEE> HIS_EMPLOYEE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EMR_COVER_CONFIG> HIS_EMR_COVER_CONFIG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST> HIS_EXP_MEST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST> HIS_IMP_MEST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST_PROPOSE> HIS_IMP_MEST_PROPOSE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_INFUSION_SUM> HIS_INFUSION_SUM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_KSK_CONTRACT> HIS_KSK_CONTRACT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_REACT_SUM> HIS_MEDI_REACT_SUM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_RECORD_BORROW> HIS_MEDI_RECORD_BORROW { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_RECORD> HIS_MEDI_RECORD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICINE_INTERACTIVE> HIS_MEDICINE_INTERACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_MATY_DEPA> HIS_MEST_MATY_DEPA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_METY_DEPA> HIS_MEST_METY_DEPA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MR_CHECK_SUMMARY> HIS_MR_CHECK_SUMMARY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_OBEY_CONTRAINDI> HIS_OBEY_CONTRAINDI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PTTT_CALENDAR> HIS_PTTT_CALENDAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_RATION_SUM> HIS_RATION_SUM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_REGISTER_GATE> HIS_REGISTER_GATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_REJECT_ALERT> HIS_REJECT_ALERT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ROOM> HIS_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_PTTT_TEMP> HIS_SERE_SERV_PTTT_TEMP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE> HIS_SERVICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_REQ> HIS_SERVICE_REQ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_REQ> HIS_SERVICE_REQ1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SEVERE_ILLNESS_INFO> HIS_SEVERE_ILLNESS_INFO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TEXT_LIB> HIS_TEXT_LIB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TRACKING> HIS_TRACKING { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TRACKING_TEMP> HIS_TRACKING_TEMP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TRANSFUSION_SUM> HIS_TRANSFUSION_SUM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TREATMENT_BORROW> HIS_TREATMENT_BORROW { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TREATMENT> HIS_TREATMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TREATMENT> HIS_TREATMENT1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TREATMENT> HIS_TREATMENT2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TREATMENT> HIS_TREATMENT3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TREATMENT> HIS_TREATMENT4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VACCINATION_EXAM> HIS_VACCINATION_EXAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VACCINATION_EXAM> HIS_VACCINATION_EXAM1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VACCINATION_EXAM> HIS_VACCINATION_EXAM2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VACCINATION> HIS_VACCINATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VACCINATION> HIS_VACCINATION1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VITAMIN_A> HIS_VITAMIN_A { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VITAMIN_A> HIS_VITAMIN_A1 { get; set; }
    }
}

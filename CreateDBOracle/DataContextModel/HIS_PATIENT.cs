namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_PATIENT")]
    public partial class HIS_PATIENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_PATIENT()
        {
            HIS_APPOINTMENT = new HashSet<HIS_APPOINTMENT>();
            HIS_CARD = new HashSet<HIS_CARD>();
            HIS_CONTACT_POINT = new HashSet<HIS_CONTACT_POINT>();
            HIS_HOLD_RETURN = new HashSet<HIS_HOLD_RETURN>();
            HIS_MEDI_RECORD = new HashSet<HIS_MEDI_RECORD>();
            HIS_PATIENT1 = new HashSet<HIS_PATIENT>();
            HIS_PATIENT_PROGRAM = new HashSet<HIS_PATIENT_PROGRAM>();
            HIS_REGISTER_REQ = new HashSet<HIS_REGISTER_REQ>();
            HIS_TREATMENT = new HashSet<HIS_TREATMENT>();
            HIS_VACCINATION_EXAM = new HashSet<HIS_VACCINATION_EXAM>();
            HIS_VACCINATION = new HashSet<HIS_VACCINATION>();
            HIS_VITAMIN_A = new HashSet<HIS_VITAMIN_A>();
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
        [StringLength(10)]
        public string PATIENT_CODE { get; set; }

        [Required]
        [StringLength(30)]
        public string FIRST_NAME { get; set; }

        [StringLength(70)]
        public string LAST_NAME { get; set; }

        [StringLength(101)]
        public string VIR_PATIENT_NAME { get; set; }

        public long GENDER_ID { get; set; }

        public long DOB { get; set; }

        public short? IS_HAS_NOT_DAY_DOB { get; set; }

        [StringLength(9)]
        public string PERSON_CODE { get; set; }

        public long? REFERENCE_ID { get; set; }

        [StringLength(3)]
        public string NATIONAL_CODE { get; set; }

        [StringLength(100)]
        public string NATIONAL_NAME { get; set; }

        [StringLength(2)]
        public string ETHNIC_CODE { get; set; }

        [StringLength(100)]
        public string ETHNIC_NAME { get; set; }

        [StringLength(100)]
        public string RELIGION_NAME { get; set; }

        [StringLength(3)]
        public string PROVINCE_CODE { get; set; }

        [StringLength(100)]
        public string PROVINCE_NAME { get; set; }

        [StringLength(4)]
        public string DISTRICT_CODE { get; set; }

        [StringLength(100)]
        public string DISTRICT_NAME { get; set; }

        [StringLength(6)]
        public string COMMUNE_CODE { get; set; }

        [StringLength(100)]
        public string COMMUNE_NAME { get; set; }

        [StringLength(200)]
        public string ADDRESS { get; set; }

        [StringLength(506)]
        public string VIR_ADDRESS { get; set; }

        [StringLength(100)]
        public string HT_PROVINCE_NAME { get; set; }

        [StringLength(100)]
        public string HT_DISTRICT_NAME { get; set; }

        [StringLength(100)]
        public string HT_COMMUNE_NAME { get; set; }

        [StringLength(200)]
        public string HT_ADDRESS { get; set; }

        [StringLength(506)]
        public string VIR_HT_ADDRESS { get; set; }

        [StringLength(12)]
        public string MOBILE { get; set; }

        [StringLength(12)]
        public string PHONE { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(50)]
        public string RELATIVE_TYPE { get; set; }

        [StringLength(100)]
        public string RELATIVE_NAME { get; set; }

        [StringLength(200)]
        public string RELATIVE_ADDRESS { get; set; }

        [StringLength(12)]
        public string RELATIVE_CMND_NUMBER { get; set; }

        [StringLength(12)]
        public string RELATIVE_MOBILE { get; set; }

        [StringLength(12)]
        public string RELATIVE_PHONE { get; set; }

        [StringLength(10)]
        public string CAREER_CODE { get; set; }

        [StringLength(1000)]
        public string CAREER_NAME { get; set; }

        public long? CAREER_ID { get; set; }

        public long? WORK_PLACE_ID { get; set; }

        [StringLength(500)]
        public string WORK_PLACE { get; set; }

        public long? MILITARY_RANK_ID { get; set; }

        public long? BRANCH_ID { get; set; }

        public short? IS_OWN_BRANCH_WAIT { get; set; }

        public long? RECENT_SERVICE_ID { get; set; }

        public long? RECENT_ROOM_ID { get; set; }

        public short? IS_CHRONIC { get; set; }

        [StringLength(500)]
        public string BHYT_URL { get; set; }

        [StringLength(500)]
        public string AVATAR_URL { get; set; }

        [StringLength(15)]
        public string TDL_HEIN_CARD_NUMBER { get; set; }

        [StringLength(20)]
        public string PATIENT_STORE_CODE { get; set; }

        [StringLength(20)]
        public string HRM_EMPLOYEE_CODE { get; set; }

        [StringLength(3)]
        public string BORN_PROVINCE_CODE { get; set; }

        [StringLength(100)]
        public string BORN_PROVINCE_NAME { get; set; }

        [StringLength(3)]
        public string BLOOD_ABO_CODE { get; set; }

        [StringLength(3)]
        public string BLOOD_RH_CODE { get; set; }

        [StringLength(9)]
        public string CMND_NUMBER { get; set; }

        public long? CMND_DATE { get; set; }

        [StringLength(100)]
        public string CMND_PLACE { get; set; }

        [StringLength(12)]
        public string CCCD_NUMBER { get; set; }

        public long? CCCD_DATE { get; set; }

        [StringLength(100)]
        public string CCCD_PLACE { get; set; }

        [StringLength(100)]
        public string MOTHER_NAME { get; set; }

        [StringLength(100)]
        public string FATHER_NAME { get; set; }

        [StringLength(9)]
        public string HOUSEHOLD_CODE { get; set; }

        [StringLength(100)]
        public string HOUSEHOLD_RELATION_NAME { get; set; }

        [StringLength(3000)]
        public string PT_PATHOLOGICAL_HISTORY { get; set; }

        [StringLength(3000)]
        public string PT_PATHOLOGICAL_HISTORY_FAMILY { get; set; }

        [StringLength(50)]
        public string ACCOUNT_NUMBER { get; set; }

        [StringLength(20)]
        public string TAX_CODE { get; set; }

        [StringLength(4000)]
        public string OWN_BRANCH_IDS { get; set; }

        [StringLength(32)]
        public string UUID { get; set; }

        [StringLength(10)]
        public string SYS_CODE { get; set; }

        [StringLength(15)]
        public string UUID_BHYT_NUMBER { get; set; }

        public short? IS_CREATE_UUID_FAIL { get; set; }

        public short? IS_UPDATE_UUID_FAIL { get; set; }

        [StringLength(10)]
        public string REGISTER_CODE { get; set; }

        [StringLength(200)]
        public string FATHER_EDUCATIIONAL_LEVEL { get; set; }

        [StringLength(200)]
        public string FATHER_CAREER { get; set; }

        [StringLength(200)]
        public string MOTHER_EDUCATIIONAL_LEVEL { get; set; }

        [StringLength(200)]
        public string MOTHER_CAREER { get; set; }

        public long? PATIENT_CLASSIFY_ID { get; set; }

        [StringLength(2)]
        public string TDL_LIVE_AREA_CODE { get; set; }

        [StringLength(6)]
        public string TDL_HEIN_MEDI_ORG_CODE { get; set; }

        [StringLength(500)]
        public string TDL_HEIN_MEDI_ORG_NAME { get; set; }

        public long? TDL_HEIN_CARD_FROM_TIME { get; set; }

        public long? TDL_HEIN_CARD_TO_TIME { get; set; }

        [StringLength(1000)]
        public string TDL_HEIN_CARD_ADDRESS { get; set; }

        [StringLength(2)]
        public string TDL_JOIN_5_YEAR { get; set; }

        [StringLength(2)]
        public string TDL_PAID_6_MONTH { get; set; }

        [StringLength(500)]
        public string CMND_BEFORE_URL { get; set; }

        [StringLength(500)]
        public string CMND_AFTER_URL { get; set; }

        [StringLength(20)]
        public string SOCIAL_INSURANCE_NUMBER { get; set; }

        public decimal? VIR_DOB_YEAR { get; set; }

        [StringLength(4000)]
        public string PT_ALLERGIC_HISTORY { get; set; }

        public long? POSITION_ID { get; set; }

        [StringLength(9)]
        public string PASSPORT_NUMBER { get; set; }

        public long? PASSPORT_DATE { get; set; }

        [StringLength(100)]
        public string PASSPORT_PLACE { get; set; }

        public short? IS_TUBERCULOSIS { get; set; }

        public short? HAS_CARD { get; set; }

        [StringLength(2000)]
        public string NOTE { get; set; }

        [StringLength(3)]
        public string MPS_NATIONAL_CODE { get; set; }

        [StringLength(20)]
        public string FATHER_SOCIAL_INSURANCE_NUMBER { get; set; }

        [StringLength(20)]
        public string MOTHER_SOCIAL_INSURANCE_NUMBER { get; set; }

        public short? IS_HIV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_APPOINTMENT> HIS_APPOINTMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_CARD> HIS_CARD { get; set; }

        public virtual HIS_CAREER HIS_CAREER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_CONTACT_POINT> HIS_CONTACT_POINT { get; set; }

        public virtual HIS_GENDER HIS_GENDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_HOLD_RETURN> HIS_HOLD_RETURN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_RECORD> HIS_MEDI_RECORD { get; set; }

        public virtual HIS_MILITARY_RANK HIS_MILITARY_RANK { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        public virtual HIS_WORK_PLACE HIS_WORK_PLACE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PATIENT> HIS_PATIENT1 { get; set; }

        public virtual HIS_PATIENT HIS_PATIENT2 { get; set; }

        public virtual HIS_PATIENT_CLASSIFY HIS_PATIENT_CLASSIFY { get; set; }

        public virtual HIS_POSITION HIS_POSITION { get; set; }

        public virtual HIS_SERVICE HIS_SERVICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PATIENT_PROGRAM> HIS_PATIENT_PROGRAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_REGISTER_REQ> HIS_REGISTER_REQ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TREATMENT> HIS_TREATMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VACCINATION_EXAM> HIS_VACCINATION_EXAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VACCINATION> HIS_VACCINATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VITAMIN_A> HIS_VITAMIN_A { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SERVICE")]
    public partial class HIS_SERVICE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_SERVICE()
        {
            HIS_APPOINTMENT_SERV = new HashSet<HIS_APPOINTMENT_SERV>();
            HIS_BED_BSTY = new HashSet<HIS_BED_BSTY>();
            HIS_BED_LOG = new HashSet<HIS_BED_LOG>();
            HIS_BLOOD_TYPE = new HashSet<HIS_BLOOD_TYPE>();
            HIS_BLTY_SERVICE = new HashSet<HIS_BLTY_SERVICE>();
            HIS_CARER_CARD = new HashSet<HIS_CARER_CARD>();
            HIS_DEBATE = new HashSet<HIS_DEBATE>();
            HIS_DEBATE1 = new HashSet<HIS_DEBATE>();
            HIS_EXP_BLTY_SERVICE = new HashSet<HIS_EXP_BLTY_SERVICE>();
            HIS_ICD_SERVICE = new HashSet<HIS_ICD_SERVICE>();
            HIS_KSK_SERVICE = new HashSet<HIS_KSK_SERVICE>();
            HIS_MACHINE_SERV_MATY = new HashSet<HIS_MACHINE_SERV_MATY>();
            HIS_MATERIAL_TYPE = new HashSet<HIS_MATERIAL_TYPE>();
            HIS_MEDICINE_TYPE = new HashSet<HIS_MEDICINE_TYPE>();
            HIS_PACKAGE_DETAIL = new HashSet<HIS_PACKAGE_DETAIL>();
            HIS_PATIENT = new HashSet<HIS_PATIENT>();
            HIS_PTTT_GROUP_BEST = new HashSet<HIS_PTTT_GROUP_BEST>();
            HIS_RATION_SCHEDULE = new HashSet<HIS_RATION_SCHEDULE>();
            HIS_REMUNERATION = new HashSet<HIS_REMUNERATION>();
            HIS_REST_RETR_TYPE = new HashSet<HIS_REST_RETR_TYPE>();
            HIS_ROOM = new HashSet<HIS_ROOM>();
            HIS_SERE_SERV = new HashSet<HIS_SERE_SERV>();
            HIS_SERE_SERV_RATION = new HashSet<HIS_SERE_SERV_RATION>();
            HIS_SERE_SERV_TEMP = new HashSet<HIS_SERE_SERV_TEMP>();
            HIS_SERV_SEGR = new HashSet<HIS_SERV_SEGR>();
            HIS_SERVICE_CHANGE_REQ = new HashSet<HIS_SERVICE_CHANGE_REQ>();
            HIS_SERVICE_CONDITION = new HashSet<HIS_SERVICE_CONDITION>();
            HIS_SERVICE1 = new HashSet<HIS_SERVICE>();
            HIS_SERVICE_FOLLOW = new HashSet<HIS_SERVICE_FOLLOW>();
            HIS_SERVICE_FOLLOW1 = new HashSet<HIS_SERVICE_FOLLOW>();
            HIS_SERVICE_GROUP = new HashSet<HIS_SERVICE_GROUP>();
            HIS_SERVICE_HEIN = new HashSet<HIS_SERVICE_HEIN>();
            HIS_SERVICE_MACHINE = new HashSet<HIS_SERVICE_MACHINE>();
            HIS_SERVICE_MATY = new HashSet<HIS_SERVICE_MATY>();
            HIS_SERVICE_METY = new HashSet<HIS_SERVICE_METY>();
            HIS_SERVICE_NUM_ORDER = new HashSet<HIS_SERVICE_NUM_ORDER>();
            HIS_SERVICE_PACKAGE = new HashSet<HIS_SERVICE_PACKAGE>();
            HIS_SERVICE_PACKAGE1 = new HashSet<HIS_SERVICE_PACKAGE>();
            HIS_SERVICE_PATY = new HashSet<HIS_SERVICE_PATY>();
            HIS_SERVICE_RATI = new HashSet<HIS_SERVICE_RATI>();
            HIS_SERVICE_RERE_TIME = new HashSet<HIS_SERVICE_RERE_TIME>();
            HIS_SERVICE_RETY_CAT = new HashSet<HIS_SERVICE_RETY_CAT>();
            HIS_SERVICE_ROOM = new HashSet<HIS_SERVICE_ROOM>();
            HIS_SERVICE_SAME = new HashSet<HIS_SERVICE_SAME>();
            HIS_SERVICE_SAME1 = new HashSet<HIS_SERVICE_SAME>();
            HIS_SUIM_SETY_SUIN = new HashSet<HIS_SUIM_SETY_SUIN>();
            HIS_TEST_INDEX = new HashSet<HIS_TEST_INDEX>();
            HIS_TREATMENT_TYPE = new HashSet<HIS_TREATMENT_TYPE>();
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
        [StringLength(25)]
        public string SERVICE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string SERVICE_NAME { get; set; }

        public long SERVICE_TYPE_ID { get; set; }

        public long SERVICE_UNIT_ID { get; set; }

        public long? PARENT_ID { get; set; }

        public short? IS_LEAF { get; set; }

        public long? NUM_ORDER { get; set; }

        public long? HEIN_SERVICE_TYPE_ID { get; set; }

        [StringLength(100)]
        public string HEIN_SERVICE_BHYT_CODE { get; set; }

        [StringLength(500)]
        public string HEIN_SERVICE_BHYT_NAME { get; set; }

        [StringLength(20)]
        public string HEIN_ORDER { get; set; }

        public short? IS_USE_SERVICE_HEIN { get; set; }

        public decimal? HEIN_LIMIT_PRICE_OLD { get; set; }

        public decimal? HEIN_LIMIT_RATIO_OLD { get; set; }

        public decimal? HEIN_LIMIT_PRICE { get; set; }

        public decimal? HEIN_LIMIT_RATIO { get; set; }

        public long? HEIN_LIMIT_PRICE_IN_TIME { get; set; }

        public long? HEIN_LIMIT_PRICE_INTR_TIME { get; set; }

        [StringLength(3)]
        public string SPECIALITY_CODE { get; set; }

        public short? IS_MULTI_REQUEST { get; set; }

        public decimal? MAX_EXPEND { get; set; }

        public short? BILL_OPTION { get; set; }

        public long? BILL_PATIENT_TYPE_ID { get; set; }

        public short? IS_OUT_PARENT_FEE { get; set; }

        public long? PTTT_GROUP_ID { get; set; }

        public long? PTTT_METHOD_ID { get; set; }

        public long? ICD_CM_ID { get; set; }

        public decimal? COGS { get; set; }

        public decimal? ESTIMATE_DURATION { get; set; }

        public long? REVENUE_DEPARTMENT_ID { get; set; }

        public long? PACKAGE_ID { get; set; }

        public decimal? PACKAGE_PRICE { get; set; }

        public long? NUMBER_OF_FILM { get; set; }

        [StringLength(20)]
        public string PACS_TYPE_CODE { get; set; }

        public long? MIN_DURATION { get; set; }

        public long? EXE_SERVICE_MODULE_ID { get; set; }

        public long? GENDER_ID { get; set; }

        public long? AGE_FROM { get; set; }

        public long? AGE_TO { get; set; }

        public long? RATION_GROUP_ID { get; set; }

        [StringLength(10)]
        public string RATION_SYMBOL { get; set; }

        [StringLength(4000)]
        public string NOTICE { get; set; }

        public long? CAPACITY { get; set; }

        public short? IS_ALLOW_EXPEND { get; set; }

        public short? IS_NO_HEIN_LIMIT_FOR_SPECIAL { get; set; }

        public short? IS_KIDNEY { get; set; }

        public short? IS_SPECIFIC_HEIN_PRICE { get; set; }

        public short? IS_OTHER_SOURCE_PAID { get; set; }

        public short? IS_ANTIBIOTIC_RESISTANCE { get; set; }

        public long? DIIM_TYPE_ID { get; set; }

        public long? FUEX_TYPE_ID { get; set; }

        public long? TAX_RATE_TYPE { get; set; }

        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        public short? IS_SPLIT_SERVICE_REQ { get; set; }

        public short? IS_ENABLE_ASSIGN_PRICE { get; set; }

        public short? IS_AUTO_FINISH { get; set; }

        [StringLength(50)]
        public string PROCESS_CODE { get; set; }

        public long? TEST_TYPE_ID { get; set; }

        public short? IS_OUT_OF_DRG { get; set; }

        public short? IS_CONDITIONED { get; set; }

        public long? MIN_PROCESS_TIME { get; set; }

        public short? IS_NOT_CHANGE_BILL_PATY { get; set; }

        public short? IS_SPLIT_SERVICE { get; set; }

        public long? OTHER_PAY_SOURCE_ID { get; set; }

        [StringLength(200)]
        public string OTHER_PAY_SOURCE_ICDS { get; set; }

        [StringLength(200)]
        public string BODY_PART_IDS { get; set; }

        [StringLength(500)]
        public string TESTING_TECHNIQUE { get; set; }

        public short? IS_OUT_OF_MANAGEMENT { get; set; }

        public short? MUST_BE_CONSULTED { get; set; }

        public long? SUIM_INDEX_ID { get; set; }

        [StringLength(100)]
        public string ATTACH_ASSIGN_PRINT_TYPE_CODE { get; set; }

        public long? TEST_COVID_TYPE { get; set; }

        public long? MAX_PROCESS_TIME { get; set; }

        public short? IS_DISALLOWANCE_NO_EXECUTE { get; set; }

        public short? IS_NOT_SHOW_TRACKING { get; set; }

        public long? FILM_SIZE_ID { get; set; }

        public short? IS_AUTO_EXPEND { get; set; }

        public short? IS_BLOCK_DEPARTMENT_TRAN { get; set; }

        public long? WARNING_SAMPLING_TIME { get; set; }

        [StringLength(100)]
        public string APPLIED_PATIENT_TYPE_IDS { get; set; }

        public long? DEFAULT_PATIENT_TYPE_ID { get; set; }

        public long? MAX_TOTAL_PROCESS_TIME { get; set; }

        public short? ALLOW_SIMULTANEITY { get; set; }

        [StringLength(100)]
        public string SAMPLE_TYPE_CODE { get; set; }

        [StringLength(200)]
        public string MIN_PROC_TIME_EXCEPT_PATY_IDS { get; set; }

        [StringLength(200)]
        public string MAX_PROC_TIME_EXCEPT_PATY_IDS { get; set; }

        public long? MAX_AMOUNT { get; set; }

        public short? IS_NOT_REQUIRED_COMPLETE { get; set; }

        public short? DO_NOT_USE_BHYT { get; set; }

        [StringLength(10)]
        public string PETROLEUM_CODE { get; set; }

        [StringLength(100)]
        public string PETROLEUM_NAME { get; set; }

        public short? ALLOW_SEND_PACS { get; set; }

        [StringLength(230)]
        public string TOTAL_TIME_EXCEPT_PATY_IDS { get; set; }

        [StringLength(500)]
        public string APPLIED_PATIENT_CLASSIFY_IDS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_APPOINTMENT_SERV> HIS_APPOINTMENT_SERV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BED_BSTY> HIS_BED_BSTY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BED_LOG> HIS_BED_LOG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BLOOD_TYPE> HIS_BLOOD_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BLTY_SERVICE> HIS_BLTY_SERVICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_CARER_CARD> HIS_CARER_CARD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEBATE> HIS_DEBATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEBATE> HIS_DEBATE1 { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        public virtual HIS_DIIM_TYPE HIS_DIIM_TYPE { get; set; }

        public virtual HIS_EXE_SERVICE_MODULE HIS_EXE_SERVICE_MODULE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_BLTY_SERVICE> HIS_EXP_BLTY_SERVICE { get; set; }

        public virtual HIS_FILM_SIZE HIS_FILM_SIZE { get; set; }

        public virtual HIS_FUEX_TYPE HIS_FUEX_TYPE { get; set; }

        public virtual HIS_HEIN_SERVICE_TYPE HIS_HEIN_SERVICE_TYPE { get; set; }

        public virtual HIS_ICD_CM HIS_ICD_CM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ICD_SERVICE> HIS_ICD_SERVICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_KSK_SERVICE> HIS_KSK_SERVICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MACHINE_SERV_MATY> HIS_MACHINE_SERV_MATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MATERIAL_TYPE> HIS_MATERIAL_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICINE_TYPE> HIS_MEDICINE_TYPE { get; set; }

        public virtual HIS_OTHER_PAY_SOURCE HIS_OTHER_PAY_SOURCE { get; set; }

        public virtual HIS_PACKAGE HIS_PACKAGE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PACKAGE_DETAIL> HIS_PACKAGE_DETAIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PATIENT> HIS_PATIENT { get; set; }

        public virtual HIS_PATIENT_TYPE HIS_PATIENT_TYPE { get; set; }

        public virtual HIS_PATIENT_TYPE HIS_PATIENT_TYPE1 { get; set; }

        public virtual HIS_PTTT_GROUP HIS_PTTT_GROUP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PTTT_GROUP_BEST> HIS_PTTT_GROUP_BEST { get; set; }

        public virtual HIS_PTTT_METHOD HIS_PTTT_METHOD { get; set; }

        public virtual HIS_RATION_GROUP HIS_RATION_GROUP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_RATION_SCHEDULE> HIS_RATION_SCHEDULE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_REMUNERATION> HIS_REMUNERATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_REST_RETR_TYPE> HIS_REST_RETR_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ROOM> HIS_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV> HIS_SERE_SERV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_RATION> HIS_SERE_SERV_RATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_TEMP> HIS_SERE_SERV_TEMP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERV_SEGR> HIS_SERV_SEGR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_CHANGE_REQ> HIS_SERVICE_CHANGE_REQ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_CONDITION> HIS_SERVICE_CONDITION { get; set; }

        public virtual HIS_SERVICE_TYPE HIS_SERVICE_TYPE { get; set; }

        public virtual HIS_TEST_TYPE HIS_TEST_TYPE { get; set; }

        public virtual HIS_SUIM_INDEX HIS_SUIM_INDEX { get; set; }

        public virtual HIS_SERVICE_UNIT HIS_SERVICE_UNIT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE> HIS_SERVICE1 { get; set; }

        public virtual HIS_SERVICE HIS_SERVICE2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_FOLLOW> HIS_SERVICE_FOLLOW { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_FOLLOW> HIS_SERVICE_FOLLOW1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_GROUP> HIS_SERVICE_GROUP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_HEIN> HIS_SERVICE_HEIN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_MACHINE> HIS_SERVICE_MACHINE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_MATY> HIS_SERVICE_MATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_METY> HIS_SERVICE_METY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_NUM_ORDER> HIS_SERVICE_NUM_ORDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_PACKAGE> HIS_SERVICE_PACKAGE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_PACKAGE> HIS_SERVICE_PACKAGE1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_PATY> HIS_SERVICE_PATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_RATI> HIS_SERVICE_RATI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_RERE_TIME> HIS_SERVICE_RERE_TIME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_RETY_CAT> HIS_SERVICE_RETY_CAT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_ROOM> HIS_SERVICE_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_SAME> HIS_SERVICE_SAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_SAME> HIS_SERVICE_SAME1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SUIM_SETY_SUIN> HIS_SUIM_SETY_SUIN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TEST_INDEX> HIS_TEST_INDEX { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TREATMENT_TYPE> HIS_TREATMENT_TYPE { get; set; }
    }
}

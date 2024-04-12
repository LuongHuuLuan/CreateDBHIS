namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SERVICE_REQ")]
    public partial class HIS_SERVICE_REQ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_SERVICE_REQ()
        {
            HIS_BED_LOG = new HashSet<HIS_BED_LOG>();
            HIS_DRUG_INTERVENTION = new HashSet<HIS_DRUG_INTERVENTION>();
            HIS_EXAM_SERE_DIRE = new HashSet<HIS_EXAM_SERE_DIRE>();
            HIS_EXP_MEST = new HashSet<HIS_EXP_MEST>();
            HIS_EXP_MEST1 = new HashSet<HIS_EXP_MEST>();
            HIS_KSK_DRIVER = new HashSet<HIS_KSK_DRIVER>();
            HIS_KSK_DRIVER_CAR = new HashSet<HIS_KSK_DRIVER_CAR>();
            HIS_KSK_GENERAL = new HashSet<HIS_KSK_GENERAL>();
            HIS_KSK_OCCUPATIONAL = new HashSet<HIS_KSK_OCCUPATIONAL>();
            HIS_KSK_OTHER = new HashSet<HIS_KSK_OTHER>();
            HIS_KSK_OVER_EIGHTEEN = new HashSet<HIS_KSK_OVER_EIGHTEEN>();
            HIS_KSK_PERIOD_DRIVER = new HashSet<HIS_KSK_PERIOD_DRIVER>();
            HIS_KSK_UNDER_EIGHTEEN = new HashSet<HIS_KSK_UNDER_EIGHTEEN>();
            HIS_SERE_SERV = new HashSet<HIS_SERE_SERV>();
            HIS_SERE_SERV_EXT = new HashSet<HIS_SERE_SERV_EXT>();
            HIS_SERE_SERV_RATION = new HashSet<HIS_SERE_SERV_RATION>();
            HIS_SERVICE_REQ1 = new HashSet<HIS_SERVICE_REQ>();
            HIS_SERVICE_REQ11 = new HashSet<HIS_SERVICE_REQ>();
            HIS_SERVICE_REQ_MATY = new HashSet<HIS_SERVICE_REQ_MATY>();
            HIS_SERVICE_REQ_METY = new HashSet<HIS_SERVICE_REQ_METY>();
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
        public string SERVICE_REQ_CODE { get; set; }

        public long SERVICE_REQ_TYPE_ID { get; set; }

        public long SERVICE_REQ_STT_ID { get; set; }

        public long TREATMENT_ID { get; set; }

        public long INTRUCTION_TIME { get; set; }

        public long INTRUCTION_DATE { get; set; }

        public long REQUEST_ROOM_ID { get; set; }

        public long REQUEST_DEPARTMENT_ID { get; set; }

        [StringLength(50)]
        public string REQUEST_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REQUEST_USERNAME { get; set; }

        public long EXECUTE_ROOM_ID { get; set; }

        public long EXECUTE_DEPARTMENT_ID { get; set; }

        [StringLength(50)]
        public string EXECUTE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string EXECUTE_USERNAME { get; set; }

        public long? EXE_SERVICE_MODULE_ID { get; set; }

        public long? START_TIME { get; set; }

        public long? FINISH_TIME { get; set; }

        public long? ICD_ID__DELETE { get; set; }

        [StringLength(10)]
        public string ICD_CODE { get; set; }

        [StringLength(500)]
        public string ICD_NAME { get; set; }

        [StringLength(500)]
        public string ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string ICD_TEXT { get; set; }

        [StringLength(10)]
        public string ICD_CAUSE_CODE { get; set; }

        [StringLength(500)]
        public string ICD_CAUSE_NAME { get; set; }

        public long? NUM_ORDER { get; set; }

        public long? ESTIMATE_TIME_FROM { get; set; }

        public long? ESTIMATE_TIME_TO { get; set; }

        public short? IS_HOLD_ORDER { get; set; }

        public long? PRIORITY { get; set; }

        public long? TRACKING_ID { get; set; }

        public long? PARENT_ID { get; set; }

        public long? PREVIOUS_SERVICE_REQ_ID { get; set; }

        public long? TREATMENT_TYPE_ID { get; set; }

        public short? IS_WAIT_CHILD { get; set; }

        public long? DHST_ID { get; set; }

        public long? EXECUTE_GROUP_ID { get; set; }

        public long? ASSIGN_REASON_ID { get; set; }

        public short? IS_NOT_REQUIRE_FEE { get; set; }

        public short? IS_NO_EXECUTE { get; set; }

        public long? CALL_COUNT { get; set; }

        [StringLength(200)]
        public string JSON_PRINT_ID { get; set; }

        [StringLength(200)]
        public string JSON_FORM_ID { get; set; }

        [StringLength(1000)]
        public string DESCRIPTION { get; set; }

        [StringLength(50)]
        public string SESSION_CODE { get; set; }

        public short? IS_EMERGENCY { get; set; }

        public short? IS_NOT_SHOW_MATERIAL_TRACKING { get; set; }

        public short? IS_NOT_SHOW_MEDICINE_TRACKING { get; set; }

        [StringLength(12)]
        public string BARCODE { get; set; }

        public long? SAMPLE_ROOM_ID { get; set; }

        public long? LIS_STT_ID { get; set; }

        public short? IS_SENT_EXT { get; set; }

        public short? IS_UPDATED_EXT { get; set; }

        public short? IS_INFORM_RESULT_BY_SMS { get; set; }

        public short? PACS_STT_ID { get; set; }

        public long? PAAN_POSITION_ID { get; set; }

        public long? PAAN_LIQUID_ID { get; set; }

        public long? LIQUID_TIME { get; set; }

        [StringLength(100)]
        public string ECG_BEFORE { get; set; }

        [StringLength(100)]
        public string ECG_AFTER { get; set; }

        [StringLength(100)]
        public string RESPIRATORY_BEFORE { get; set; }

        [StringLength(100)]
        public string RESPIRATORY_AFTER { get; set; }

        [StringLength(100)]
        public string SYMPTOM_BEFORE { get; set; }

        [StringLength(100)]
        public string SYMPTOM_AFTER { get; set; }

        [StringLength(2000)]
        public string ADVISE { get; set; }

        public long? REHA_SUM_ID { get; set; }

        public short? PRESCRIPTION_TYPE_ID { get; set; }

        public long? USE_TIME { get; set; }

        public long? USE_TIME_TO { get; set; }

        public long? REMEDY_COUNT { get; set; }

        public short? IS_MAIN_EXAM { get; set; }

        [StringLength(4000)]
        public string HOSPITALIZATION_REASON { get; set; }

        [StringLength(4000)]
        public string PATHOLOGICAL_PROCESS { get; set; }

        [StringLength(3000)]
        public string PATHOLOGICAL_HISTORY { get; set; }

        [StringLength(3000)]
        public string PATHOLOGICAL_HISTORY_FAMILY { get; set; }

        [StringLength(4000)]
        public string FULL_EXAM { get; set; }

        [StringLength(4000)]
        public string PART_EXAM { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_CIRCULATION { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_RESPIRATORY { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_DIGESTION { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_KIDNEY_UROLOGY { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_NEUROLOGICAL { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_MUSCLE_BONE { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_ENT { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_EAR { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_NOSE { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_THROAT { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_STOMATOLOGY { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_EYE { get; set; }

        [StringLength(500)]
        public string PART_EXAM_EYE_TENSION_LEFT { get; set; }

        [StringLength(500)]
        public string PART_EXAM_EYE_TENSION_RIGHT { get; set; }

        [StringLength(500)]
        public string PART_EXAM_EYESIGHT_LEFT { get; set; }

        [StringLength(500)]
        public string PART_EXAM_EYESIGHT_RIGHT { get; set; }

        [StringLength(500)]
        public string PART_EXAM_EYESIGHT_GLASS_LEFT { get; set; }

        [StringLength(500)]
        public string PART_EXAM_EYESIGHT_GLASS_RIGHT { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_OEND { get; set; }

        public long? SICK_DAY { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_MENTAL { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_OBSTETRIC { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_NUTRITION { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_MOTION { get; set; }

        [StringLength(2)]
        public string NEXT_TREAT_INTR_CODE { get; set; }

        [StringLength(100)]
        public string NEXT_TREATMENT_INSTRUCTION { get; set; }

        [StringLength(4000)]
        public string SUBCLINICAL { get; set; }

        [StringLength(500)]
        public string TREATMENT_INSTRUCTION { get; set; }

        [StringLength(2000)]
        public string NOTE { get; set; }

        public long? PTTT_CALENDAR_ID { get; set; }

        public long? PTTT_APPROVAL_STT_ID { get; set; }

        public long? PTTT_APPROVAL_TIME { get; set; }

        [StringLength(50)]
        public string PTTT_APPROVAL_LOGINNAME { get; set; }

        [StringLength(100)]
        public string PTTT_APPROVAL_USERNAME { get; set; }

        public long? PLAN_TIME_FROM { get; set; }

        public long? PLAN_TIME_TO { get; set; }

        public long? EKIP_PLAN_ID { get; set; }

        public long? RATION_SUM_ID { get; set; }

        public long? RATION_TIME_ID { get; set; }

        public long? HEALTH_EXAM_RANK_ID { get; set; }

        [StringLength(500)]
        public string ATTACHMENT_FILE_URL { get; set; }

        public short? IS_INTEGRATE_HIS_SENT { get; set; }

        public long? MACHINE_ID { get; set; }

        public long? KIDNEY_SHIFT { get; set; }

        public long? EXP_MEST_TEMPLATE_ID { get; set; }

        [Required]
        [StringLength(12)]
        public string TDL_TREATMENT_CODE { get; set; }

        [StringLength(19)]
        public string TDL_HEIN_CARD_NUMBER { get; set; }

        public long TDL_PATIENT_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [Required]
        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        [Required]
        [StringLength(30)]
        public string TDL_PATIENT_FIRST_NAME { get; set; }

        [StringLength(70)]
        public string TDL_PATIENT_LAST_NAME { get; set; }

        public long TDL_PATIENT_DOB { get; set; }

        public short? TDL_PATIENT_IS_HAS_NOT_DAY_DOB { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        public long? TDL_PATIENT_GENDER_ID { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_CAREER_NAME { get; set; }

        [StringLength(500)]
        public string TDL_PATIENT_WORK_PLACE { get; set; }

        [StringLength(500)]
        public string TDL_PATIENT_WORK_PLACE_NAME { get; set; }

        [StringLength(4)]
        public string TDL_PATIENT_DISTRICT_CODE { get; set; }

        [StringLength(3)]
        public string TDL_PATIENT_PROVINCE_CODE { get; set; }

        [StringLength(6)]
        public string TDL_PATIENT_COMMUNE_CODE { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_MILITARY_RANK_NAME { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_NATIONAL_NAME { get; set; }

        [StringLength(6)]
        public string TDL_HEIN_MEDI_ORG_CODE { get; set; }

        [StringLength(500)]
        public string TDL_HEIN_MEDI_ORG_NAME { get; set; }

        [StringLength(500)]
        public string TDL_PATIENT_AVATAR_URL { get; set; }

        public long? TDL_TREATMENT_TYPE_ID { get; set; }

        public short? IS_HOME_PRES { get; set; }

        public short? IS_NOT_SHOW_OUT_MATE_TRACKING { get; set; }

        public short? IS_NOT_SHOW_OUT_MEDI_TRACKING { get; set; }

        public short? IS_KIDNEY { get; set; }

        public long? KIDNEY_TIMES { get; set; }

        [StringLength(122)]
        public string VIR_KIDNEY { get; set; }

        public short? IS_EXECUTE_KIDNEY_PRES { get; set; }

        public long? CALL_SAMPLE_ORDER { get; set; }

        [StringLength(12)]
        public string BARCODE_TEMP { get; set; }

        [StringLength(4000)]
        public string RESERVED_NUM_ORDER { get; set; }

        public short? IS_ANTIBIOTIC_RESISTANCE { get; set; }

        public long? TDL_PATIENT_TYPE_ID { get; set; }

        public long? CALL_TIME { get; set; }

        [StringLength(1000)]
        public string PROVISIONAL_DIAGNOSIS { get; set; }

        public long? CALL_DATE { get; set; }

        [StringLength(50)]
        public string NUM_ORDER_BASE { get; set; }

        public long? PRIORITY_TYPE_ID { get; set; }

        public long? PRES_GROUP { get; set; }

        [StringLength(12)]
        public string TDL_PATIENT_MOBILE { get; set; }

        [StringLength(12)]
        public string TDL_PATIENT_PHONE { get; set; }

        public short? IS_SEND_BARCODE_TO_LIS { get; set; }

        public long? EXECUTE_WORKING_SHIFT_ID { get; set; }

        public long? EXE_WORKING_SHIFT_ID { get; set; }

        public long? REQ_WORKING_SHIFT_ID { get; set; }

        public short? HAS_CHILD { get; set; }

        public short? IS_STAR_MARK { get; set; }

        public long? PATIENT_CASE_ID { get; set; }

        public short? IS_AUTO_FINISHED { get; set; }

        public short? IS_COLLECTED { get; set; }

        public long? TEST_SAMPLE_TYPE_ID { get; set; }

        public long? EXE_DESK_ID { get; set; }

        [StringLength(10)]
        public string TRADITIONAL_ICD_CODE { get; set; }

        [StringLength(500)]
        public string TRADITIONAL_ICD_NAME { get; set; }

        [StringLength(500)]
        public string TRADITIONAL_ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string TRADITIONAL_ICD_TEXT { get; set; }

        public short? TDL_KSK_IS_REQUIRED_APPROVAL { get; set; }

        public short? TDL_IS_KSK_APPROVE { get; set; }

        [StringLength(500)]
        public string TREAT_EYE_TENSION_LEFT { get; set; }

        [StringLength(500)]
        public string TREAT_EYE_TENSION_RIGHT { get; set; }

        [StringLength(500)]
        public string TREAT_EYESIGHT_LEFT { get; set; }

        [StringLength(500)]
        public string TREAT_EYESIGHT_RIGHT { get; set; }

        [StringLength(500)]
        public string TREAT_EYESIGHT_GLASS_LEFT { get; set; }

        [StringLength(500)]
        public string TREAT_EYESIGHT_GLASS_RIGHT { get; set; }

        public short? IS_FIRST_OPTOMETRIST { get; set; }

        [StringLength(100)]
        public string OPTOMETRIST_TIME { get; set; }

        [StringLength(50)]
        public string FORESIGHT_RIGHT_EYE { get; set; }

        [StringLength(50)]
        public string FORESIGHT_LEFT_EYE { get; set; }

        [StringLength(50)]
        public string FORESIGHT_RIGHT_GLASS_HOLE { get; set; }

        [StringLength(50)]
        public string FORESIGHT_LEFT_GLASS_HOLE { get; set; }

        [StringLength(50)]
        public string FORESIGHT_RIGHT_USING_GLASS { get; set; }

        [StringLength(50)]
        public string FORESIGHT_LEFT_USING_GLASS { get; set; }

        [StringLength(50)]
        public string REFACTOMETRY_RIGHT_EYE { get; set; }

        [StringLength(50)]
        public string REFACTOMETRY_LEFT_EYE { get; set; }

        [StringLength(50)]
        public string BEFORE_LIGHT_REFLECTION_RIGHT { get; set; }

        [StringLength(50)]
        public string BEFORE_LIGHT_REFLECTION_LEFT { get; set; }

        [StringLength(50)]
        public string AFTER_LIGHT_REFLECTION_RIGHT { get; set; }

        [StringLength(50)]
        public string AFTER_LIGHT_REFLECTION_LEFT { get; set; }

        [StringLength(50)]
        public string AJUSTABLE_GLASS_FORESIGHT { get; set; }

        [StringLength(50)]
        public string AJUSTABLE_GLASS_FORESIGHT_R { get; set; }

        [StringLength(50)]
        public string AJUSTABLE_GLASS_FORESIGHT_L { get; set; }

        [StringLength(50)]
        public string NEARSIGHT_GLASS_RIGHT_EYE { get; set; }

        [StringLength(50)]
        public string NEARSIGHT_GLASS_LEFT_EYE { get; set; }

        [StringLength(50)]
        public string NEARSIGHT_GLASS_READING_DIST { get; set; }

        [StringLength(50)]
        public string NEARSIGHT_GLASS_PUPIL_DIST { get; set; }

        public long? REOPTOMETRIST_APPOINTMENT { get; set; }

        [StringLength(50)]
        public string FORESIGHT_USING_GLASS_DEGREE_R { get; set; }

        [StringLength(50)]
        public string FORESIGHT_USING_GLASS_DEGREE_L { get; set; }

        [StringLength(50)]
        public string RESULT_APPROVER_LOGINNAME { get; set; }

        [StringLength(100)]
        public string RESULT_APPROVER_USERNAME { get; set; }

        public long? EXAM_END_TYPE { get; set; }

        [StringLength(50)]
        public string CONSULTANT_LOGINNAME { get; set; }

        [StringLength(100)]
        public string CONSULTANT_USERNAME { get; set; }

        public long? TDL_PATIENT_CLASSIFY_ID { get; set; }

        [StringLength(50)]
        public string ASSIGNED_EXECUTE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string ASSIGNED_EXECUTE_USERNAME { get; set; }

        public short? IS_NOT_IN_DEBT { get; set; }

        public long? RESULT_ROOM_ID { get; set; }

        public long? RESULT_DESK_ID { get; set; }

        public long? CASHIER_ROOM_ID { get; set; }

        public short? IS_RESULT_IN_DIFF_DAY { get; set; }

        public decimal? VIR_INTRUCTION_MONTH { get; set; }

        [StringLength(50)]
        public string BIIN_TEST_RESULT { get; set; }

        public long? RESULTING_ORDER { get; set; }

        public long? RESULTING_TIME { get; set; }

        [StringLength(10)]
        public string BLOCK { get; set; }

        public short? IS_SAMPLED { get; set; }

        public long? SAMPLE_TIME { get; set; }

        [StringLength(50)]
        public string SAMPLER_LOGINNAME { get; set; }

        [StringLength(100)]
        public string SAMPLER_USERNAME { get; set; }

        [StringLength(3000)]
        public string TDL_INSTRUCTION_NOTE { get; set; }

        public short? IS_RESULTED { get; set; }

        [StringLength(15)]
        public string ASSIGN_TURN_CODE { get; set; }

        public short? IS_NOT_USE_BHYT { get; set; }

        public long? BARCODE_LENGTH { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_DERMATOLOGY { get; set; }

        public short? IS_ACCEPTING_NO_EXECUTE { get; set; }

        public long? EXAM_END_TIME { get; set; }

        public long? EXAM_TREATMENT_END_TYPE_ID { get; set; }

        public long? EXAM_TREATMENT_RESULT_ID { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_EAR_RIGHT_NORMAL { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_EAR_RIGHT_WHISPER { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_EAR_LEFT_NORMAL { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_EAR_LEFT_WHISPER { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_UPPER_JAW { get; set; }

        [StringLength(4000)]
        public string PART_EXAM_LOWER_JAW { get; set; }

        public long? PART_EXAM_HORIZONTAL_SIGHT { get; set; }

        public long? PART_EXAM_VERTICAL_SIGHT { get; set; }

        public long? PART_EXAM_EYE_BLIND_COLOR { get; set; }

        [StringLength(100)]
        public string REQUEST_USER_TITLE { get; set; }

        [StringLength(100)]
        public string EXECUTE_USER_TITLE { get; set; }

        public long? APPOINTMENT_TIME { get; set; }

        [StringLength(500)]
        public string APPOINTMENT_DESC { get; set; }

        [StringLength(12)]
        public string APPOINTMENT_CODE { get; set; }

        public long? TDL_APPOINTMENT_DATE { get; set; }

        public long? SPECIAL_MEDICINE_TYPE { get; set; }

        [StringLength(9)]
        public string TDL_PATIENT_CMND_NUMBER { get; set; }

        public long? TDL_PATIENT_CMND_DATE { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_CMND_PLACE { get; set; }

        [StringLength(12)]
        public string TDL_PATIENT_CCCD_NUMBER { get; set; }

        public long? TDL_PATIENT_CCCD_DATE { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_CCCD_PLACE { get; set; }

        [StringLength(4000)]
        public string TDL_SERVICE_IDS { get; set; }

        public long? BED_LOG_ID { get; set; }

        public long? NUM_ORDER_ISSUE_ID { get; set; }

        [StringLength(3)]
        public string TDL_PATIENT_NATIONAL_CODE { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_PROVINCE_NAME { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_DISTRICT_NAME { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_COMMUNE_NAME { get; set; }

        [StringLength(100)]
        public string ATTACH_ASSIGN_PRINT_ID { get; set; }

        [StringLength(100)]
        public string ATTACH_ASSIGN_PRINT_TYPE_CODE { get; set; }

        public long? TDL_PATIENT_POSITION_ID { get; set; }

        [StringLength(4000)]
        public string CONCLUSION_CLINICAL { get; set; }

        [StringLength(4000)]
        public string CONCLUSION_SUBCLINICAL { get; set; }

        [StringLength(4000)]
        public string OCCUPATIONAL_DISEASE { get; set; }

        [StringLength(4000)]
        public string CONCLUSION_CONSULTATION { get; set; }

        [StringLength(4000)]
        public string EXAM_CONCLUSION { get; set; }

        [StringLength(4000)]
        public string CONCLUSION { get; set; }

        public long? TDL_KSK_CONTRACT_ID { get; set; }

        public short? IS_ENOUGH_SUBCLINICAL_PRES { get; set; }

        public short? IS_SUB_PRES { get; set; }

        [StringLength(4000)]
        public string PLANNING_REQUEST { get; set; }

        [StringLength(4000)]
        public string SURGERY_NOTE { get; set; }

        [StringLength(9)]
        public string TDL_PATIENT_PASSPORT_NUMBER { get; set; }

        public long? TDL_PATIENT_PASSPORT_DATE { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_PASSPORT_PLACE { get; set; }

        [StringLength(150)]
        public string TDL_PATIENT_UNSIGNED_NAME { get; set; }

        [StringLength(1000)]
        public string INTERACTION_REASON { get; set; }

        public long? CARER_CARD_BORROW_ID { get; set; }

        public short? IS_FOR_AUTO_CREATE_RATION { get; set; }

        public long? USED_FOR_TRACKING_ID { get; set; }

        public short? TDL_KSK_CONTRACT_IS_RESTRICTED { get; set; }

        public short? IS_FOR_HOMIE { get; set; }

        [StringLength(50)]
        public string PAEX_LOGINNAME { get; set; }

        [StringLength(50)]
        public string PAEX_CIRC_LOGINNAME { get; set; }

        [StringLength(50)]
        public string PAEX_RESP_LOGINNAME { get; set; }

        [StringLength(50)]
        public string PAEX_DIGE_LOGINNAME { get; set; }

        [StringLength(50)]
        public string PAEX_KIDN_LOGINNAME { get; set; }

        [StringLength(50)]
        public string PAEX_NEUR_LOGINNAME { get; set; }

        [StringLength(50)]
        public string PAEX_MUSC_LOGINNAME { get; set; }

        [StringLength(50)]
        public string PAEX_ENT_LOGINNAME { get; set; }

        [StringLength(50)]
        public string PAEX_STOM_LOGINNAME { get; set; }

        [StringLength(50)]
        public string PAEX_EYE_LOGINNAME { get; set; }

        [StringLength(50)]
        public string PAEX_OEND_LOGINNAME { get; set; }

        [StringLength(50)]
        public string PAEX_MENT_LOGINNAME { get; set; }

        [StringLength(50)]
        public string PAEX_NUTR_LOGINNAME { get; set; }

        [StringLength(50)]
        public string PAEX_MOTI_LOGINNAME { get; set; }

        [StringLength(50)]
        public string PAEX_OBST_LOGINNAME { get; set; }

        [StringLength(50)]
        public string PAEX_DERM_LOGINNAME { get; set; }

        public short? IS_NOT_REQUIRED_COMPLETE { get; set; }

        public short? IS_SENT_ERX { get; set; }

        public decimal? VIR_CREATE_DATE { get; set; }

        [StringLength(50)]
        public string RECEIVE_SAMPLE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string RECEIVE_SAMPLE_USERNAME { get; set; }

        public long? RECEIVE_SAMPLE_TIME { get; set; }

        public long? APPOINTMENT_EXAM_ROOM_ID { get; set; }

        public long? APPOINTMENT_EXAM_SERVICE_ID { get; set; }

        public long? TRANS_REQ_ID { get; set; }

        public short? IS_TEMPORARY_PRES { get; set; }

        public long? ATTACHED_ID { get; set; }

        public short? ALLOW_SEND_PACS { get; set; }

        [StringLength(2000)]
        public string MACHINE_NAMES { get; set; }

        public long? RATION_SCHEDULE_ID { get; set; }

        [StringLength(500)]
        public string ERX_DESC { get; set; }

        public virtual HIS_ASSIGN_REASON HIS_ASSIGN_REASON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BED_LOG> HIS_BED_LOG { get; set; }

        public virtual HIS_BED_LOG HIS_BED_LOG1 { get; set; }

        public virtual HIS_CARER_CARD_BORROW HIS_CARER_CARD_BORROW { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT1 { get; set; }

        public virtual HIS_DESK HIS_DESK { get; set; }

        public virtual HIS_DHST HIS_DHST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DRUG_INTERVENTION> HIS_DRUG_INTERVENTION { get; set; }

        public virtual HIS_EKIP_PLAN HIS_EKIP_PLAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXAM_SERE_DIRE> HIS_EXAM_SERE_DIRE { get; set; }

        public virtual HIS_EXE_SERVICE_MODULE HIS_EXE_SERVICE_MODULE { get; set; }

        public virtual HIS_EXECUTE_GROUP HIS_EXECUTE_GROUP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST> HIS_EXP_MEST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST> HIS_EXP_MEST1 { get; set; }

        public virtual HIS_EXP_MEST_TEMPLATE HIS_EXP_MEST_TEMPLATE { get; set; }

        public virtual HIS_HEALTH_EXAM_RANK HIS_HEALTH_EXAM_RANK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_KSK_DRIVER> HIS_KSK_DRIVER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_KSK_DRIVER_CAR> HIS_KSK_DRIVER_CAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_KSK_GENERAL> HIS_KSK_GENERAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_KSK_OCCUPATIONAL> HIS_KSK_OCCUPATIONAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_KSK_OTHER> HIS_KSK_OTHER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_KSK_OVER_EIGHTEEN> HIS_KSK_OVER_EIGHTEEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_KSK_PERIOD_DRIVER> HIS_KSK_PERIOD_DRIVER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_KSK_UNDER_EIGHTEEN> HIS_KSK_UNDER_EIGHTEEN { get; set; }

        public virtual HIS_MACHINE HIS_MACHINE { get; set; }

        public virtual HIS_PAAN_LIQUID HIS_PAAN_LIQUID { get; set; }

        public virtual HIS_PAAN_POSITION HIS_PAAN_POSITION { get; set; }

        public virtual HIS_PATIENT_CASE HIS_PATIENT_CASE { get; set; }

        public virtual HIS_PRIORITY_TYPE HIS_PRIORITY_TYPE { get; set; }

        public virtual HIS_PTTT_CALENDAR HIS_PTTT_CALENDAR { get; set; }

        public virtual HIS_RATION_SUM HIS_RATION_SUM { get; set; }

        public virtual HIS_RATION_TIME HIS_RATION_TIME { get; set; }

        public virtual HIS_REHA_SUM HIS_REHA_SUM { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        public virtual HIS_ROOM HIS_ROOM1 { get; set; }

        public virtual HIS_SAMPLE_ROOM HIS_SAMPLE_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV> HIS_SERE_SERV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_EXT> HIS_SERE_SERV_EXT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_RATION> HIS_SERE_SERV_RATION { get; set; }

        public virtual HIS_SERVICE_REQ_TYPE HIS_SERVICE_REQ_TYPE { get; set; }

        public virtual HIS_TRACKING HIS_TRACKING { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_REQ> HIS_SERVICE_REQ1 { get; set; }

        public virtual HIS_SERVICE_REQ HIS_SERVICE_REQ2 { get; set; }

        public virtual HIS_WORKING_SHIFT HIS_WORKING_SHIFT { get; set; }

        public virtual HIS_WORKING_SHIFT HIS_WORKING_SHIFT1 { get; set; }

        public virtual HIS_WORKING_SHIFT HIS_WORKING_SHIFT2 { get; set; }

        public virtual HIS_TEST_SAMPLE_TYPE HIS_TEST_SAMPLE_TYPE { get; set; }

        public virtual HIS_TRACKING HIS_TRACKING1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_REQ> HIS_SERVICE_REQ11 { get; set; }

        public virtual HIS_SERVICE_REQ HIS_SERVICE_REQ3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_REQ_MATY> HIS_SERVICE_REQ_MATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_REQ_METY> HIS_SERVICE_REQ_METY { get; set; }
    }
}

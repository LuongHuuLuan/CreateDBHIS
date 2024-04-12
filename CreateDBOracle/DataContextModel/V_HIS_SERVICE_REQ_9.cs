namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_SERVICE_REQ_9")]
    public partial class V_HIS_SERVICE_REQ_9
    {
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

        public long IN_TIME { get; set; }

        public long IN_DATE { get; set; }

        public long? CLINICAL_IN_TIME { get; set; }

        public long? OUT_TIME { get; set; }

        public long? TDL_PATIENT_TYPE_ID { get; set; }

        [Required]
        [StringLength(6)]
        public string PATIENT_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string PATIENT_TYPE_NAME { get; set; }

        [Required]
        [StringLength(2)]
        public string TREATMENT_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string TREATMENT_TYPE_NAME { get; set; }
    }
}

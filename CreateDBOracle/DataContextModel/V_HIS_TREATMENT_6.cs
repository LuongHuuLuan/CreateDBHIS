namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_TREATMENT_6")]
    public partial class V_HIS_TREATMENT_6
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
        public string TREATMENT_CODE { get; set; }

        public long? TREATMENT_STT_ID { get; set; }

        public long PATIENT_ID { get; set; }

        public long BRANCH_ID { get; set; }

        public short? IS_PAUSE { get; set; }

        public short? IS_LOCK_HEIN { get; set; }

        public short? IS_TEMPORARY_LOCK { get; set; }

        public short? IS_LOCK_FEE { get; set; }

        public short? IS_REMOTE { get; set; }

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

        public short? IS_HOLD_BHYT_CARD { get; set; }

        public short? IS_AUTO_DISCOUNT { get; set; }

        public decimal? AUTO_DISCOUNT_RATIO { get; set; }

        public long? FEE_LOCK_TIME { get; set; }

        public long? FEE_LOCK_ORDER { get; set; }

        public long? FEE_LOCK_ROOM_ID { get; set; }

        public long? FEE_LOCK_DEPARTMENT_ID { get; set; }

        public long IN_TIME { get; set; }

        public long IN_DATE { get; set; }

        public long? CLINICAL_IN_TIME { get; set; }

        public long? OUT_TIME { get; set; }

        public short? IS_IN_CODE_REQUEST { get; set; }

        [StringLength(20)]
        public string IN_CODE { get; set; }

        public long? IN_ROOM_ID { get; set; }

        public long? IN_DEPARTMENT_ID { get; set; }

        [StringLength(50)]
        public string IN_LOGINNAME { get; set; }

        [StringLength(100)]
        public string IN_USERNAME { get; set; }

        public long? IN_TREATMENT_TYPE_ID { get; set; }

        public long? IN_ICD_ID__DELETE { get; set; }

        [StringLength(10)]
        public string IN_ICD_CODE { get; set; }

        [StringLength(500)]
        public string IN_ICD_NAME { get; set; }

        [StringLength(500)]
        public string IN_ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string IN_ICD_TEXT { get; set; }

        [StringLength(200)]
        public string HOSPITALIZATION_REASON { get; set; }

        [StringLength(50)]
        public string DOCTOR_LOGINNAME { get; set; }

        [StringLength(100)]
        public string DOCTOR_USERNAME { get; set; }

        [StringLength(50)]
        public string END_LOGINNAME { get; set; }

        [StringLength(100)]
        public string END_USERNAME { get; set; }

        public long? END_ROOM_ID { get; set; }

        public long? END_DEPARTMENT_ID { get; set; }

        [StringLength(30)]
        public string END_CODE { get; set; }

        [StringLength(50)]
        public string EXTRA_END_CODE { get; set; }

        public short? IS_END_CODE_REQUEST { get; set; }

        public decimal? TREATMENT_DAY_COUNT { get; set; }

        public long? TREATMENT_RESULT_ID { get; set; }

        public long? TREATMENT_END_TYPE_ID { get; set; }

        public long? TREATMENT_END_TYPE_EXT_ID { get; set; }

        [StringLength(500)]
        public string ADVISE { get; set; }

        public long? APPOINTMENT_TIME { get; set; }

        [StringLength(500)]
        public string APPOINTMENT_DESC { get; set; }

        [StringLength(12)]
        public string APPOINTMENT_CODE { get; set; }

        public long? OUT_DATE { get; set; }

        [StringLength(9)]
        public string OUT_CODE { get; set; }

        public short? IS_OUT_CODE_REQUEST { get; set; }

        public short? IS_CHRONIC { get; set; }

        public short? IS_YDT_UPLOAD { get; set; }

        public long? OWE_TYPE_ID { get; set; }

        public long? OWE_MODIFY_TIME { get; set; }

        public long? STORE_TIME { get; set; }

        public long? DATA_STORE_ID { get; set; }

        [StringLength(20)]
        public string STORE_CODE { get; set; }

        public short? IS_NOT_CHECK_LHMP { get; set; }

        public short? IS_NOT_CHECK_LHSP { get; set; }

        [StringLength(20)]
        public string TDL_HEIN_CARD_NUMBER { get; set; }

        [StringLength(200)]
        public string JSON_PRINT_ID { get; set; }

        [StringLength(200)]
        public string JSON_FORM_ID { get; set; }

        public short? IS_EMERGENCY { get; set; }

        public long? EMERGENCY_WTIME_ID { get; set; }

        public long? KSK_ORDER { get; set; }

        public long? TDL_KSK_CONTRACT_ID { get; set; }

        [StringLength(20)]
        public string HRM_KSK_CODE { get; set; }

        [StringLength(3000)]
        public string CLINICAL_NOTE { get; set; }

        [StringLength(4000)]
        public string SUBCLINICAL_RESULT { get; set; }

        [StringLength(3000)]
        public string TREATMENT_DIRECTION { get; set; }

        [StringLength(3000)]
        public string TREATMENT_METHOD { get; set; }

        [StringLength(3000)]
        public string PATIENT_CONDITION { get; set; }

        [StringLength(10)]
        public string MEDI_ORG_CODE { get; set; }

        [StringLength(500)]
        public string MEDI_ORG_NAME { get; set; }

        public long? TRAN_PATI_FORM_ID { get; set; }

        public long? TRAN_PATI_REASON_ID { get; set; }

        public long? TRAN_PATI_TECH_ID { get; set; }

        [StringLength(3000)]
        public string USED_MEDICINE { get; set; }

        [StringLength(3000)]
        public string TRANSPORT_VEHICLE { get; set; }

        [StringLength(200)]
        public string TRANSPORTER { get; set; }

        public short? IS_TRANSFER_IN { get; set; }

        [StringLength(10)]
        public string TRANSFER_IN_MEDI_ORG_CODE { get; set; }

        [StringLength(500)]
        public string TRANSFER_IN_MEDI_ORG_NAME { get; set; }

        [StringLength(20)]
        public string TRANSFER_IN_CODE { get; set; }

        public long? TRANSFER_IN_ICD_ID__DELETE { get; set; }

        [StringLength(10)]
        public string TRANSFER_IN_ICD_CODE { get; set; }

        [StringLength(500)]
        public string TRANSFER_IN_ICD_NAME { get; set; }

        public long? TRANSFER_IN_CMKT { get; set; }

        public long? TRANSFER_IN_FORM_ID { get; set; }

        public long? TRANSFER_IN_REASON_ID { get; set; }

        public decimal? SICK_LEAVE_DAY { get; set; }

        public long? SICK_LEAVE_FROM { get; set; }

        public long? SICK_LEAVE_TO { get; set; }

        public long? DEATH_TIME { get; set; }

        public long? DEATH_CAUSE_ID { get; set; }

        public long? DEATH_WITHIN_ID { get; set; }

        [StringLength(500)]
        public string DEATH_PLACE { get; set; }

        [StringLength(100)]
        public string DEATH_DOCUMENT_TYPE { get; set; }

        [StringLength(50)]
        public string DEATH_DOCUMENT_NUMBER { get; set; }

        [StringLength(500)]
        public string DEATH_DOCUMENT_PLACE { get; set; }

        public long? DEATH_DOCUMENT_DATE { get; set; }

        [StringLength(3000)]
        public string MAIN_CAUSE { get; set; }

        [StringLength(3000)]
        public string SURGERY { get; set; }

        public short? IS_HAS_AUPOPSY { get; set; }

        public long? TDL_FIRST_EXAM_ROOM_ID { get; set; }

        public long? TDL_TREATMENT_TYPE_ID { get; set; }

        public long? TDL_PATIENT_TYPE_ID { get; set; }

        [StringLength(6)]
        public string TDL_HEIN_MEDI_ORG_CODE { get; set; }

        [StringLength(500)]
        public string TDL_HEIN_MEDI_ORG_NAME { get; set; }

        [StringLength(1000)]
        public string XML4210_URL { get; set; }

        public long? FUND_ID { get; set; }

        [StringLength(255)]
        public string FUND_NUMBER { get; set; }

        public long? FUND_FROM_TIME { get; set; }

        public long? FUND_TO_TIME { get; set; }

        public long? FUND_ISSUE_TIME { get; set; }

        [StringLength(200)]
        public string FUND_TYPE_NAME { get; set; }

        [StringLength(200)]
        public string FUND_COMPANY_NAME { get; set; }

        public decimal? FUND_BUDGET { get; set; }

        public long? FUND_PAY_TIME { get; set; }

        public long? FUND_SEND_FILE_TIME { get; set; }

        [StringLength(200)]
        public string FUND_CUSTOMER_NAME { get; set; }

        public short? IS_INTEGRATE_HIS_SENT { get; set; }

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

        [StringLength(500)]
        public string TDL_PATIENT_AVATAR_URL { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        public long TDL_PATIENT_GENDER_ID { get; set; }

        [Required]
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

        [StringLength(50)]
        public string TDL_PATIENT_RELATIVE_TYPE { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_RELATIVE_NAME { get; set; }

        [StringLength(50)]
        public string TDL_PATIENT_ACCOUNT_NUMBER { get; set; }

        [StringLength(20)]
        public string TDL_PATIENT_TAX_CODE { get; set; }

        public long? TRANSFER_IN_TIME_FROM { get; set; }

        public long? TRANSFER_IN_TIME_TO { get; set; }

        public long? SURGERY_APPOINTMENT_TIME { get; set; }

        [StringLength(500)]
        public string APPOINTMENT_SURGERY { get; set; }

        public long? MEDI_RECORD_TYPE_ID { get; set; }

        [StringLength(20)]
        public string APPOINTMENT_EXAM_ROOM_IDS { get; set; }

        [StringLength(1000)]
        public string DEPARTMENT_IDS { get; set; }

        [StringLength(200)]
        public string CO_DEPARTMENT_IDS { get; set; }

        public long? LAST_DEPARTMENT_ID { get; set; }

        [StringLength(1000)]
        public string PROVISIONAL_DIAGNOSIS { get; set; }

        public long? TREATMENT_ORDER { get; set; }

        [StringLength(12)]
        public string TDL_PATIENT_MOBILE { get; set; }

        [StringLength(20)]
        public string TDL_PATIENT_PHONE { get; set; }

        [StringLength(20)]
        public string SICK_HEIN_CARD_NUMBER { get; set; }

        public short? NEED_SICK_LEAVE_CERT { get; set; }

        public long? MEDI_RECORD_ID { get; set; }

        public long? PROGRAM_ID { get; set; }

        public short? IS_SYNC_EMR { get; set; }

        public long? XML4210_RESULT { get; set; }

        [StringLength(500)]
        public string XML4210_DESC { get; set; }

        [StringLength(1000)]
        public string COLLINEAR_XML4210_URL { get; set; }

        public long? COLLINEAR_XML4210_RESULT { get; set; }

        [StringLength(500)]
        public string COLLINEAR_XML4210_DESC { get; set; }

        [StringLength(500)]
        public string REJECT_STORE_REASON { get; set; }

        public short? IS_APPROVE_FINISH { get; set; }

        [StringLength(500)]
        public string APPROVE_FINISH_NOTE { get; set; }

        [StringLength(10)]
        public string TRADITIONAL_ICD_CODE { get; set; }

        [StringLength(500)]
        public string TRADITIONAL_ICD_NAME { get; set; }

        [StringLength(10)]
        public string TRADITIONAL_IN_ICD_CODE { get; set; }

        [StringLength(500)]
        public string TRADITIONAL_IN_ICD_NAME { get; set; }

        [StringLength(500)]
        public string TRADITIONAL_ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string TRADITIONAL_ICD_TEXT { get; set; }

        [StringLength(500)]
        public string TRADITIONAL_IN_ICD_SUB_CODE { get; set; }

        [StringLength(500)]
        public string TRADITIONAL_IN_ICD_TEXT { get; set; }

        [StringLength(10)]
        public string TRADITIONAL_TRANS_IN_ICD_CODE { get; set; }

        [StringLength(500)]
        public string TRADITIONAL_TRANS_IN_ICD_NAME { get; set; }

        public long? OTHER_PAY_SOURCE_ID { get; set; }

        public short? IS_KSK_APPROVE { get; set; }

        public long? TDL_HEIN_CARD_FROM_TIME { get; set; }

        public long? TDL_HEIN_CARD_TO_TIME { get; set; }

        public long? APPOINTMENT_DATE { get; set; }

        [StringLength(500)]
        public string EYE_TENSION_LEFT { get; set; }

        [StringLength(500)]
        public string EYE_TENSION_RIGHT { get; set; }

        [StringLength(500)]
        public string EYESIGHT_LEFT { get; set; }

        [StringLength(500)]
        public string EYESIGHT_RIGHT { get; set; }

        [StringLength(500)]
        public string EYESIGHT_GLASS_LEFT { get; set; }

        [StringLength(500)]
        public string EYESIGHT_GLASS_RIGHT { get; set; }

        public long? APPOINTMENT_PERIOD_ID { get; set; }

        [StringLength(50)]
        public string SICK_LOGINNAME { get; set; }

        [StringLength(100)]
        public string SICK_USERNAME { get; set; }

        public short? IS_EXPORTED_XML2076 { get; set; }

        public long? DOCUMENT_BOOK_ID { get; set; }

        public long? SICK_NUM_ORDER { get; set; }

        [StringLength(10)]
        public string TDL_DOCUMENT_BOOK_CODE { get; set; }

        public long? APPROVAL_STORE_STT_ID { get; set; }

        public long? TDL_PATIENT_CLASSIFY_ID { get; set; }

        public decimal? VIR_IN_MONTH { get; set; }

        public decimal? VIR_OUT_MONTH { get; set; }

        [StringLength(20)]
        public string IN_CODE_SEED_CODE { get; set; }

        [StringLength(20)]
        public string EXTRA_END_CODE_SEED_CODE { get; set; }

        [StringLength(1000)]
        public string XML2076_URL { get; set; }

        [StringLength(500)]
        public string XML2076_DESC { get; set; }

        public decimal? VIR_IN_YEAR { get; set; }

        public decimal? VIR_OUT_YEAR { get; set; }

        [StringLength(50)]
        public string FEE_LOCK_LOGINNAME { get; set; }

        [StringLength(100)]
        public string FEE_LOCK_USERNAME { get; set; }

        public long? EMR_COVER_TYPE_ID { get; set; }

        [StringLength(500)]
        public string CONTRAINDICATION_IDS { get; set; }

        public short? IS_CREATING_TRANSACTION { get; set; }

        [StringLength(200)]
        public string CO_TREAT_DEPARTMENT_IDS { get; set; }

        public long? RECORD_INSPECTION_STT_ID { get; set; }

        [StringLength(4000)]
        public string RECORD_INSPECTION_REJECT_NOTE { get; set; }

        [StringLength(20)]
        public string TDL_SOCIAL_INSURANCE_NUMBER { get; set; }

        public long? APPOINTMENT_EXAM_SERVICE_ID { get; set; }

        [StringLength(1000)]
        public string TRANSFER_IN_URL { get; set; }

        public long? HOSPITALIZE_DEPARTMENT_ID { get; set; }

        public long? DEATH_CERT_BOOK_ID { get; set; }

        public long? DEATH_CERT_NUM { get; set; }

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

        public long? NUM_ORDER_ISSUE_ID { get; set; }

        public long? NEXT_EXAM_NUM_ORDER { get; set; }

        [StringLength(6)]
        public string NEXT_EXAM_FROM_TIME { get; set; }

        [StringLength(6)]
        public string NEXT_EXAM_TO_TIME { get; set; }

        [StringLength(200)]
        public string TDL_PATIENT_RELATIVE_ADDRESS { get; set; }

        [StringLength(12)]
        public string TDL_RELATIVE_CMND_NUMBER { get; set; }

        [StringLength(12)]
        public string TDL_PATIENT_RELATIVE_MOBILE { get; set; }

        [StringLength(12)]
        public string TDL_PATIENT_RELATIVE_PHONE { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_MOTHER_NAME { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_FATHER_NAME { get; set; }

        [StringLength(50)]
        public string PERMISION_UPDATE { get; set; }

        [StringLength(3)]
        public string TDL_PATIENT_NATIONAL_CODE { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_PROVINCE_NAME { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_DISTRICT_NAME { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_COMMUNE_NAME { get; set; }

        public long? TDL_PATIENT_POSITION_ID { get; set; }

        public short? IS_BHYT_HOLDED { get; set; }

        [StringLength(9)]
        public string TDL_PATIENT_PASSPORT_NUMBER { get; set; }

        public long? TDL_PATIENT_PASSPORT_DATE { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_PASSPORT_PLACE { get; set; }

        public long? TDL_PATIENT_WORK_PLACE_ID { get; set; }

        [StringLength(10)]
        public string SHOW_ICD_CODE { get; set; }

        [StringLength(500)]
        public string SHOW_ICD_NAME { get; set; }

        [StringLength(500)]
        public string SHOW_ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string SHOW_ICD_TEXT { get; set; }

        public long? TRAN_PATI_BOOK_TIME { get; set; }

        public long? TRAN_PATI_BOOK_NUMBER { get; set; }

        [StringLength(50)]
        public string TRAN_PATI_DOCTOR_LOGINNAME { get; set; }

        [StringLength(100)]
        public string TRAN_PATI_DOCTOR_USERNAME { get; set; }

        [StringLength(50)]
        public string TRAN_PATI_DEPARTMENT_LOGINNAME { get; set; }

        [StringLength(100)]
        public string TRAN_PATI_DEPARTMENT_USERNAME { get; set; }

        [StringLength(50)]
        public string TRAN_PATI_HOSPITAL_LOGINNAME { get; set; }

        [StringLength(100)]
        public string TRAN_PATI_HOSPITAL_USERNAME { get; set; }

        public decimal? VIR_TRAN_PATI_BOOK_YEAR { get; set; }

        [StringLength(150)]
        public string TDL_PATIENT_UNSIGNED_NAME { get; set; }

        public long? OUTPATIENT_DATE_FROM { get; set; }

        public long? OUTPATIENT_DATE_TO { get; set; }

        public long? VACCINE_ID { get; set; }

        public long? VACINATION_ORDER { get; set; }

        public long? EPIDEMILOGY_CONTACT_TYPE { get; set; }

        [StringLength(4000)]
        public string EPIDEMILOGY_SYMPTOM { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_ETHNIC_NAME { get; set; }

        public short? IS_TUBERCULOSIS { get; set; }

        public long? DOCUMENT_VIEW_COUNT { get; set; }

        public long? EXIT_DEPARTMENT_ID { get; set; }

        [StringLength(20)]
        public string COVID_PATIENT_CODE { get; set; }

        [StringLength(20)]
        public string STORE_BORDEREAU_CODE { get; set; }

        public long? HEIN_LOCK_TIME { get; set; }

        public short? HAS_AUTO_CREATE_RATION { get; set; }

        public short? IS_OLD_TEMP_BED { get; set; }

        public short? TDL_KSK_CONTRACT_IS_RESTRICTED { get; set; }

        public long? NUMBER_OF_FULL_TERM_BIRTH { get; set; }

        public long? NUMBER_OF_PREMATURE_BIRTH { get; set; }

        public long? NUMBER_OF_MISCARRIAGE { get; set; }

        public short? NUMBER_OF_TESTS { get; set; }

        public short? TEST_HIV { get; set; }

        public short? TEST_SYPHILIS { get; set; }

        public short? IS_TEST_BLOOD_SUGAR { get; set; }

        public short? IS_EARLY_NEWBORN_CARE { get; set; }

        public short? NEWBORN_CARE_AT_HOME { get; set; }

        public short? TEST_HEPATITIS_B { get; set; }

        public long? RECEPTION_FORM { get; set; }

        [StringLength(50)]
        public string END_DEPARTMENT_HEAD_LOGINNAME { get; set; }

        [StringLength(100)]
        public string END_DEPARTMENT_HEAD_USERNAME { get; set; }

        [StringLength(50)]
        public string HOSPITAL_DIRECTOR_LOGINNAME { get; set; }

        [StringLength(100)]
        public string HOSPITAL_DIRECTOR_USERNAME { get; set; }

        [StringLength(50)]
        public string END_DEPT_SUBS_HEAD_LOGINNAME { get; set; }

        [StringLength(100)]
        public string END_DEPT_SUBS_HEAD_USERNAME { get; set; }

        [StringLength(50)]
        public string HOSP_SUBS_DIRECTOR_LOGINNAME { get; set; }

        [StringLength(100)]
        public string HOSP_SUBS_DIRECTOR_USERNAME { get; set; }

        [StringLength(10)]
        public string TUBERCULOSIS_ISSUED_ORG_CODE { get; set; }

        [StringLength(500)]
        public string TUBERCULOSIS_ISSUED_ORG_NAME { get; set; }

        public long? TUBERCULOSIS_ISSUED_DATE { get; set; }

        public short? HAS_CARD { get; set; }

        public decimal? TOTAL_BILL_AMOUNT { get; set; }

        public decimal? TOTAL_BILL_OTHER_AMOUNT { get; set; }

        public decimal? TOTAL_BILL_TRANSFER_AMOUNT { get; set; }

        public decimal? TOTAL_BILL_EXEMPTION { get; set; }

        public decimal? TOTAL_BILL_FUND { get; set; }

        public decimal? TOTAL_DEPOSIT_AMOUNT { get; set; }

        public decimal? TOTAL_REPAY_AMOUNT { get; set; }

        public decimal? TOTAL_PRICE { get; set; }

        public decimal? TOTAL_HEIN_PRICE { get; set; }

        public decimal? TOTAL_OTHER_COPAID_PRICE { get; set; }

        public decimal? TOTAL_PATIENT_PRICE { get; set; }

        public decimal? TOTAL_DISCOUNT { get; set; }

        public decimal? TOTAL_PRICE_EXPEND { get; set; }

        public decimal? COUNT_HEIN_APPROVAL { get; set; }

        public decimal? TOTAL_DEBT_AMOUNT { get; set; }

        public decimal? TOTAL_PATIENT_PRICE_BHYT { get; set; }

        public decimal? TOTAL_OTHER_SOURCE_PRICE { get; set; }

        public decimal? LAST_DEPOSIT_TIME { get; set; }

        public decimal? TOTAL_SERVICE_DEPOSIT_AMOUNT { get; set; }

        [StringLength(500)]
        public string WORK_PLACE_ADDRESS { get; set; }

        [StringLength(20)]
        public string WORK_PLACE_TAX_CODE { get; set; }

        [StringLength(10)]
        public string TDL_PATIENT_CLASSIFY_CODE { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_CLASSIFY_NAME { get; set; }

        [StringLength(15)]
        public string TDL_PATIENT_POSITION_CODE { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_POSITION_NAME { get; set; }

        [StringLength(2)]
        public string TDL_TREATMENT_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string TDL_TREATMENT_TYPE_NAME { get; set; }

        public long? DIS_SERVICE_DEPOSIT_OPTION { get; set; }

        public short? IS_DIS_SERVICE_REPAY { get; set; }

        public short? DIS_DEPOSIT_OPTION { get; set; }

        public short? DIS_DEPOSIT_OPTION_REQUEST { get; set; }

        public decimal? LOCKING_AMOUNT { get; set; }

        public decimal? REMAIN_AMOUNT { get; set; }

        public long? DEPARTMENT_ID { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_RATION_SCHEDULE")]
    public partial class V_HIS_RATION_SCHEDULE
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

        public long? TREATMENT_ID { get; set; }

        public long? RATION_TIME_ID { get; set; }

        public long? PATIENT_TYPE_ID { get; set; }

        public long? SERVICE_ID { get; set; }

        public long? REFECTORY_ROOM_ID { get; set; }

        public decimal? AMOUNT { get; set; }

        public long? FROM_TIME { get; set; }

        public long? TO_TIME { get; set; }

        public short? IS_FOR_HOMIE { get; set; }

        public short? IS_HALF_IN_FIRST_DAY { get; set; }

        [StringLength(1000)]
        public string NOTE { get; set; }

        public long? LAST_ASSIGN_DATE { get; set; }

        public long? DEPARTMENT_ID { get; set; }

        public long? VIR_FROM_DATE { get; set; }

        public long? VIR_TO_DATE { get; set; }

        [StringLength(2)]
        public string RATION_TIME_CODE { get; set; }

        [StringLength(100)]
        public string RATION_TIME_NAME { get; set; }

        [StringLength(6)]
        public string PATIENT_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string PATIENT_TYPE_NAME { get; set; }

        [StringLength(25)]
        public string SERVICE_CODE { get; set; }

        [StringLength(500)]
        public string SERVICE_NAME { get; set; }

        [StringLength(10)]
        public string REFECTORY_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string REFECTORY_ROOM_NAME { get; set; }

        [StringLength(10)]
        public string ICD_CODE { get; set; }

        [StringLength(500)]
        public string ICD_NAME { get; set; }

        [StringLength(500)]
        public string ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string ICD_TEXT { get; set; }

        public long? LAST_DEPARTMENT_ID { get; set; }

        public long? PATIENT_ID { get; set; }

        public long? TDL_TREATMENT_TYPE_ID { get; set; }

        public long? TDL_HEIN_CARD_FROM_TIME { get; set; }

        [StringLength(50)]
        public string TDL_PATIENT_ACCOUNT_NUMBER { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        [StringLength(500)]
        public string TDL_PATIENT_AVATAR_URL { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_CAREER_NAME { get; set; }

        public long? TDL_PATIENT_CCCD_DATE { get; set; }

        [StringLength(12)]
        public string TDL_PATIENT_CCCD_NUMBER { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_CCCD_PLACE { get; set; }

        public long? TDL_PATIENT_CLASSIFY_ID { get; set; }

        public long? TDL_PATIENT_CMND_DATE { get; set; }

        [StringLength(9)]
        public string TDL_PATIENT_CMND_NUMBER { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_CMND_PLACE { get; set; }

        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [StringLength(6)]
        public string TDL_PATIENT_COMMUNE_CODE { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_COMMUNE_NAME { get; set; }

        [StringLength(4)]
        public string TDL_PATIENT_DISTRICT_CODE { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_DISTRICT_NAME { get; set; }

        public long? TDL_PATIENT_DOB { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_ETHNIC_NAME { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_FATHER_NAME { get; set; }

        [StringLength(30)]
        public string TDL_PATIENT_FIRST_NAME { get; set; }

        public long? TDL_PATIENT_GENDER_ID { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        public short? TDL_PATIENT_IS_HAS_NOT_DAY_DOB { get; set; }

        [StringLength(70)]
        public string TDL_PATIENT_LAST_NAME { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_MILITARY_RANK_NAME { get; set; }

        [StringLength(12)]
        public string TDL_PATIENT_MOBILE { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_MOTHER_NAME { get; set; }

        [StringLength(3)]
        public string TDL_PATIENT_MPS_NATIONAL_CODE { get; set; }

        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        [StringLength(3)]
        public string TDL_PATIENT_NATIONAL_CODE { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_NATIONAL_NAME { get; set; }

        public long? TDL_PATIENT_PASSPORT_DATE { get; set; }

        [StringLength(9)]
        public string TDL_PATIENT_PASSPORT_NUMBER { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_PASSPORT_PLACE { get; set; }

        [StringLength(20)]
        public string TDL_PATIENT_PHONE { get; set; }

        public long? TDL_PATIENT_POSITION_ID { get; set; }

        [StringLength(3)]
        public string TDL_PATIENT_PROVINCE_CODE { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_PROVINCE_NAME { get; set; }

        [StringLength(200)]
        public string TDL_PATIENT_RELATIVE_ADDRESS { get; set; }

        [StringLength(12)]
        public string TDL_PATIENT_RELATIVE_MOBILE { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_RELATIVE_NAME { get; set; }

        [StringLength(12)]
        public string TDL_PATIENT_RELATIVE_PHONE { get; set; }

        [StringLength(50)]
        public string TDL_PATIENT_RELATIVE_TYPE { get; set; }

        [StringLength(20)]
        public string TDL_PATIENT_TAX_CODE { get; set; }

        public long? TDL_PATIENT_TYPE_ID { get; set; }

        [StringLength(150)]
        public string TDL_PATIENT_UNSIGNED_NAME { get; set; }

        [StringLength(500)]
        public string TDL_PATIENT_WORK_PLACE { get; set; }

        public long? TDL_PATIENT_WORK_PLACE_ID { get; set; }

        [StringLength(500)]
        public string TDL_PATIENT_WORK_PLACE_NAME { get; set; }

        [StringLength(20)]
        public string TDL_HEIN_CARD_NUMBER { get; set; }

        public long? TDL_HEIN_CARD_TO_TIME { get; set; }

        [StringLength(6)]
        public string TDL_HEIN_MEDI_ORG_CODE { get; set; }

        [StringLength(500)]
        public string TDL_HEIN_MEDI_ORG_NAME { get; set; }

        public long? OUT_TIME { get; set; }

        public short? IS_PAUSE { get; set; }

        [StringLength(20)]
        public string LAST_DEPARTMENT_CODE { get; set; }

        [StringLength(100)]
        public string LAST_DEPARTMENT_NAME { get; set; }
    }
}

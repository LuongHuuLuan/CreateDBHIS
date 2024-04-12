namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_BABY")]
    public partial class V_HIS_BABY
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

        public long TREATMENT_ID { get; set; }

        [StringLength(100)]
        public string BABY_NAME { get; set; }

        public long? GENDER_ID { get; set; }

        public long? BORN_TYPE_ID { get; set; }

        public long? BORN_RESULT_ID { get; set; }

        public long? BORN_POSITION_ID { get; set; }

        public long? BORN_TIME { get; set; }

        public long? BABY_ORDER { get; set; }

        public long? MONTH_COUNT { get; set; }

        public long? WEEK_COUNT { get; set; }

        public decimal? HEIGHT { get; set; }

        public decimal? WEIGHT { get; set; }

        public decimal? HEAD { get; set; }

        [StringLength(500)]
        public string MIDWIFE { get; set; }

        [StringLength(100)]
        public string FATHER_NAME { get; set; }

        [StringLength(2)]
        public string ETHNIC_CODE { get; set; }

        [StringLength(100)]
        public string ETHNIC_NAME { get; set; }

        public long? BIRTH_CERT_NUM { get; set; }

        public long? BIRTH_CERT_BOOK_ID { get; set; }

        [StringLength(50)]
        public string ISSUER_LOGINNAME { get; set; }

        [StringLength(100)]
        public string ISSUER_USERNAME { get; set; }

        public long? CURRENT_ALIVE { get; set; }

        public long? NUMBER_OF_PREGNANCIES { get; set; }

        public short? IS_DIFFICULT_BIRTH { get; set; }

        public short? IS_HAEMORRHAGE { get; set; }

        public short? IS_UTERINE_RUPTURE { get; set; }

        public short? IS_PUERPERAL { get; set; }

        public short? IS_BACTERIAL_CONTAMINATION { get; set; }

        public short? IS_TETANUS { get; set; }

        public short? IS_MOTHER_DEATH { get; set; }

        [StringLength(1000)]
        public string BIRTHPLACE { get; set; }

        public short? IS_FETAL_DEATH_22_WEEKS { get; set; }

        public short? IS_INJECT_K1 { get; set; }

        public short? IS_INJECT_B { get; set; }

        public long? POSTPARTUM_CARE { get; set; }

        [StringLength(200)]
        public string METHOD_STYLE { get; set; }

        [StringLength(4000)]
        public string NOTE { get; set; }

        public long? DEATH_DATE { get; set; }

        [StringLength(15)]
        public string HEIN_CARD_NUMBER_TMP { get; set; }

        public long? DEPARTMENT_ID { get; set; }

        public short? IS_SURGERY { get; set; }

        public long? NUMBER_CHILDREN_BIRTH { get; set; }

        [StringLength(4000)]
        public string SYNC_FAILD_REASON { get; set; }

        public long? SYNC_RESULT_TYPE { get; set; }

        public long? SYNC_TIME { get; set; }

        public long? ISSUED_DATE { get; set; }

        public short? BIRTHPLACE_TYPE { get; set; }

        [StringLength(3)]
        public string BIRTH_PROVINCE_CODE { get; set; }

        [StringLength(100)]
        public string BIRTH_PROVINCE_NAME { get; set; }

        [StringLength(4)]
        public string BIRTH_DISTRICT_CODE { get; set; }

        [StringLength(120)]
        public string BIRTH_DISTRICT_NAME { get; set; }

        [StringLength(6)]
        public string BIRTH_COMMUNE_CODE { get; set; }

        [StringLength(120)]
        public string BIRTH_COMMUNE_NAME { get; set; }

        [StringLength(20)]
        public string BIRTH_HOSPITAL_CODE { get; set; }

        [StringLength(500)]
        public string BIRTH_HOSPITAL_NAME { get; set; }

        [StringLength(2)]
        public string GENDER_CODE { get; set; }

        [StringLength(100)]
        public string GENDER_NAME { get; set; }

        [StringLength(2)]
        public string BORN_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string BORN_TYPE_NAME { get; set; }

        [StringLength(2)]
        public string BORN_RESULT_CODE { get; set; }

        [StringLength(100)]
        public string BORN_RESULT_NAME { get; set; }

        [StringLength(2)]
        public string BORN_POSITION_CODE { get; set; }

        [StringLength(100)]
        public string BORN_POSITION_NAME { get; set; }

        [StringLength(10)]
        public string BIRTH_CERT_BOOK_CODE { get; set; }

        [StringLength(100)]
        public string BIRTH_CERT_BOOK_NAME { get; set; }

        [StringLength(12)]
        public string TREATMENT_CODE { get; set; }

        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        public long? TDL_PATIENT_DOB { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        public long? IN_TIME { get; set; }

        public long? OUT_TIME { get; set; }

        [StringLength(20)]
        public string TDL_HEIN_CARD_NUMBER { get; set; }

        [StringLength(3)]
        public string TDL_PATIENT_NATIONAL_CODE { get; set; }

        public long? TDL_PATIENT_CCCD_DATE { get; set; }

        [StringLength(12)]
        public string TDL_PATIENT_CCCD_NUMBER { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_CCCD_PLACE { get; set; }

        public long? TDL_PATIENT_CMND_DATE { get; set; }

        [StringLength(9)]
        public string TDL_PATIENT_CMND_NUMBER { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_CMND_PLACE { get; set; }

        public long? TDL_PATIENT_PASSPORT_DATE { get; set; }

        [StringLength(9)]
        public string TDL_PATIENT_PASSPORT_NUMBER { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_PASSPORT_PLACE { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        [StringLength(3)]
        public string TDL_PATIENT_PROVINCE_CODE { get; set; }

        [StringLength(4)]
        public string TDL_PATIENT_DISTRICT_CODE { get; set; }

        [StringLength(6)]
        public string TDL_PATIENT_COMMUNE_CODE { get; set; }

        public long? NUMBER_OF_PREMATURE_BIRTH { get; set; }

        public long? BRANCH_ID { get; set; }

        [StringLength(20)]
        public string TDL_SOCIAL_INSURANCE_NUMBER { get; set; }

        public long? NUMBER_OF_BIRTH { get; set; }

        [StringLength(2)]
        public string TDL_PATIENT_ETHNIC_CODE { get; set; }

        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_EXECUTE_ROOM")]
    public partial class V_HIS_EXECUTE_ROOM
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
        [StringLength(20)]
        public string EXECUTE_ROOM_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string EXECUTE_ROOM_NAME { get; set; }

        public long ROOM_ID { get; set; }

        public short? IS_EXAM { get; set; }

        public short? IS_EMERGENCY { get; set; }

        public short? IS_VITAMIN_A { get; set; }

        public short? IS_VACCINE { get; set; }

        public short? IS_SPECIALITY { get; set; }

        public short? IS_SURGERY { get; set; }

        public short? IS_PRIORITIZE { get; set; }

        public short? IS_PAUSE_ENCLITIC { get; set; }

        public long? MAX_REQUEST_BY_DAY { get; set; }

        public long? MAX_REQ_BHYT_BY_DAY { get; set; }

        public long? NUM_ORDER { get; set; }

        public long? AVERAGE_ETA { get; set; }

        public long? KIDNEY_SHIFT_COUNT { get; set; }

        public short? IS_KIDNEY { get; set; }

        [StringLength(20)]
        public string TEST_TYPE_CODE { get; set; }

        public long? MAX_APPOINTMENT_BY_DAY { get; set; }

        public short? IS_TEST { get; set; }

        public short? IS_AUTO_EXPEND_ADD_EXAM { get; set; }

        public long? MAX_PATIENT_BY_DAY { get; set; }

        public short? ALLOW_NOT_CHOOSE_SERVICE { get; set; }

        public long DEPARTMENT_ID { get; set; }

        public long ROOM_TYPE_ID { get; set; }

        public short? IS_PAUSE { get; set; }

        public short? IS_RESTRICT_TIME { get; set; }

        public short? IS_RESTRICT_MEDICINE_TYPE { get; set; }

        public short? IS_RESTRICT_EXECUTE_ROOM { get; set; }

        public long? ROOM_GROUP_ID { get; set; }

        public long? HOLD_ORDER { get; set; }

        public long? SPECIALITY_ID { get; set; }

        [StringLength(200)]
        public string ADDRESS { get; set; }

        public short? IS_USE_KIOSK { get; set; }

        [StringLength(10)]
        public string ORDER_ISSUE_CODE { get; set; }

        public short? IS_RESTRICT_PATIENT_TYPE { get; set; }

        public short? IS_RESTRICT_REQ_SERVICE { get; set; }

        [StringLength(100)]
        public string DEFAULT_DRUG_STORE_IDS { get; set; }

        public short? IS_ALLOW_NO_ICD { get; set; }

        public long? AREA_ID { get; set; }

        [StringLength(200)]
        public string SCREEN_SAVER_MODULE_LINK { get; set; }

        [Required]
        [StringLength(2)]
        public string ROOM_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string ROOM_TYPE_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        [Required]
        [StringLength(10)]
        public string G_CODE { get; set; }

        public long BRANCH_ID { get; set; }

        [StringLength(10)]
        public string ROOM_GROUP_CODE { get; set; }

        [StringLength(200)]
        public string ROOM_GROUP_NAME { get; set; }

        [StringLength(50)]
        public string SPECIALITY_CODE { get; set; }

        [StringLength(200)]
        public string SPECIALITY_NAME { get; set; }

        public decimal? BHYT_LIMIT { get; set; }

        [StringLength(2)]
        public string AREA_CODE { get; set; }

        [StringLength(100)]
        public string AREA_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string BRANCH_CODE { get; set; }

        [StringLength(6)]
        public string HEIN_MEDI_ORG_CODE { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_EXECUTE_ROOM_1")]
    public partial class V_HIS_EXECUTE_ROOM_1
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

        public decimal? TOTAL_OPEN_SERVICE_REQ { get; set; }

        public decimal? TOTAL_TODAY_SERVICE_REQ { get; set; }

        public long BRANCH_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        [StringLength(200)]
        public string ROOM_GROUP_NAME { get; set; }

        [StringLength(10)]
        public string ROOM_GROUP_CODE { get; set; }

        public long? ROOM_GROUP_ID { get; set; }

        public short? IS_USE_KIOSK { get; set; }

        public long? HOLD_ORDER { get; set; }

        [StringLength(200)]
        public string ADDRESS { get; set; }

        public long? AREA_ID { get; set; }

        [StringLength(50)]
        public string RESPONSIBLE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string RESPONSIBLE_USERNAME { get; set; }

        public short? IS_BLOCK_NUM_ORDER { get; set; }
    }
}

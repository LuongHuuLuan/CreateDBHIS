namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_VACCINATION")]
    public partial class V_HIS_VACCINATION
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
        public string VACCINATION_CODE { get; set; }

        public long VACCINATION_STT_ID { get; set; }

        public long VACCINATION_EXAM_ID { get; set; }

        public long PATIENT_ID { get; set; }

        public long PATIENT_TYPE_ID { get; set; }

        public long BRANCH_ID { get; set; }

        public long? NUM_ORDER { get; set; }

        public short? IS_YDT_UPLOAD { get; set; }

        public long REQUEST_TIME { get; set; }

        public long REQUEST_DATE { get; set; }

        public long REQUEST_ROOM_ID { get; set; }

        public long REQUEST_DEPARTMENT_ID { get; set; }

        [StringLength(50)]
        public string REQUEST_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REQUEST_USERNAME { get; set; }

        public long? EXECUTE_TIME { get; set; }

        public long? EXECUTE_DATE { get; set; }

        public long EXECUTE_ROOM_ID { get; set; }

        public long EXECUTE_DEPARTMENT_ID { get; set; }

        [StringLength(50)]
        public string EXECUTE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string EXECUTE_USERNAME { get; set; }

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

        public long? VACCINATION_REACT_ID { get; set; }

        public long? REACT_TIME { get; set; }

        [StringLength(50)]
        public string FOLLOW_LOGINNAME { get; set; }

        [StringLength(100)]
        public string FOLLOW_USERNAME { get; set; }

        [StringLength(3000)]
        public string PATHOLOGICAL_HISTORY { get; set; }

        public short? IS_REACT_RESPONSE { get; set; }

        [StringLength(100)]
        public string REACT_RESPONSER { get; set; }

        public long? VACC_HEALTH_STT_ID { get; set; }

        public long? DEATH_TIME { get; set; }

        [StringLength(100)]
        public string REACT_REPORTER { get; set; }

        public long? BILL_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string VACCINATION_STT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string VACCINATION_STT_NAME { get; set; }

        [Required]
        [StringLength(6)]
        public string PATIENT_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string PATIENT_TYPE_NAME { get; set; }

        [StringLength(20)]
        public string REQUEST_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string REQUEST_ROOM_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string REQUEST_DEPARTMENT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string REQUEST_DEPARTMENT_NAME { get; set; }

        [StringLength(20)]
        public string EXECUTE_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string EXECUTE_ROOM_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string EXECUTE_DEPARTMENT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string EXECUTE_DEPARTMENT_NAME { get; set; }

        [StringLength(2)]
        public string VACCINATION_REACT_CODE { get; set; }

        [StringLength(100)]
        public string VACCINATION_REACT_NAME { get; set; }

        [Required]
        [StringLength(12)]
        public string VACCINATION_EXAM_CODE { get; set; }

        [StringLength(12)]
        public string EXP_MEST_CODE { get; set; }
    }
}

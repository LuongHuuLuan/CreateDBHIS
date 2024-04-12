namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_VITAMIN_A")]
    public partial class HIS_VITAMIN_A
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
        public string VITAMIN_A_CODE { get; set; }

        public long PATIENT_ID { get; set; }

        public long BRANCH_ID { get; set; }

        public long? NUM_ORDER { get; set; }

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

        public long? EXP_MEST_ID { get; set; }

        public long? MEDICINE_TYPE_ID { get; set; }

        public decimal? AMOUNT { get; set; }

        public long CASE_TYPE { get; set; }

        public short? IS_SICK { get; set; }

        public short? IS_MALNUTRITION { get; set; }

        public short? IS_ONE_MONTH_BORN { get; set; }

        public short? IS_YDT_UPLOAD { get; set; }

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

        public virtual HIS_BRANCH HIS_BRANCH { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT1 { get; set; }

        public virtual HIS_EXP_MEST HIS_EXP_MEST { get; set; }

        public virtual HIS_MEDICINE_TYPE HIS_MEDICINE_TYPE { get; set; }

        public virtual HIS_PATIENT HIS_PATIENT { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        public virtual HIS_ROOM HIS_ROOM1 { get; set; }
    }
}

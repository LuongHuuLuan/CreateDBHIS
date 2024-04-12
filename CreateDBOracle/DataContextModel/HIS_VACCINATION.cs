namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_VACCINATION")]
    public partial class HIS_VACCINATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_VACCINATION()
        {
            HIS_EXP_MEST = new HashSet<HIS_EXP_MEST>();
            HIS_VACCINATION_VRPL = new HashSet<HIS_VACCINATION_VRPL>();
            HIS_VACCINATION_VRTY = new HashSet<HIS_VACCINATION_VRTY>();
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

        public virtual HIS_BRANCH HIS_BRANCH { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST> HIS_EXP_MEST { get; set; }

        public virtual HIS_PATIENT HIS_PATIENT { get; set; }

        public virtual HIS_PATIENT_TYPE HIS_PATIENT_TYPE { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        public virtual HIS_ROOM HIS_ROOM1 { get; set; }

        public virtual HIS_TRANSACTION HIS_TRANSACTION { get; set; }

        public virtual HIS_VACCINATION_STT HIS_VACCINATION_STT { get; set; }

        public virtual HIS_VACCINATION_REACT HIS_VACCINATION_REACT { get; set; }

        public virtual HIS_VACCINATION_EXAM HIS_VACCINATION_EXAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VACCINATION_VRPL> HIS_VACCINATION_VRPL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VACCINATION_VRTY> HIS_VACCINATION_VRTY { get; set; }
    }
}

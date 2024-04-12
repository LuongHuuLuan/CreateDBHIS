namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_VACCINATION_EXAM")]
    public partial class HIS_VACCINATION_EXAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_VACCINATION_EXAM()
        {
            HIS_DHST = new HashSet<HIS_DHST>();
            HIS_VACC_APPOINTMENT = new HashSet<HIS_VACC_APPOINTMENT>();
            HIS_VACCINATION = new HashSet<HIS_VACCINATION>();
            HIS_VAEX_VAER = new HashSet<HIS_VAEX_VAER>();
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
        public string VACCINATION_EXAM_CODE { get; set; }

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

        [StringLength(500)]
        public string NOTE { get; set; }

        public long? CONCLUDE { get; set; }

        public long PATIENT_TYPE_ID { get; set; }

        [StringLength(3000)]
        public string PT_PATHOLOGICAL_HISTORY { get; set; }

        [StringLength(3000)]
        public string PT_PATHOLOGICAL_HISTORY_FAMILY { get; set; }

        [StringLength(4000)]
        public string PT_ALLERGIC_HISTORY { get; set; }

        [StringLength(500)]
        public string ADVISE { get; set; }

        public long? APPOINTMENT_TIME { get; set; }

        public short? VACCINATION_EXAM_STT_ID { get; set; }

        public short? IS_TEST_HBSAG { get; set; }

        public short? IS_POSITIVE_RESULT { get; set; }

        public short? IS_SPECIALIST_EXAM { get; set; }

        public long? SPECIALIST_DEPARTMENT_ID { get; set; }

        [StringLength(500)]
        public string SPECIALIST_REASON { get; set; }

        [StringLength(500)]
        public string SPECIALIST_RESULT { get; set; }

        [StringLength(500)]
        public string SPECIALIST_CONCLUDE { get; set; }

        public long? RABIES_NUMBER_OF_DAYS { get; set; }

        public short? RABIES_ANIMAL_DOG { get; set; }

        public short? RABIES_ANIMAL_CAT { get; set; }

        public short? RABIES_ANIMAL_BAT { get; set; }

        public short? RABIES_ANIMAL_OTHER { get; set; }

        public short? RABIES_WOUND_LOCATION_HEAD { get; set; }

        public short? RABIES_WOUND_LOCATION_FACE { get; set; }

        public short? RABIES_WOUND_LOCATION_NECK { get; set; }

        public short? RABIES_WOUND_LOCATION_HAND { get; set; }

        public short? RABIES_WOUND_LOCATION_FOOT { get; set; }

        public short? RABIES_WOUND_RANK { get; set; }

        public short? RABIES_ANIMAL_STATUS { get; set; }

        public virtual HIS_BRANCH HIS_BRANCH { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT1 { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DHST> HIS_DHST { get; set; }

        public virtual HIS_PATIENT HIS_PATIENT { get; set; }

        public virtual HIS_PATIENT_TYPE HIS_PATIENT_TYPE { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        public virtual HIS_ROOM HIS_ROOM1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VACC_APPOINTMENT> HIS_VACC_APPOINTMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VACCINATION> HIS_VACCINATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VAEX_VAER> HIS_VAEX_VAER { get; set; }
    }
}

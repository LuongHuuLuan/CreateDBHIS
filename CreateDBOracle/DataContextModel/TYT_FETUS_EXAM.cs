namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.TYT_FETUS_EXAM")]
    public partial class TYT_FETUS_EXAM
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
        [StringLength(6)]
        public string BRANCH_CODE { get; set; }

        [Required]
        [StringLength(10)]
        public string PATIENT_CODE { get; set; }

        [StringLength(9)]
        public string PERSON_CODE { get; set; }

        [Required]
        [StringLength(30)]
        public string FIRST_NAME { get; set; }

        [StringLength(70)]
        public string LAST_NAME { get; set; }

        [StringLength(101)]
        public string VIR_PERSON_NAME { get; set; }

        public long DOB { get; set; }

        public short? IS_HAS_NOT_DAY_DOB { get; set; }

        [Required]
        [StringLength(100)]
        public string GENDER_NAME { get; set; }

        [StringLength(1000)]
        public string PERSON_ADDRESS { get; set; }

        [StringLength(100)]
        public string CAREER_NAME { get; set; }

        [StringLength(100)]
        public string ETHNIC_NAME { get; set; }

        [StringLength(15)]
        public string BHYT_NUMBER { get; set; }

        public long? LAST_MENSES_TIME { get; set; }

        public long? WEEK { get; set; }

        public long? BORN_TIME { get; set; }

        public long? FETUS_COUNT { get; set; }

        public decimal? WEIGHT { get; set; }

        public decimal? HEIGHT { get; set; }

        public long? BLOOD_PRESSURE_MAX { get; set; }

        public long? BLOOD_PRESSURE_MIN { get; set; }

        public decimal? UTERUS { get; set; }

        public long? BELLY { get; set; }

        public long? PELVIC { get; set; }

        public long? BLOOD { get; set; }

        public long? PROTEIN { get; set; }

        public short? IS_HIV_TEST { get; set; }

        [StringLength(100)]
        public string OTHER_TEST { get; set; }

        [StringLength(100)]
        public string BORN_GUESS { get; set; }

        public long? UV_COUNT { get; set; }

        public short? IS_FOLIC { get; set; }

        public long? FETUS_HEART { get; set; }

        [StringLength(100)]
        public string FETUS_POSITION { get; set; }

        [StringLength(50)]
        public string DOCTOR_LOGINNAME { get; set; }

        [StringLength(100)]
        public string DOCTOR_USERNAME { get; set; }

        [StringLength(100)]
        public string NOTE { get; set; }

        public long? EXAM_TIME { get; set; }

        [StringLength(100)]
        public string HEALTH_HISTORY { get; set; }
    }
}

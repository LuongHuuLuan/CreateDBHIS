namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.TYT_FETUS_BORN")]
    public partial class TYT_FETUS_BORN
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

        public short? IS_FETUS_MANAGE { get; set; }

        public short? IS_UV_FULL { get; set; }

        public long? CHECK_CASE { get; set; }

        public short? IS_HIV_BEFORE { get; set; }

        public short? IS_HIV_BORN { get; set; }

        public long? PARA_NORMAL_COUNT { get; set; }

        public long? PARA_PREMATURELY_COUNT { get; set; }

        public long? PARA_MISCARRIAGE_COUNT { get; set; }

        public long? PARA_CHILD_COUNT { get; set; }

        [StringLength(100)]
        public string BORN_METHOD { get; set; }

        [StringLength(100)]
        public string OBSTETRIC_COMPLICATION { get; set; }

        public short? IS_DEATH { get; set; }

        public long? CHILD_GENDER_ID { get; set; }

        public decimal? CHILD_WEIGHT { get; set; }

        [StringLength(100)]
        public string CHILD_STATUS { get; set; }

        public short? IS_CHILD_DEATH { get; set; }

        [StringLength(100)]
        public string BORN_PLACE { get; set; }

        [StringLength(100)]
        public string MIDWIFE_NAME { get; set; }

        public short? IS_BREASTFEEDING_FIRST_HOUR { get; set; }

        public short? IS_K1 { get; set; }

        [StringLength(100)]
        public string FIRST_WEEK_EXAM { get; set; }

        [StringLength(100)]
        public string EXAM_742 { get; set; }

        [StringLength(100)]
        public string NOTE { get; set; }
    }
}

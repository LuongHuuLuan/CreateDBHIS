namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.TYT_KHH")]
    public partial class TYT_KHH
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

        public short? IS_SINGLE { get; set; }

        public short? IS_IUCD { get; set; }

        public short? IS_STERILIZE { get; set; }

        public short? IS_PILL_V { get; set; }

        public short? IS_PILL_T { get; set; }

        public short? IS_PILL_C { get; set; }

        public short? IS_CONDOM { get; set; }

        [StringLength(100)]
        public string EXECUTE_NAME { get; set; }

        [StringLength(100)]
        public string OBSTETRIC_COMPLICATION { get; set; }

        public short? IS_DEATH { get; set; }

        [StringLength(100)]
        public string NOTE { get; set; }
    }
}

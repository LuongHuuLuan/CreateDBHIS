namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.TYT_MALARIA")]
    public partial class TYT_MALARIA
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

        public short? IS_HAS_FETUS { get; set; }

        public short? IS_FEVER { get; set; }

        public long? TEST_TYPE { get; set; }

        [StringLength(4000)]
        public string TEST_RESULT { get; set; }

        [StringLength(1000)]
        public string DIAGNOSE { get; set; }

        [StringLength(100)]
        public string TREATMENT_RESULT { get; set; }

        [StringLength(4000)]
        public string MEDICINE { get; set; }

        [StringLength(4000)]
        public string MEDICINE_CTDT { get; set; }

        public long? DIAGNOSE_TIME { get; set; }

        [StringLength(100)]
        public string DIAGNOSE_PLACE { get; set; }
    }
}

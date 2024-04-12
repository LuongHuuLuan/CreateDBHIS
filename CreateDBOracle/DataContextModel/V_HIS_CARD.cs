namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_CARD")]
    public partial class V_HIS_CARD
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
        [StringLength(40)]
        public string SERVICE_CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string CARD_CODE { get; set; }

        [StringLength(20)]
        public string CARD_NUMBER { get; set; }

        [StringLength(50)]
        public string CARD_MAC { get; set; }

        public long? PATIENT_ID { get; set; }

        [StringLength(20)]
        public string BANK_CARD_CODE { get; set; }

        [StringLength(10)]
        public string PATIENT_CODE { get; set; }

        [StringLength(30)]
        public string FIRST_NAME { get; set; }

        [StringLength(70)]
        public string LAST_NAME { get; set; }

        public long? GENDER_ID { get; set; }

        public long? DOB { get; set; }

        public long? CAREER_ID { get; set; }

        [StringLength(100)]
        public string NATIONAL_NAME { get; set; }

        [StringLength(100)]
        public string ETHNIC_NAME { get; set; }

        [StringLength(100)]
        public string RELIGION_NAME { get; set; }

        [StringLength(100)]
        public string PROVINCE_NAME { get; set; }

        [StringLength(100)]
        public string DISTRICT_NAME { get; set; }

        [StringLength(100)]
        public string COMMUNE_NAME { get; set; }

        [StringLength(200)]
        public string ADDRESS { get; set; }

        [StringLength(12)]
        public string PHONE { get; set; }

        [StringLength(500)]
        public string WORK_PLACE { get; set; }

        [StringLength(50)]
        public string RELATIVE_TYPE { get; set; }

        [StringLength(100)]
        public string RELATIVE_NAME { get; set; }

        [StringLength(200)]
        public string RELATIVE_ADDRESS { get; set; }

        [StringLength(101)]
        public string VIR_PATIENT_NAME { get; set; }

        [StringLength(506)]
        public string VIR_ADDRESS { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        public short? IS_HAS_NOT_DAY_DOB { get; set; }

        [StringLength(3)]
        public string PROVINCE_CODE { get; set; }

        [StringLength(4)]
        public string DISTRICT_CODE { get; set; }

        [StringLength(6)]
        public string COMMUNE_CODE { get; set; }

        [StringLength(100)]
        public string HT_PROVINCE_NAME { get; set; }

        [StringLength(100)]
        public string HT_DISTRICT_NAME { get; set; }

        [StringLength(100)]
        public string HT_COMMUNE_NAME { get; set; }

        [StringLength(200)]
        public string HT_ADDRESS { get; set; }

        [StringLength(2)]
        public string GENDER_CODE { get; set; }

        [StringLength(100)]
        public string GENDER_NAME { get; set; }
    }
}

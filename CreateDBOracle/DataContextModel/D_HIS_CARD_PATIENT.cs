namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.D_HIS_CARD_PATIENT")]
    public partial class D_HIS_CARD_PATIENT
    {
        [Key]
        [Column(Order = 0)]
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

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string SERVICE_CODE { get; set; }

        [Key]
        [Column(Order = 2)]
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

        public short? HAS_CARD { get; set; }

        public long? PATIENT_TYPE_ALTER_ID { get; set; }

        public long? LOG_TIME { get; set; }

        [StringLength(2)]
        public string RIGHT_ROUTE_CODE { get; set; }

        [StringLength(2)]
        public string RIGHT_ROUTE_TYPE_CODE { get; set; }

        [StringLength(6)]
        public string HEIN_MEDI_ORG_CODE { get; set; }

        [StringLength(500)]
        public string HEIN_MEDI_ORG_NAME { get; set; }

        [StringLength(2)]
        public string HAS_BIRTH_CERTIFICATE { get; set; }

        [StringLength(15)]
        public string HEIN_CARD_NUMBER { get; set; }

        public long? HEIN_CARD_FROM_TIME { get; set; }

        public long? HEIN_CARD_TO_TIME { get; set; }

        [StringLength(1000)]
        public string BHYT_ADDRESS { get; set; }

        [StringLength(20)]
        public string HNCODE { get; set; }

        [StringLength(2)]
        public string JOIN_5_YEAR { get; set; }

        [StringLength(2)]
        public string PAID_6_MONTH { get; set; }

        public short? IS_NO_CHECK_EXPIRE { get; set; }

        public long? FREE_CO_PAID_TIME { get; set; }

        [StringLength(2)]
        public string LEVEL_CODE { get; set; }
    }
}

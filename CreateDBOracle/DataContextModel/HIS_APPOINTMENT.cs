namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_APPOINTMENT")]
    public partial class HIS_APPOINTMENT
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

        public long APPOINTMENT_DATE { get; set; }

        [Required]
        [StringLength(12)]
        public string APPOINTMENT_CODE { get; set; }

        public long? APPOINTMENT_PERIOD_ID { get; set; }

        public long? NUM_ORDER_ISSUE_ID { get; set; }

        public long NUM_ORDER { get; set; }

        public long? PATIENT_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string FIRST_NAME { get; set; }

        [StringLength(70)]
        public string LAST_NAME { get; set; }

        [StringLength(101)]
        public string VIR_PATIENT_NAME { get; set; }

        public long GENDER_ID { get; set; }

        public long DOB { get; set; }

        public short? IS_HAS_NOT_DAY_DOB { get; set; }

        [StringLength(2)]
        public string ETHNIC_CODE { get; set; }

        [StringLength(100)]
        public string ETHNIC_NAME { get; set; }

        [StringLength(100)]
        public string RELIGION_NAME { get; set; }

        [StringLength(3)]
        public string PROVINCE_CODE { get; set; }

        [StringLength(100)]
        public string PROVINCE_NAME { get; set; }

        [StringLength(4)]
        public string DISTRICT_CODE { get; set; }

        [StringLength(100)]
        public string DISTRICT_NAME { get; set; }

        [StringLength(6)]
        public string COMMUNE_CODE { get; set; }

        [StringLength(100)]
        public string COMMUNE_NAME { get; set; }

        [StringLength(200)]
        public string ADDRESS { get; set; }

        [StringLength(506)]
        public string VIR_ADDRESS { get; set; }

        [StringLength(12)]
        public string MOBILE { get; set; }

        [StringLength(12)]
        public string PHONE { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(2)]
        public string CAREER_CODE { get; set; }

        [StringLength(100)]
        public string CAREER_NAME { get; set; }

        public long? CAREER_ID { get; set; }

        public virtual HIS_NUM_ORDER_ISSUE HIS_NUM_ORDER_ISSUE { get; set; }

        public virtual HIS_PATIENT HIS_PATIENT { get; set; }

        public virtual HIS_APPOINTMENT_PERIOD HIS_APPOINTMENT_PERIOD { get; set; }

        public virtual HIS_GENDER HIS_GENDER { get; set; }

        public virtual HIS_CAREER HIS_CAREER { get; set; }
    }
}

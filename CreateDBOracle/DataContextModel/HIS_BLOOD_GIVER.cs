namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_BLOOD_GIVER")]
    public partial class HIS_BLOOD_GIVER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_BLOOD_GIVER()
        {
            HIS_BLOOD = new HashSet<HIS_BLOOD>();
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

        public long IMP_MEST_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string GIVE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string GIVE_NAME { get; set; }

        public long DOB { get; set; }

        public long? GENDER_ID { get; set; }

        public short GIVE_TYPE { get; set; }

        public long? CAREER_ID { get; set; }

        [StringLength(100)]
        public string CAREER_NAME { get; set; }

        [StringLength(500)]
        public string WORK_PLACE { get; set; }

        public long? WORK_PLACE_ID { get; set; }

        [StringLength(100)]
        public string MOTHER_NAME { get; set; }

        [StringLength(3)]
        public string NATIONAL_CODE { get; set; }

        [StringLength(100)]
        public string NATIONAL_NAME { get; set; }

        [StringLength(3)]
        public string PROVINCE_CODE_BLOOD { get; set; }

        [StringLength(100)]
        public string PROVINCE_NAME_BLOOD { get; set; }

        [StringLength(4)]
        public string DISTRICT_CODE_BLOOD { get; set; }

        [StringLength(100)]
        public string DISTRICT_NAME_BLOOD { get; set; }

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

        public long? CMND_DATE { get; set; }

        [StringLength(9)]
        public string CMND_NUMBER { get; set; }

        [StringLength(100)]
        public string CMND_PLACE { get; set; }

        public long? CCCD_DATE { get; set; }

        [StringLength(12)]
        public string CCCD_NUMBER { get; set; }

        [StringLength(100)]
        public string CCCD_PLACE { get; set; }

        public long? PASSPORT_DATE { get; set; }

        [StringLength(9)]
        public string PASSPORT_NUMBER { get; set; }

        [StringLength(100)]
        public string PASSPORT_PLACE { get; set; }

        [StringLength(20)]
        public string GIVE_CARD { get; set; }

        [StringLength(506)]
        public string VIR_ADDRESS { get; set; }

        [StringLength(12)]
        public string PHONE { get; set; }

        public long? EXAM_TIME { get; set; }

        public long? TURN { get; set; }

        public decimal? WEIGHT { get; set; }

        public long? PULSE { get; set; }

        public long? BLOOD_PRESSURE_MAX { get; set; }

        public long? BLOOD_PRESSURE_MIN { get; set; }

        [StringLength(200)]
        public string NOTE_SUBCLINICAL { get; set; }

        [StringLength(200)]
        public string TEST_BEFORE_HB { get; set; }

        public short? TEST_BEFORE_HBV { get; set; }

        [StringLength(50)]
        public string EXAM_LOGINNAME { get; set; }

        [StringLength(100)]
        public string EXAM_USERNAME { get; set; }

        public long? BLOOD_VOLUME_ID { get; set; }

        public long? EXECUTE_TIME { get; set; }

        public decimal? AMOUNT { get; set; }

        [StringLength(50)]
        public string EXECUTE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string EXECUTE_USERNAME { get; set; }

        [StringLength(500)]
        public string EXECUTE { get; set; }

        public long? BLOOD_ABO_ID { get; set; }

        public long? BLOOD_RH_ID { get; set; }

        public short? TEST_AFTER_HBV { get; set; }

        public short? TEST_AFTER_HCV { get; set; }

        public short? TEST_AFTER_HIV { get; set; }

        public short? TEST_AFTER_GM { get; set; }

        public short? TEST_AFTER_KTBT { get; set; }

        public short? TEST_AFTER_NAT_HBV { get; set; }

        public short? TEST_AFTER_NAT_HCV { get; set; }

        public short? TEST_AFTER_NAT_HIV { get; set; }

        public short? TEST_AFTER_SLKTB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BLOOD> HIS_BLOOD { get; set; }

        public virtual HIS_BLOOD_ABO HIS_BLOOD_ABO { get; set; }

        public virtual HIS_IMP_MEST HIS_IMP_MEST { get; set; }

        public virtual HIS_GENDER HIS_GENDER { get; set; }

        public virtual HIS_CAREER HIS_CAREER { get; set; }

        public virtual HIS_WORK_PLACE HIS_WORK_PLACE { get; set; }

        public virtual HIS_BLOOD_RH HIS_BLOOD_RH { get; set; }

        public virtual HIS_BLOOD_VOLUME HIS_BLOOD_VOLUME { get; set; }
    }
}

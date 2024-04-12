namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_CONTACT_POINT")]
    public partial class HIS_CONTACT_POINT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_CONTACT_POINT()
        {
            HIS_CONTACT = new HashSet<HIS_CONTACT>();
            HIS_CONTACT1 = new HashSet<HIS_CONTACT>();
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

        public long? CONTACT_LEVEL { get; set; }

        public long? PATIENT_ID { get; set; }

        public long? EMPLOYEE_ID { get; set; }

        public long CONTACT_TYPE { get; set; }

        [StringLength(30)]
        public string FIRST_NAME { get; set; }

        [StringLength(70)]
        public string LAST_NAME { get; set; }

        [StringLength(101)]
        public string VIR_FULL_NAME { get; set; }

        public long? GENDER_ID { get; set; }

        public long? DOB { get; set; }

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

        [StringLength(2)]
        public string CAREER_CODE { get; set; }

        [StringLength(100)]
        public string CAREER_NAME { get; set; }

        [StringLength(500)]
        public string WORK_PLACE { get; set; }

        [StringLength(9)]
        public string CMND_NUMBER { get; set; }

        public long? CMND_DATE { get; set; }

        [StringLength(100)]
        public string CMND_PLACE { get; set; }

        [StringLength(12)]
        public string CCCD_NUMBER { get; set; }

        public long? CCCD_DATE { get; set; }

        [StringLength(100)]
        public string CCCD_PLACE { get; set; }

        [StringLength(4000)]
        public string NOTE { get; set; }

        public short? TEST_RESULT_1 { get; set; }

        public short? TEST_RESULT_2 { get; set; }

        public short? TEST_RESULT_3 { get; set; }

        [StringLength(500)]
        public string CONTACT_POINT_OTHER_TYPE_NAME { get; set; }

        [StringLength(12)]
        public string PHONE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_CONTACT> HIS_CONTACT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_CONTACT> HIS_CONTACT1 { get; set; }

        public virtual HIS_PATIENT HIS_PATIENT { get; set; }

        public virtual HIS_EMPLOYEE HIS_EMPLOYEE { get; set; }

        public virtual HIS_GENDER HIS_GENDER { get; set; }
    }
}

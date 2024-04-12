namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_EMPLOYEE")]
    public partial class HIS_EMPLOYEE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_EMPLOYEE()
        {
            HIS_CONTACT_POINT = new HashSet<HIS_CONTACT_POINT>();
            HIS_KSK_ACCESS = new HashSet<HIS_KSK_ACCESS>();
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
        [StringLength(50)]
        public string LOGINNAME { get; set; }

        [StringLength(50)]
        public string DIPLOMA { get; set; }

        public short? IS_DOCTOR { get; set; }

        public short? IS_ADMIN { get; set; }

        public long? MEDICINE_TYPE_RANK { get; set; }

        public long? MAX_BHYT_SERVICE_REQ_PER_DAY { get; set; }

        [StringLength(50)]
        public string ACCOUNT_NUMBER { get; set; }

        [StringLength(200)]
        public string BANK { get; set; }

        public long? DEPARTMENT_ID { get; set; }

        [StringLength(100)]
        public string DEFAULT_MEDI_STOCK_IDS { get; set; }

        public short? ALLOW_UPDATE_OTHER_SCLINICAL { get; set; }

        public short? IS_NURSE { get; set; }

        [StringLength(100)]
        public string ERX_LOGINNAME { get; set; }

        [StringLength(400)]
        public string ERX_PASSWORD { get; set; }

        public long? DOB { get; set; }

        [StringLength(100)]
        public string TITLE { get; set; }

        public long? MAX_SERVICE_REQ_PER_DAY { get; set; }

        public short? IS_SERVICE_REQ_EXAM { get; set; }

        [StringLength(100)]
        public string TDL_USERNAME { get; set; }

        [StringLength(100)]
        public string TDL_EMAIL { get; set; }

        [StringLength(20)]
        public string TDL_MOBILE { get; set; }

        [StringLength(20)]
        public string SOCIAL_INSURANCE_NUMBER { get; set; }

        public short? IS_LIMIT_SCHEDULE { get; set; }

        public short? DO_NOT_ALLOW_SIMULTANEITY { get; set; }

        public short? GENDER_ID { get; set; }

        [StringLength(2)]
        public string ETHNIC_CODE { get; set; }

        public long? DIPLOMA_DATE { get; set; }

        [StringLength(50)]
        public string DIPLOMA_PLACE { get; set; }

        [StringLength(15)]
        public string IDENTIFICATION_NUMBER { get; set; }

        public short? CAREER_TITLE { get; set; }

        public short? POSITION { get; set; }

        [StringLength(15)]
        public string SPECIALITY_CODES { get; set; }

        public short? TYPE_OF_TIME { get; set; }

        public long? BRANCH_ID { get; set; }

        [StringLength(30)]
        public string MEDI_ORG_CODES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_CONTACT_POINT> HIS_CONTACT_POINT { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_KSK_ACCESS> HIS_KSK_ACCESS { get; set; }
    }
}

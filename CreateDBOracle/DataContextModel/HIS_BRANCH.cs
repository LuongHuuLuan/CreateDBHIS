namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_BRANCH")]
    public partial class HIS_BRANCH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_BRANCH()
        {
            HIS_APPOINTMENT_PERIOD = new HashSet<HIS_APPOINTMENT_PERIOD>();
            HIS_BRANCH_TIME = new HashSet<HIS_BRANCH_TIME>();
            HIS_DEATH_CERT_BOOK = new HashSet<HIS_DEATH_CERT_BOOK>();
            HIS_DEPARTMENT = new HashSet<HIS_DEPARTMENT>();
            HIS_FINANCE_PERIOD = new HashSet<HIS_FINANCE_PERIOD>();
            HIS_SERVICE_HEIN = new HashSet<HIS_SERVICE_HEIN>();
            HIS_SERVICE_PATY = new HashSet<HIS_SERVICE_PATY>();
            HIS_VACCINATION_EXAM = new HashSet<HIS_VACCINATION_EXAM>();
            HIS_VACCINATION = new HashSet<HIS_VACCINATION>();
            HIS_VITAMIN_A = new HashSet<HIS_VITAMIN_A>();
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
        [StringLength(20)]
        public string BRANCH_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string BRANCH_NAME { get; set; }

        [StringLength(6)]
        public string HEIN_MEDI_ORG_CODE { get; set; }

        [StringLength(4000)]
        public string ACCEPT_HEIN_MEDI_ORG_CODE { get; set; }

        [StringLength(500)]
        public string ADDRESS { get; set; }

        [StringLength(100)]
        public string PARENT_ORGANIZATION_NAME { get; set; }

        [StringLength(2)]
        public string HEIN_PROVINCE_CODE { get; set; }

        [StringLength(1)]
        public string HEIN_LEVEL_CODE { get; set; }

        [StringLength(20)]
        public string TAX_CODE { get; set; }

        [StringLength(50)]
        public string ACCOUNT_NUMBER { get; set; }

        [StringLength(20)]
        public string PHONE { get; set; }

        public short? IS_USE_BRANCH_TIME { get; set; }

        [StringLength(500)]
        public string LOGO_URL { get; set; }

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
        public string REPRESENTATIVE { get; set; }

        [StringLength(100)]
        public string POSITION { get; set; }

        [StringLength(50)]
        public string AUTH_LETTER_NUM { get; set; }

        public long? AUTH_LETTER_ISSUE_DATE { get; set; }

        [StringLength(300)]
        public string BANK_INFO { get; set; }

        [StringLength(20)]
        public string THE_BRANCH_CODE { get; set; }

        [StringLength(2000)]
        public string SYS_MEDI_ORG_CODE { get; set; }

        [StringLength(50)]
        public string DIRECTOR_LOGINNAME { get; set; }

        [StringLength(100)]
        public string DIRECTOR_USERNAME { get; set; }

        [StringLength(20)]
        public string REPRESENTATIVE_HEIN_CODE { get; set; }

        [StringLength(100)]
        public string DO_NOT_ALLOW_HEIN_LEVEL_CODE { get; set; }

        public short? VENTURE { get; set; }

        public short? TYPE { get; set; }

        public short? FORM { get; set; }

        public long? BED_APPROVED { get; set; }

        public long? BED_ACTUAL { get; set; }

        public long? BED_RESUSCITATION { get; set; }

        public long? BED_RESUSCITATION_EMG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_APPOINTMENT_PERIOD> HIS_APPOINTMENT_PERIOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BRANCH_TIME> HIS_BRANCH_TIME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEATH_CERT_BOOK> HIS_DEATH_CERT_BOOK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEPARTMENT> HIS_DEPARTMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_FINANCE_PERIOD> HIS_FINANCE_PERIOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_HEIN> HIS_SERVICE_HEIN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_PATY> HIS_SERVICE_PATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VACCINATION_EXAM> HIS_VACCINATION_EXAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VACCINATION> HIS_VACCINATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VITAMIN_A> HIS_VITAMIN_A { get; set; }
    }
}

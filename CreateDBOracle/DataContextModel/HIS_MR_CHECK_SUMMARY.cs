namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_MR_CHECK_SUMMARY")]
    public partial class HIS_MR_CHECK_SUMMARY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_MR_CHECK_SUMMARY()
        {
            HIS_MR_CHECKLIST = new HashSet<HIS_MR_CHECKLIST>();
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

        public long? ERROR_NUMBER { get; set; }

        public long? DEPARTMENT_RETURN_DATE { get; set; }

        [StringLength(100)]
        public string DEPARTMENT_USER_NAME { get; set; }

        [StringLength(50)]
        public string DEPARTMENT_LOGIN_NAME { get; set; }

        public long? KHTH_RETURN_DATE { get; set; }

        [StringLength(100)]
        public string KHTH_USER_NAME { get; set; }

        [StringLength(50)]
        public string KHTH_LOGIN_NAME { get; set; }

        public long DEPARTMENT_ID { get; set; }

        public long TREATMENT_ID { get; set; }

        public long? MEDI_RECORD_SUBMIT_DATE { get; set; }

        public long? LATE_DATE_NUMBER { get; set; }

        public short? IS_APPROVED { get; set; }

        public short? CHECK_PLACE { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MR_CHECKLIST> HIS_MR_CHECKLIST { get; set; }
    }
}

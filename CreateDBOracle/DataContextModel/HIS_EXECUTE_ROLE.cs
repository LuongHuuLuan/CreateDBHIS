namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_EXECUTE_ROLE")]
    public partial class HIS_EXECUTE_ROLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_EXECUTE_ROLE()
        {
            HIS_DEBATE_EKIP_USER = new HashSet<HIS_DEBATE_EKIP_USER>();
            HIS_DEBATE_INVITE_USER = new HashSet<HIS_DEBATE_INVITE_USER>();
            HIS_DEBATE_USER = new HashSet<HIS_DEBATE_USER>();
            HIS_EKIP_PLAN_USER = new HashSet<HIS_EKIP_PLAN_USER>();
            HIS_EKIP_TEMP_USER = new HashSet<HIS_EKIP_TEMP_USER>();
            HIS_EXECUTE_ROLE_USER = new HashSet<HIS_EXECUTE_ROLE_USER>();
            HIS_EXP_MEST_USER = new HashSet<HIS_EXP_MEST_USER>();
            HIS_IMP_MEST_USER = new HashSet<HIS_IMP_MEST_USER>();
            HIS_IMP_USER_TEMP_DT = new HashSet<HIS_IMP_USER_TEMP_DT>();
            HIS_MEST_INVE_USER = new HashSet<HIS_MEST_INVE_USER>();
            HIS_REMUNERATION = new HashSet<HIS_REMUNERATION>();
            HIS_SURG_REMU_DETAIL = new HashSet<HIS_SURG_REMU_DETAIL>();
            HIS_USER_GROUP_TEMP_DT = new HashSet<HIS_USER_GROUP_TEMP_DT>();
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
        [StringLength(10)]
        public string EXECUTE_ROLE_CODE { get; set; }

        [Required]
        [StringLength(200)]
        public string EXECUTE_ROLE_NAME { get; set; }

        public short? IS_SURG_MAIN { get; set; }

        public short? IS_SURGRY { get; set; }

        public short? IS_STOCK { get; set; }

        public short? IS_POSITION { get; set; }

        public short? IS_TITLE { get; set; }

        public short? ALLOW_SIMULTANEITY { get; set; }

        public short? IS_SINGLE_IN_EKIP { get; set; }

        public short? IS_DISABLE_IN_EKIP { get; set; }

        public short? IS_SUBCLINICAL { get; set; }

        public short? IS_SUBCLINICAL_RESULT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEBATE_EKIP_USER> HIS_DEBATE_EKIP_USER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEBATE_INVITE_USER> HIS_DEBATE_INVITE_USER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEBATE_USER> HIS_DEBATE_USER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EKIP_PLAN_USER> HIS_EKIP_PLAN_USER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EKIP_TEMP_USER> HIS_EKIP_TEMP_USER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXECUTE_ROLE_USER> HIS_EXECUTE_ROLE_USER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_USER> HIS_EXP_MEST_USER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST_USER> HIS_IMP_MEST_USER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_USER_TEMP_DT> HIS_IMP_USER_TEMP_DT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_INVE_USER> HIS_MEST_INVE_USER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_REMUNERATION> HIS_REMUNERATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SURG_REMU_DETAIL> HIS_SURG_REMU_DETAIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_USER_GROUP_TEMP_DT> HIS_USER_GROUP_TEMP_DT { get; set; }
    }
}

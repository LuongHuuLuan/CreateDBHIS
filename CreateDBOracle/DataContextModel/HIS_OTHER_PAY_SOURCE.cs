namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_OTHER_PAY_SOURCE")]
    public partial class HIS_OTHER_PAY_SOURCE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_OTHER_PAY_SOURCE()
        {
            HIS_EXME_REASON_CFG = new HashSet<HIS_EXME_REASON_CFG>();
            HIS_EXP_MEST_MATERIAL = new HashSet<HIS_EXP_MEST_MATERIAL>();
            HIS_EXP_MEST_MEDICINE = new HashSet<HIS_EXP_MEST_MEDICINE>();
            HIS_PATIENT_CLASSIFY = new HashSet<HIS_PATIENT_CLASSIFY>();
            HIS_PATIENT_TYPE = new HashSet<HIS_PATIENT_TYPE>();
            HIS_SERE_SERV = new HashSet<HIS_SERE_SERV>();
            HIS_SERE_SERV_RATION = new HashSet<HIS_SERE_SERV_RATION>();
            HIS_SERVICE = new HashSet<HIS_SERVICE>();
            HIS_TREATMENT = new HashSet<HIS_TREATMENT>();
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
        public string OTHER_PAY_SOURCE_CODE { get; set; }

        [Required]
        [StringLength(200)]
        public string OTHER_PAY_SOURCE_NAME { get; set; }

        public long? IS_PAID_ALL { get; set; }

        public long? IS_NOT_FOR_TREATMENT { get; set; }

        public long? IS_NOT_PAID_DIFF { get; set; }

        public long? HEIN_PAY_SOURCE_TYPE_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXME_REASON_CFG> HIS_EXME_REASON_CFG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_MATERIAL> HIS_EXP_MEST_MATERIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_MEDICINE> HIS_EXP_MEST_MEDICINE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PATIENT_CLASSIFY> HIS_PATIENT_CLASSIFY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PATIENT_TYPE> HIS_PATIENT_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV> HIS_SERE_SERV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_RATION> HIS_SERE_SERV_RATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE> HIS_SERVICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TREATMENT> HIS_TREATMENT { get; set; }
    }
}

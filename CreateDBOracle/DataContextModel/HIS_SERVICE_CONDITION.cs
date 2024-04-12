namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SERVICE_CONDITION")]
    public partial class HIS_SERVICE_CONDITION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_SERVICE_CONDITION()
        {
            HIS_EXP_MEST_MATERIAL = new HashSet<HIS_EXP_MEST_MATERIAL>();
            HIS_EXP_MEST_MEDICINE = new HashSet<HIS_EXP_MEST_MEDICINE>();
            HIS_SERE_SERV = new HashSet<HIS_SERE_SERV>();
            HIS_SERVICE_PATY = new HashSet<HIS_SERVICE_PATY>();
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
        public string SERVICE_CONDITION_CODE { get; set; }

        [Required]
        [StringLength(1000)]
        public string SERVICE_CONDITION_NAME { get; set; }

        public long SERVICE_ID { get; set; }

        public decimal? HEIN_RATIO { get; set; }

        public long? PRIORITY { get; set; }

        public long? AGE_FROM { get; set; }

        public long? AGE_TO { get; set; }

        [StringLength(2000)]
        public string ICD_CODES { get; set; }

        public long? FROM_TIME { get; set; }

        public long? TO_TIME { get; set; }

        public long? TREATMENT_FROM_TIME { get; set; }

        public long? TREATMENT_TO_TIME { get; set; }

        public decimal? HEIN_PRICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_MATERIAL> HIS_EXP_MEST_MATERIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_MEDICINE> HIS_EXP_MEST_MEDICINE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV> HIS_SERE_SERV { get; set; }

        public virtual HIS_SERVICE HIS_SERVICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_PATY> HIS_SERVICE_PATY { get; set; }
    }
}

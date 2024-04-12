namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_PROGRAM")]
    public partial class HIS_PROGRAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_PROGRAM()
        {
            HIS_MEDI_RECORD = new HashSet<HIS_MEDI_RECORD>();
            HIS_PATIENT_PROGRAM = new HashSet<HIS_PATIENT_PROGRAM>();
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
        [StringLength(6)]
        public string PROGRAM_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string PROGRAM_NAME { get; set; }

        public long? DATA_STORE_ID { get; set; }

        public long? TREATMENT_TYPE_ID { get; set; }

        public short? AUTO_CHANGE_TO_OUT_PATIENT { get; set; }

        public virtual HIS_DATA_STORE HIS_DATA_STORE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_RECORD> HIS_MEDI_RECORD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PATIENT_PROGRAM> HIS_PATIENT_PROGRAM { get; set; }

        public virtual HIS_TREATMENT_TYPE HIS_TREATMENT_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TREATMENT> HIS_TREATMENT { get; set; }
    }
}

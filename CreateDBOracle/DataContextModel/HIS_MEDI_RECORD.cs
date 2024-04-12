namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_MEDI_RECORD")]
    public partial class HIS_MEDI_RECORD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_MEDI_RECORD()
        {
            HIS_MEDI_RECORD_BORROW = new HashSet<HIS_MEDI_RECORD_BORROW>();
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

        [StringLength(20)]
        public string STORE_CODE { get; set; }

        public long? STORE_TIME { get; set; }

        public long? DATA_STORE_ID { get; set; }

        public long PATIENT_ID { get; set; }

        public long? MEDI_RECORD_TYPE_ID { get; set; }

        public decimal? VIR_STORE_YEAR { get; set; }

        public long? PROGRAM_ID { get; set; }

        public short? IS_NOT_STORED { get; set; }

        [StringLength(10)]
        public string ICD_CODE { get; set; }

        [StringLength(500)]
        public string ICD_NAME { get; set; }

        [StringLength(500)]
        public string ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string ICD_TEXT { get; set; }

        public long? END_ROOM_ID { get; set; }

        public long? END_DEPARTMENT_ID { get; set; }

        public long? SEED_CODE_TIME { get; set; }

        public decimal? VIR_SEED_CODE_YEAR { get; set; }

        public long? EMR_COVER_TYPE_ID { get; set; }

        public long? STORE_DATE { get; set; }

        public long? LOCATION_STORE_ID { get; set; }

        public virtual HIS_DATA_STORE HIS_DATA_STORE { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        public virtual HIS_EMR_COVER_TYPE HIS_EMR_COVER_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_RECORD_BORROW> HIS_MEDI_RECORD_BORROW { get; set; }

        public virtual HIS_MEDI_RECORD_TYPE HIS_MEDI_RECORD_TYPE { get; set; }

        public virtual HIS_PATIENT HIS_PATIENT { get; set; }

        public virtual HIS_PROGRAM HIS_PROGRAM { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TREATMENT> HIS_TREATMENT { get; set; }
    }
}

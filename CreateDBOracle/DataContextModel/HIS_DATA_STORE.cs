namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_DATA_STORE")]
    public partial class HIS_DATA_STORE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_DATA_STORE()
        {
            HIS_DATA_STORE1 = new HashSet<HIS_DATA_STORE>();
            HIS_MEDI_RECORD = new HashSet<HIS_MEDI_RECORD>();
            HIS_PROGRAM = new HashSet<HIS_PROGRAM>();
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
        [StringLength(10)]
        public string DATA_STORE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string DATA_STORE_NAME { get; set; }

        public long ROOM_ID { get; set; }

        public long? PARENT_ID { get; set; }

        public long? STORED_DEPARTMENT_ID { get; set; }

        public long? STORED_ROOM_ID { get; set; }

        [StringLength(50)]
        public string TREATMENT_END_TYPE_IDS { get; set; }

        [StringLength(50)]
        public string TREATMENT_TYPE_IDS { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DATA_STORE> HIS_DATA_STORE1 { get; set; }

        public virtual HIS_DATA_STORE HIS_DATA_STORE2 { get; set; }

        public virtual HIS_ROOM HIS_ROOM1 { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_RECORD> HIS_MEDI_RECORD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PROGRAM> HIS_PROGRAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TREATMENT> HIS_TREATMENT { get; set; }
    }
}

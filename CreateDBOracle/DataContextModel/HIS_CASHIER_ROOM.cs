namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_CASHIER_ROOM")]
    public partial class HIS_CASHIER_ROOM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_CASHIER_ROOM()
        {
            HIS_CARO_ACCOUNT_BOOK = new HashSet<HIS_CARO_ACCOUNT_BOOK>();
            HIS_CARO_DEPARTMENT = new HashSet<HIS_CARO_DEPARTMENT>();
            HIS_CASHIER_ADD_CONFIG = new HashSet<HIS_CASHIER_ADD_CONFIG>();
            HIS_EXP_MEST = new HashSet<HIS_EXP_MEST>();
            HIS_HEIN_APPROVAL = new HashSet<HIS_HEIN_APPROVAL>();
            HIS_ROOM1 = new HashSet<HIS_ROOM>();
            HIS_TRANSACTION = new HashSet<HIS_TRANSACTION>();
            HIS_TRANSACTION1 = new HashSet<HIS_TRANSACTION>();
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
        public string CASHIER_ROOM_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string CASHIER_ROOM_NAME { get; set; }

        public long ROOM_ID { get; set; }

        [StringLength(10)]
        public string EINVOICE_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string EINVOICE_ROOM_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_CARO_ACCOUNT_BOOK> HIS_CARO_ACCOUNT_BOOK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_CARO_DEPARTMENT> HIS_CARO_DEPARTMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_CASHIER_ADD_CONFIG> HIS_CASHIER_ADD_CONFIG { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST> HIS_EXP_MEST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_HEIN_APPROVAL> HIS_HEIN_APPROVAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ROOM> HIS_ROOM1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TRANSACTION> HIS_TRANSACTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TRANSACTION> HIS_TRANSACTION1 { get; set; }
    }
}

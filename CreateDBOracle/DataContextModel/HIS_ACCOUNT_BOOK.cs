namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_ACCOUNT_BOOK")]
    public partial class HIS_ACCOUNT_BOOK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_ACCOUNT_BOOK()
        {
            HIS_ACCOUNT_BOOK1 = new HashSet<HIS_ACCOUNT_BOOK>();
            HIS_CARO_ACCOUNT_BOOK = new HashSet<HIS_CARO_ACCOUNT_BOOK>();
            HIS_ROOM = new HashSet<HIS_ROOM>();
            HIS_ROOM1 = new HashSet<HIS_ROOM>();
            HIS_TRANSACTION = new HashSet<HIS_TRANSACTION>();
            HIS_USER_ACCOUNT_BOOK = new HashSet<HIS_USER_ACCOUNT_BOOK>();
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
        public string ACCOUNT_BOOK_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string ACCOUNT_BOOK_NAME { get; set; }

        public long TOTAL { get; set; }

        public long FROM_NUM_ORDER { get; set; }

        public short? IS_FOR_DEPOSIT { get; set; }

        public short? IS_FOR_REPAY { get; set; }

        public short? IS_FOR_BILL { get; set; }

        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        public long? NUM_ORDER { get; set; }

        [StringLength(11)]
        public string TEMPLATE_CODE { get; set; }

        [StringLength(8)]
        public string SYMBOL_CODE { get; set; }

        public long? RELEASE_TIME { get; set; }

        public long? LINK_ID { get; set; }

        public long? BILL_TYPE_ID { get; set; }

        public short? IS_NOT_GEN_TRANSACTION_ORDER { get; set; }

        public long? MAX_ITEM_NUM_PER_TRANS { get; set; }

        public short? IS_FOR_DEBT { get; set; }

        public short? IS_FOR_OTHER_SALE { get; set; }

        public long? WORKING_SHIFT_ID { get; set; }

        public long? EINVOICE_TYPE_ID { get; set; }

        public short? NUM_ORDER_SPLIT_BY_BOOK { get; set; }

        public virtual HIS_WORKING_SHIFT HIS_WORKING_SHIFT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ACCOUNT_BOOK> HIS_ACCOUNT_BOOK1 { get; set; }

        public virtual HIS_ACCOUNT_BOOK HIS_ACCOUNT_BOOK2 { get; set; }

        public virtual HIS_EINVOICE_TYPE HIS_EINVOICE_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_CARO_ACCOUNT_BOOK> HIS_CARO_ACCOUNT_BOOK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ROOM> HIS_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ROOM> HIS_ROOM1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TRANSACTION> HIS_TRANSACTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_USER_ACCOUNT_BOOK> HIS_USER_ACCOUNT_BOOK { get; set; }
    }
}

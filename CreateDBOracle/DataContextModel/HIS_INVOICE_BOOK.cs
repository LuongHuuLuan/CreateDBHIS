namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_INVOICE_BOOK")]
    public partial class HIS_INVOICE_BOOK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_INVOICE_BOOK()
        {
            HIS_INVOICE = new HashSet<HIS_INVOICE>();
            HIS_INVOICE_BOOK1 = new HashSet<HIS_INVOICE_BOOK>();
            HIS_USER_INVOICE_BOOK = new HashSet<HIS_USER_INVOICE_BOOK>();
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

        public long TOTAL { get; set; }

        public long FROM_NUM_ORDER { get; set; }

        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        [Required]
        [StringLength(11)]
        public string TEMPLATE_CODE { get; set; }

        [Required]
        [StringLength(8)]
        public string SYMBOL_CODE { get; set; }

        [StringLength(100)]
        public string INVOICE_BOOK_NAME { get; set; }

        public long? RELEASE_TIME { get; set; }

        public long? LINK_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_INVOICE> HIS_INVOICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_INVOICE_BOOK> HIS_INVOICE_BOOK1 { get; set; }

        public virtual HIS_INVOICE_BOOK HIS_INVOICE_BOOK2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_USER_INVOICE_BOOK> HIS_USER_INVOICE_BOOK { get; set; }
    }
}

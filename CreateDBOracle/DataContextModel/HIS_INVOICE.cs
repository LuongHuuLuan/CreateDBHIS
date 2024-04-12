namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_INVOICE")]
    public partial class HIS_INVOICE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_INVOICE()
        {
            HIS_INVOICE_DETAIL = new HashSet<HIS_INVOICE_DETAIL>();
            HIS_INVOICE_PRINT = new HashSet<HIS_INVOICE_PRINT>();
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

        public long INVOICE_BOOK_ID { get; set; }

        public long NUM_ORDER { get; set; }

        public long INVOICE_TIME { get; set; }

        public long PAY_FORM_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string SELLER_NAME { get; set; }

        [StringLength(500)]
        public string SELLER_ADDRESS { get; set; }

        [StringLength(50)]
        public string SELLER_ACCOUNT_NUMBER { get; set; }

        [StringLength(20)]
        public string SELLER_TAX_CODE { get; set; }

        [StringLength(20)]
        public string SELLER_PHONE { get; set; }

        [Required]
        [StringLength(200)]
        public string BUYER_NAME { get; set; }

        [StringLength(500)]
        public string BUYER_ADDRESS { get; set; }

        [StringLength(100)]
        public string BUYER_ACCOUNT_NUMBER { get; set; }

        [StringLength(20)]
        public string BUYER_TAX_CODE { get; set; }

        public short? IS_CANCEL { get; set; }

        [StringLength(2000)]
        public string CANCEL_REASON { get; set; }

        public long? CANCEL_TIME { get; set; }

        [StringLength(50)]
        public string CANCEL_LOGINNAME { get; set; }

        [StringLength(100)]
        public string CANCEL_USERNAME { get; set; }

        public decimal? DISCOUNT { get; set; }

        [StringLength(200)]
        public string BUYER_ORGANIZATION { get; set; }

        [StringLength(8)]
        public string VIR_NUM_ORDER { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        public decimal? VAT_RATIO { get; set; }

        [StringLength(122)]
        public string VIR_UNIQUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_INVOICE_DETAIL> HIS_INVOICE_DETAIL { get; set; }

        public virtual HIS_INVOICE_BOOK HIS_INVOICE_BOOK { get; set; }

        public virtual HIS_PAY_FORM HIS_PAY_FORM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_INVOICE_PRINT> HIS_INVOICE_PRINT { get; set; }
    }
}

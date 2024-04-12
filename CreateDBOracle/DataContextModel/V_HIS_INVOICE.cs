namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_INVOICE")]
    public partial class V_HIS_INVOICE
    {
        [Key]
        [Column(Order = 0)]
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

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long INVOICE_BOOK_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NUM_ORDER { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long INVOICE_TIME { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PAY_FORM_ID { get; set; }

        [Key]
        [Column(Order = 5)]
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

        [Key]
        [Column(Order = 6)]
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

        [Key]
        [Column(Order = 7)]
        [StringLength(11)]
        public string TEMPLATE_CODE { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(8)]
        public string SYMBOL_CODE { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TOTAL { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long FROM_NUM_ORDER { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(2)]
        public string PAY_FORM_CODE { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(100)]
        public string PAY_FORM_NAME { get; set; }
    }
}

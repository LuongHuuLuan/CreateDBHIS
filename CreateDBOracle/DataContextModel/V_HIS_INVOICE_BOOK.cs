namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_INVOICE_BOOK")]
    public partial class V_HIS_INVOICE_BOOK
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
        public long TOTAL { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long FROM_NUM_ORDER { get; set; }

        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(11)]
        public string TEMPLATE_CODE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(8)]
        public string SYMBOL_CODE { get; set; }

        [StringLength(100)]
        public string INVOICE_BOOK_NAME { get; set; }

        public long? RELEASE_TIME { get; set; }

        public long? LINK_ID { get; set; }

        public decimal? CURRENT_NUM_ORDER { get; set; }
    }
}

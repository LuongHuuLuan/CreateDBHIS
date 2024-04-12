namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_USER_ACCOUNT_BOOK")]
    public partial class V_HIS_USER_ACCOUNT_BOOK
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
        [StringLength(50)]
        public string LOGINNAME { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ACCOUNT_BOOK_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string ACCOUNT_BOOK_CODE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string ACCOUNT_BOOK_NAME { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TOTAL { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

        public short? ACCOUNT_BOOK_IS_ACTIVE { get; set; }

        public decimal? CURRENT_NUM_ORDER { get; set; }
    }
}

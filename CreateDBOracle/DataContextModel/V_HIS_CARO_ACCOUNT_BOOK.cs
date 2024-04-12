namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_CARO_ACCOUNT_BOOK")]
    public partial class V_HIS_CARO_ACCOUNT_BOOK
    {
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

        public long CASHIER_ROOM_ID { get; set; }

        public long ACCOUNT_BOOK_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string CASHIER_ROOM_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string CASHIER_ROOM_NAME { get; set; }

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

        public short? ACCOUNT_BOOK_IS_ACTIVE { get; set; }

        public decimal? CURRENT_NUM_ORDER { get; set; }
    }
}

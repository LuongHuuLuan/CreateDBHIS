namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_IMP_MEST_PAY")]
    public partial class V_HIS_IMP_MEST_PAY
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
        public long IMP_MEST_PROPOSE_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PAY_TIME { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal AMOUNT { get; set; }

        public long? PAY_FORM_ID { get; set; }

        [StringLength(50)]
        public string PAYER_LOGINNAME { get; set; }

        [StringLength(100)]
        public string PAYER_USERNAME { get; set; }

        public long? NEXT_PAY_TIME { get; set; }

        public decimal? NEXT_AMOUNT { get; set; }

        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        [StringLength(200)]
        public string STANDING_ORDER_CODE { get; set; }

        [StringLength(20)]
        public string PAYSLIP_CODE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(8)]
        public string IMP_MEST_PROPOSE_CODE { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SUPPLIER_ID { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string PROPOSE_LOGINNAME { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(10)]
        public string SUPPLIER_CODE { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(1000)]
        public string SUPPLIER_NAME { get; set; }

        [StringLength(2)]
        public string PAY_FORM_CODE { get; set; }

        [StringLength(100)]
        public string PAY_FORM_NAME { get; set; }

        public decimal? TOTAL_PAY { get; set; }

        public decimal? PAYED { get; set; }
    }
}

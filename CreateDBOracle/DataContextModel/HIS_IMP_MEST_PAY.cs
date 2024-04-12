namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_IMP_MEST_PAY")]
    public partial class HIS_IMP_MEST_PAY
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

        public long IMP_MEST_PROPOSE_ID { get; set; }

        public long PAY_TIME { get; set; }

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

        public virtual HIS_IMP_MEST_PROPOSE HIS_IMP_MEST_PROPOSE { get; set; }

        public virtual HIS_PAY_FORM HIS_PAY_FORM { get; set; }
    }
}

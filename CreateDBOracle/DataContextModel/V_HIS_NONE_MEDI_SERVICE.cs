namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_NONE_MEDI_SERVICE")]
    public partial class V_HIS_NONE_MEDI_SERVICE
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

        [Required]
        [StringLength(10)]
        public string NONE_MEDI_SERVICE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string NONE_MEDI_SERVICE_NAME { get; set; }

        public decimal? PRICE { get; set; }

        public long SERVICE_UNIT_ID { get; set; }

        public long? NUM_ORDER { get; set; }

        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [StringLength(10)]
        public string SERVICE_UNIT_SYMBOL { get; set; }
    }
}

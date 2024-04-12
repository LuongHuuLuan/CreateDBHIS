namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_SERE_SERV_14")]
    public partial class V_HIS_SERE_SERV_14
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(500)]
        public string TDL_SERVICE_NAME { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal PRICE { get; set; }

        public short? IS_EXPEND { get; set; }

        public short? IS_NO_EXECUTE { get; set; }

        public decimal? VIR_TOTAL_PRICE { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal AMOUNT { get; set; }

        public decimal? VIR_TOTAL_HEIN_PRICE { get; set; }

        public decimal? VIR_TOTAL_PATIENT_PRICE { get; set; }

        public long? TDL_TREATMENT_ID { get; set; }

        public decimal? TOTAL_DEBT_PRICE { get; set; }
    }
}

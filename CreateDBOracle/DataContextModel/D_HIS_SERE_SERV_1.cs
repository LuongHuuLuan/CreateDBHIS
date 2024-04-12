namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.D_HIS_SERE_SERV_1")]
    public partial class D_HIS_SERE_SERV_1
    {
        public long? TDL_TREATMENT_ID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PATIENT_TYPE_ID { get; set; }

        public decimal? VIR_TOTAL_HEIN_PRICE { get; set; }
    }
}

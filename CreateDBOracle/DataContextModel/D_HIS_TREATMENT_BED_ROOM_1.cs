namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.D_HIS_TREATMENT_BED_ROOM_1")]
    public partial class D_HIS_TREATMENT_BED_ROOM_1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long DEPARTMENT_ID { get; set; }

        public decimal? PATIENT_COUNT { get; set; }
    }
}

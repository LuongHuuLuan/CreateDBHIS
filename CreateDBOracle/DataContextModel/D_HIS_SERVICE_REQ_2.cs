namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.D_HIS_SERVICE_REQ_2")]
    public partial class D_HIS_SERVICE_REQ_2
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TREATMENT_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long REQUEST_DEPARTMENT_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long INTRUCTION_DATE { get; set; }

        [StringLength(20)]
        public string REQUEST_DEPARTMENT_CODE { get; set; }

        [StringLength(100)]
        public string REQUEST_DEPARTMENT_NAME { get; set; }
    }
}

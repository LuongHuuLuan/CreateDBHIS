namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.D_HIS_PATIENT_TYPE_ALTER_1")]
    public partial class D_HIS_PATIENT_TYPE_ALTER_1
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TREATMENT_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long LOG_TIME { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PATIENT_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string PATIENT_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string PATIENT_TYPE_NAME { get; set; }
    }
}

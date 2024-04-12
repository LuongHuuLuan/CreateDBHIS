namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.L_HIS_EXP_MEST_MEDICINE_1")]
    public partial class L_HIS_EXP_MEST_MEDICINE_1
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public long? TDL_SERVICE_REQ_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string MEDICINE_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(500)]
        public string MEDICINE_TYPE_NAME { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(15)]
        public string ACTIVE_INGREDIENT_CODE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(500)]
        public string ACTIVE_INGREDIENT_NAME { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_PATIENT_ID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long INTRUCTION_DATE { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_ANTIBIOTIC_NEW_REG")]
    public partial class V_HIS_ANTIBIOTIC_NEW_REG
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
        [StringLength(1000)]
        public string DOSAGE { get; set; }

        [StringLength(100)]
        public string PERIOD { get; set; }

        [StringLength(100)]
        public string USE_FORM { get; set; }

        public decimal? USE_DAY { get; set; }

        public long ANTIBIOTIC_REQUEST_ID { get; set; }

        public long ACTIVE_INGREDIENT_ID { get; set; }

        [StringLength(1000)]
        public string CONCENTRA { get; set; }

        [Required]
        [StringLength(15)]
        public string ACTIVE_INGREDIENT_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string ACTIVE_INGREDIENT_NAME { get; set; }

        public short? IS_APPROVAL_REQUIRED { get; set; }
    }
}

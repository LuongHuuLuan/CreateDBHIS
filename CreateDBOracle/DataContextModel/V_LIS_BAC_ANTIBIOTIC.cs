namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_LIS_BAC_ANTIBIOTIC")]
    public partial class V_LIS_BAC_ANTIBIOTIC
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

        public long ANTIBIOTIC_ID { get; set; }

        public long BACTERIUM_ID { get; set; }

        public decimal? MIC { get; set; }

        [Required]
        [StringLength(50)]
        public string ANTIBIOTIC_CODE { get; set; }

        [Required]
        [StringLength(200)]
        public string ANTIBIOTIC_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string BACTERIUM_CODE { get; set; }

        [Required]
        [StringLength(200)]
        public string BACTERIUM_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string BACTERIUM_FAMILY_CODE { get; set; }

        [Required]
        [StringLength(200)]
        public string BACTERIUM_FAMILY_NAME { get; set; }
    }
}

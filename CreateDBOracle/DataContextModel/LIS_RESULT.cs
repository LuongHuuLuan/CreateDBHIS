namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.LIS_RESULT")]
    public partial class LIS_RESULT
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

        public long? MACHINE_ID { get; set; }

        [StringLength(8)]
        public string TEST_INDEX_CODE { get; set; }

        [StringLength(1000)]
        public string VALUE { get; set; }

        [StringLength(2)]
        public string SUMMARY_CODE { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        [StringLength(200)]
        public string TEST_INDEX_NAME { get; set; }

        [StringLength(20)]
        public string TEST_INDEX_UNIT_SYMBOL { get; set; }

        [StringLength(50)]
        public string MACHINE_INDEX_CODE { get; set; }

        [StringLength(500)]
        public string MACHINE_INDEX_NAME { get; set; }

        public long? SAMPLE_SERVICE_ID { get; set; }

        public short? IS_RETURN_RESULT { get; set; }

        [StringLength(1000)]
        public string OLD_VALUE { get; set; }

        [StringLength(50)]
        public string MIC { get; set; }

        [StringLength(2)]
        public string SRI_CODE { get; set; }

        [StringLength(50)]
        public string ANTIBIOTIC_CODE { get; set; }

        [StringLength(200)]
        public string ANTIBIOTIC_NAME { get; set; }

        [StringLength(50)]
        public string BACTERIUM_CODE { get; set; }

        [StringLength(200)]
        public string BACTERIUM_NAME { get; set; }

        [StringLength(50)]
        public string BACTERIUM_FAMILY_CODE { get; set; }

        [StringLength(200)]
        public string BACTERIUM_FAMILY_NAME { get; set; }

        public virtual LIS_MACHINE LIS_MACHINE { get; set; }

        public virtual LIS_SAMPLE_SERVICE LIS_SAMPLE_SERVICE { get; set; }
    }
}

namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_LIS_TEST_INDEX_MAP")]
    public partial class V_LIS_TEST_INDEX_MAP
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
        [StringLength(6)]
        public string TEST_INDEX_CODE { get; set; }

        [StringLength(200)]
        public string TEST_INDEX_NAME { get; set; }

        [StringLength(10)]
        public string TEST_INDEX_UNIT_SYMBOL { get; set; }

        public long? MACHINE_INDEX_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string MACHINE_INDEX_CODE { get; set; }

        [StringLength(100)]
        public string MACHINE_INDEX_NAME { get; set; }

        public long MACHINE_ID { get; set; }

        [StringLength(20)]
        public string FORMAT_VALUE { get; set; }

        public decimal? RESULT_COEFFICIENT { get; set; }

        [Required]
        [StringLength(10)]
        public string MACHINE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string MACHINE_NAME { get; set; }

        [StringLength(10)]
        public string EXECUTE_ROOM_CODE { get; set; }
    }
}

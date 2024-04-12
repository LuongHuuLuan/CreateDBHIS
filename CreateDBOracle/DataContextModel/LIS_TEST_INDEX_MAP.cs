namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.LIS_TEST_INDEX_MAP")]
    public partial class LIS_TEST_INDEX_MAP
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

        public virtual LIS_MACHINE_INDEX LIS_MACHINE_INDEX { get; set; }
    }
}

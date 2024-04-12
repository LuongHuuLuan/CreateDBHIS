namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_TEST_INDEX_RANGE")]
    public partial class HIS_TEST_INDEX_RANGE
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

        public long TEST_INDEX_ID { get; set; }

        [StringLength(100)]
        public string MIN_VALUE { get; set; }

        [StringLength(100)]
        public string MAX_VALUE { get; set; }

        public short? IS_MALE { get; set; }

        public short? IS_FEMALE { get; set; }

        public long? AGE_FROM { get; set; }

        public long? AGE_TO { get; set; }

        [StringLength(100)]
        public string NORMAL_VALUE { get; set; }

        public short? IS_ACCEPT_EQUAL_MIN { get; set; }

        public short? IS_ACCEPT_EQUAL_MAX { get; set; }

        [StringLength(100)]
        public string WARNING_MIN_VALUE { get; set; }

        [StringLength(100)]
        public string WARNING_MAX_VALUE { get; set; }

        public short? IS_ACCEPT_EQUAL_WARNING_MIN { get; set; }

        public short? IS_ACCEPT_EQUAL_WARNING_MAX { get; set; }

        public long? AGE_TYPE_ID { get; set; }

        public virtual HIS_AGE_TYPE HIS_AGE_TYPE { get; set; }

        public virtual HIS_TEST_INDEX HIS_TEST_INDEX { get; set; }
    }
}

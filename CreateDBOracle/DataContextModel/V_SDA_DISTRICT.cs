namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_SDA_DISTRICT")]
    public partial class V_SDA_DISTRICT
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
        [StringLength(4)]
        public string DISTRICT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string DISTRICT_NAME { get; set; }

        [StringLength(20)]
        public string INITIAL_NAME { get; set; }

        public long PROVINCE_ID { get; set; }

        [StringLength(10)]
        public string SEARCH_CODE { get; set; }

        [Required]
        [StringLength(3)]
        public string PROVINCE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string PROVINCE_NAME { get; set; }

        [StringLength(124)]
        public string ID_PATH { get; set; }

        [StringLength(14)]
        public string CODE_PATH { get; set; }
    }
}

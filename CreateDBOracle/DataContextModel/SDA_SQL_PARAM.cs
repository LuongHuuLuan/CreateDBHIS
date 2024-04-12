namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.SDA_SQL_PARAM")]
    public partial class SDA_SQL_PARAM
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

        [StringLength(20)]
        public string GROUP_CODE { get; set; }

        [Required]
        [StringLength(200)]
        public string SQL_PARAM_NAME { get; set; }

        public long PARAM_ORDER { get; set; }

        public long SQL_PARAM_TYPE { get; set; }

        public long SQL_ID { get; set; }

        public short? IS_REQUIRED { get; set; }

        [StringLength(1000)]
        public string NOTE { get; set; }

        public virtual SDA_SQL SDA_SQL { get; set; }
    }
}

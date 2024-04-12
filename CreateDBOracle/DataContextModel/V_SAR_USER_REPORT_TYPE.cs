namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_SAR_USER_REPORT_TYPE")]
    public partial class V_SAR_USER_REPORT_TYPE
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
        [StringLength(50)]
        public string LOGINNAME { get; set; }

        public long REPORT_TYPE_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string REPORT_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string REPORT_TYPE_NAME { get; set; }

        public long? REPORT_TYPE_GROUP_ID { get; set; }
    }
}
